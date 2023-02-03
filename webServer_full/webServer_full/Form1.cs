using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.CodeDom;

namespace webServer_full
{
    public partial class frmHome : Form
    {
        static HttpClient client = new HttpClient();

        public frmHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlGet.Hide();
            pnlCreate.Hide();
            pnlUpdate.Hide();
            pnlDelete.Hide();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void populateComboBox(ComboBox cmb)
        {
            if (cmb.Name == "cmbPostID")
            {
                List<Post> listaPost = await getListaPost();
                foreach (var post in listaPost)
                {
                    cmb.Items.Add(post.id);
                }
            }
            else if (cmb.Name == "cmbCommID_get" || cmb.Name == "cmbCommID_update" || cmb.Name == "cmbCommID_delete")
            {
                List<Comment> listaCommenti = await getListaCommenti();
                foreach (var comment in listaCommenti)
                {
                    cmb.Items.Add(comment.id);
                }
            }
        }

        static async Task<List<Comment>> getListaCommenti()
        {
            List<Comment> lista = null;
            HttpResponseMessage response = await client.GetAsync("/comments");
            if (response.IsSuccessStatusCode)
            {
                lista = await System.Text.Json.JsonSerializer.DeserializeAsync<List<Comment>>(await response.Content.ReadAsStreamAsync());
            }
            return lista;
        }

        static async Task<List<Post>> getListaPost()
        {
            List<Post> lista = null;
            HttpResponseMessage response = await client.GetAsync("/posts");
            if (response.IsSuccessStatusCode)
            {
                lista = await System.Text.Json.JsonSerializer.DeserializeAsync<List<Post>>(await response.Content.ReadAsStreamAsync());
            }
            return lista;
        }

        static async Task<Comment> GetCommentAsync(string path)
        {
            Comment product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await System.Text.Json.JsonSerializer.DeserializeAsync<Comment>(await response.Content.ReadAsStreamAsync());
            }
            return product;
        }

        static async Task<Uri> CreateProductAsync(Comment product)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("/comments", product);
            response.EnsureSuccessStatusCode();

            // restituisce l'URI della risorsa appena creata
            return response.Headers.Location;
        }

        static async Task<Comment> UpdateProductAsync(Comment product)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"/comments/{product.id}", product);
            response.EnsureSuccessStatusCode();

            product = await System.Text.Json.JsonSerializer.DeserializeAsync<Comment>(await response.Content.ReadAsStreamAsync());
            return product;
        }

        static async Task<HttpStatusCode> DeleteProductAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"/comments/{id}");
            return response.StatusCode;
        }

        static void ShowProduct(Comment comment)
        {
            MessageBox.Show(comment.ToString());
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            populateComboBox(cmbCommID_get);
            pnlCreate.Hide();
            pnlUpdate.Hide();
            pnlDelete.Hide();
            pnlGet.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            populateComboBox(cmbPostID);
            pnlGet.Hide();
            pnlUpdate.Hide();
            pnlDelete.Hide();
            pnlCreate.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            populateComboBox(cmbCommID_update);
            pnlGet.Hide();
            pnlDelete.Hide();
            pnlCreate.Hide();
            pnlUpdate.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            populateComboBox(cmbCommID_delete);
            pnlGet.Hide();
            pnlCreate.Hide();
            pnlUpdate.Hide();
            pnlDelete.Show();
        }

        private async void btnConfirmCreate_Click(object sender, EventArgs e)
        {
            if (cmbPostID.SelectedItem != null && txtCommentID.Text != "" && txtName.Text != "" && txtEmail.Text != "" && rTxtBody.Text != "")
            {
                Comment comment = new Comment();
                comment.postId = Int32.Parse(cmbPostID.Text);
                comment.id = Int32.Parse(txtCommentID.Text);
                comment.name = txtName.Text;
                comment.body = rTxtBody.Text;
                var url = await CreateProductAsync(comment);
                MessageBox.Show($"Nuovo commento aggiunto a {url}");

                cmbPostID.SelectedItem = null;
                txtCommentID.Text = "";
                txtName.Text = "";
                txtEmail.Text = "";
                rTxtBody.Text = "";
            }
            else
            {
                MessageBox.Show("Per completare l'operazione è necessario completare tutti i campi.");
            }
        }

        private async void btnConfirmUpdate_Click(object sender, EventArgs e)
        {
            Comment comment = new Comment();
            comment.id = Int32.Parse(cmbCommID_update.Text);
            if (cmbCommID_update.SelectedItem != null && cmbField.SelectedItem != null && txtNewValue.Text != "")
            {
                if (cmbField.Text == "Name")
                {
                    comment.name = txtNewValue.Text;
                }
                else if (cmbField.Text == "Email")
                {
                    comment.email = txtNewValue.Text;
                }
                else if (cmbField.Text == "Body")
                {
                    comment.body = txtNewValue.Text;
                }

                await UpdateProductAsync(comment);
                MessageBox.Show("Successfully updated.");

                cmbCommID_update.SelectedItem = null;
                cmbField.SelectedItem = null;
                txtNewValue.Text = "";
            }
            else
            {
                MessageBox.Show("Per completare l'operazione è necessario completare tutti i campi.");
            }
        }

        private async void btnConfirmDelete_Click(object sender, EventArgs e)
        {
            if (cmbCommID_delete.SelectedItem != null)
            {
                Comment comment = new Comment();
                comment.id = Int32.Parse(cmbCommID_delete.Text);
                var statusCode = await DeleteProductAsync(comment.id + "");
                MessageBox.Show($"Deleted (HTTP Status = {(int)statusCode})");
                cmbCommID_delete.SelectedItem = null;
            }
        }

        private async void btnConfirmGet_Click(object sender, EventArgs e)
        {
            if (cmbCommID_get.SelectedItem != null)
            {
                Comment comment = null;
                comment = await GetCommentAsync("/comments/" + cmbCommID_get.Text);
                MessageBox.Show("Received: " + comment.id.ToString() + " - " + comment.name);
                cmbCommID_get.SelectedItem = null;
            }
        }
    }

    public class Comment
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }

        override
        public string ToString()
        {
            return id.ToString() + " - " + name + "\nPost: " + postId + "\nBODY:\n" + body;
        }
    }

    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
