
namespace webServer_full
{
    partial class frmHome
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGet = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.cmbPostID = new System.Windows.Forms.ComboBox();
            this.btnConfirmCreate = new System.Windows.Forms.Button();
            this.rTxtBody = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCommentID = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCommentID = new System.Windows.Forms.Label();
            this.lblPostID = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.cmbCommID_update = new System.Windows.Forms.ComboBox();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.lblNewValue = new System.Windows.Forms.Label();
            this.txtNewValue = new System.Windows.Forms.TextBox();
            this.btnConfirmUpdate = new System.Windows.Forms.Button();
            this.lblCommID_update = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.btnConfirmDelete = new System.Windows.Forms.Button();
            this.cmbCommID_delete = new System.Windows.Forms.ComboBox();
            this.lblCommID_delete = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.pnlGet = new System.Windows.Forms.Panel();
            this.btnConfirmGet = new System.Windows.Forms.Button();
            this.cmbCommID_get = new System.Windows.Forms.ComboBox();
            this.lblCommID_get = new System.Windows.Forms.Label();
            this.lblGet = new System.Windows.Forms.Label();
            this.pnlCreate.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.pnlGet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.Orange;
            this.btnGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGet.FlatAppearance.BorderSize = 0;
            this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGet.Location = new System.Drawing.Point(63, 86);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Orange;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Location = new System.Drawing.Point(207, 86);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(343, 86);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Orange;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(483, 86);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlCreate
            // 
            this.pnlCreate.Controls.Add(this.cmbPostID);
            this.pnlCreate.Controls.Add(this.btnConfirmCreate);
            this.pnlCreate.Controls.Add(this.rTxtBody);
            this.pnlCreate.Controls.Add(this.txtName);
            this.pnlCreate.Controls.Add(this.txtEmail);
            this.pnlCreate.Controls.Add(this.txtCommentID);
            this.pnlCreate.Controls.Add(this.lblBody);
            this.pnlCreate.Controls.Add(this.lblEmail);
            this.pnlCreate.Controls.Add(this.lblName);
            this.pnlCreate.Controls.Add(this.lblCommentID);
            this.pnlCreate.Controls.Add(this.lblPostID);
            this.pnlCreate.Controls.Add(this.lblCreate);
            this.pnlCreate.Location = new System.Drawing.Point(33, 140);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(495, 264);
            this.pnlCreate.TabIndex = 4;
            // 
            // cmbPostID
            // 
            this.cmbPostID.FormattingEnabled = true;
            this.cmbPostID.Location = new System.Drawing.Point(78, 53);
            this.cmbPostID.Name = "cmbPostID";
            this.cmbPostID.Size = new System.Drawing.Size(121, 21);
            this.cmbPostID.TabIndex = 6;
            // 
            // btnConfirmCreate
            // 
            this.btnConfirmCreate.BackColor = System.Drawing.Color.Orange;
            this.btnConfirmCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmCreate.FlatAppearance.BorderSize = 0;
            this.btnConfirmCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmCreate.Location = new System.Drawing.Point(203, 225);
            this.btnConfirmCreate.Name = "btnConfirmCreate";
            this.btnConfirmCreate.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmCreate.TabIndex = 15;
            this.btnConfirmCreate.Text = "OK";
            this.btnConfirmCreate.UseVisualStyleBackColor = false;
            this.btnConfirmCreate.Click += new System.EventHandler(this.btnConfirmCreate_Click);
            // 
            // rTxtBody
            // 
            this.rTxtBody.Location = new System.Drawing.Point(78, 133);
            this.rTxtBody.Name = "rTxtBody";
            this.rTxtBody.Size = new System.Drawing.Size(358, 61);
            this.rTxtBody.TabIndex = 14;
            this.rTxtBody.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(336, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtCommentID
            // 
            this.txtCommentID.Location = new System.Drawing.Point(336, 54);
            this.txtCommentID.Name = "txtCommentID";
            this.txtCommentID.Size = new System.Drawing.Size(100, 20);
            this.txtCommentID.TabIndex = 10;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(41, 136);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(34, 13);
            this.lblBody.TabIndex = 5;
            this.lblBody.Text = "Body:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(295, 93);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblCommentID
            // 
            this.lblCommentID.AutoSize = true;
            this.lblCommentID.Location = new System.Drawing.Point(309, 57);
            this.lblCommentID.Name = "lblCommentID";
            this.lblCommentID.Size = new System.Drawing.Size(21, 13);
            this.lblCommentID.TabIndex = 2;
            this.lblCommentID.Text = "ID:";
            // 
            // lblPostID
            // 
            this.lblPostID.AutoSize = true;
            this.lblPostID.Location = new System.Drawing.Point(27, 57);
            this.lblPostID.Name = "lblPostID";
            this.lblPostID.Size = new System.Drawing.Size(45, 13);
            this.lblPostID.TabIndex = 1;
            this.lblPostID.Text = "Post ID:";
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate.Location = new System.Drawing.Point(199, 10);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(93, 24);
            this.lblCreate.TabIndex = 0;
            this.lblCreate.Text = "CREATE";
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.cmbCommID_update);
            this.pnlUpdate.Controls.Add(this.cmbField);
            this.pnlUpdate.Controls.Add(this.lblNewValue);
            this.pnlUpdate.Controls.Add(this.txtNewValue);
            this.pnlUpdate.Controls.Add(this.btnConfirmUpdate);
            this.pnlUpdate.Controls.Add(this.lblCommID_update);
            this.pnlUpdate.Controls.Add(this.lblUpdate);
            this.pnlUpdate.Controls.Add(this.lblField);
            this.pnlUpdate.Location = new System.Drawing.Point(30, 140);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(259, 216);
            this.pnlUpdate.TabIndex = 5;
            // 
            // cmbCommID_update
            // 
            this.cmbCommID_update.FormattingEnabled = true;
            this.cmbCommID_update.Location = new System.Drawing.Point(111, 53);
            this.cmbCommID_update.Name = "cmbCommID_update";
            this.cmbCommID_update.Size = new System.Drawing.Size(121, 21);
            this.cmbCommID_update.TabIndex = 20;
            // 
            // cmbField
            // 
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Items.AddRange(new object[] {
            "Name",
            "Email",
            "Body"});
            this.cmbField.Location = new System.Drawing.Point(111, 88);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(121, 21);
            this.cmbField.TabIndex = 19;
            // 
            // lblNewValue
            // 
            this.lblNewValue.AutoSize = true;
            this.lblNewValue.Location = new System.Drawing.Point(44, 132);
            this.lblNewValue.Name = "lblNewValue";
            this.lblNewValue.Size = new System.Drawing.Size(61, 13);
            this.lblNewValue.TabIndex = 18;
            this.lblNewValue.Text = "New value:";
            // 
            // txtNewValue
            // 
            this.txtNewValue.Location = new System.Drawing.Point(111, 129);
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewValue.TabIndex = 17;
            // 
            // btnConfirmUpdate
            // 
            this.btnConfirmUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnConfirmUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmUpdate.FlatAppearance.BorderSize = 0;
            this.btnConfirmUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmUpdate.Location = new System.Drawing.Point(93, 180);
            this.btnConfirmUpdate.Name = "btnConfirmUpdate";
            this.btnConfirmUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmUpdate.TabIndex = 16;
            this.btnConfirmUpdate.Text = "OK";
            this.btnConfirmUpdate.UseVisualStyleBackColor = false;
            this.btnConfirmUpdate.Click += new System.EventHandler(this.btnConfirmUpdate_Click);
            // 
            // lblCommID_update
            // 
            this.lblCommID_update.AutoSize = true;
            this.lblCommID_update.Location = new System.Drawing.Point(32, 57);
            this.lblCommID_update.Name = "lblCommID_update";
            this.lblCommID_update.Size = new System.Drawing.Size(68, 13);
            this.lblCommID_update.TabIndex = 4;
            this.lblCommID_update.Text = "Comment ID:";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(76, 10);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(92, 24);
            this.lblUpdate.TabIndex = 3;
            this.lblUpdate.Text = "UPDATE";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(61, 93);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(32, 13);
            this.lblField.TabIndex = 2;
            this.lblField.Text = "Field:";
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.btnConfirmDelete);
            this.pnlDelete.Controls.Add(this.cmbCommID_delete);
            this.pnlDelete.Controls.Add(this.lblCommID_delete);
            this.pnlDelete.Controls.Add(this.lblDelete);
            this.pnlDelete.Location = new System.Drawing.Point(27, 137);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(259, 137);
            this.pnlDelete.TabIndex = 6;
            // 
            // btnConfirmDelete
            // 
            this.btnConfirmDelete.BackColor = System.Drawing.Color.Orange;
            this.btnConfirmDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmDelete.FlatAppearance.BorderSize = 0;
            this.btnConfirmDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmDelete.Location = new System.Drawing.Point(93, 96);
            this.btnConfirmDelete.Name = "btnConfirmDelete";
            this.btnConfirmDelete.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmDelete.TabIndex = 23;
            this.btnConfirmDelete.Text = "OK";
            this.btnConfirmDelete.UseVisualStyleBackColor = false;
            this.btnConfirmDelete.Click += new System.EventHandler(this.btnConfirmDelete_Click);
            // 
            // cmbCommID_delete
            // 
            this.cmbCommID_delete.FormattingEnabled = true;
            this.cmbCommID_delete.Location = new System.Drawing.Point(111, 51);
            this.cmbCommID_delete.Name = "cmbCommID_delete";
            this.cmbCommID_delete.Size = new System.Drawing.Size(121, 21);
            this.cmbCommID_delete.TabIndex = 22;
            // 
            // lblCommID_delete
            // 
            this.lblCommID_delete.AutoSize = true;
            this.lblCommID_delete.Location = new System.Drawing.Point(32, 55);
            this.lblCommID_delete.Name = "lblCommID_delete";
            this.lblCommID_delete.Size = new System.Drawing.Size(68, 13);
            this.lblCommID_delete.TabIndex = 21;
            this.lblCommID_delete.Text = "Comment ID:";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(78, 13);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(90, 24);
            this.lblDelete.TabIndex = 4;
            this.lblDelete.Text = "DELETE";
            // 
            // pnlGet
            // 
            this.pnlGet.Controls.Add(this.btnConfirmGet);
            this.pnlGet.Controls.Add(this.cmbCommID_get);
            this.pnlGet.Controls.Add(this.lblCommID_get);
            this.pnlGet.Controls.Add(this.lblGet);
            this.pnlGet.Location = new System.Drawing.Point(33, 140);
            this.pnlGet.Name = "pnlGet";
            this.pnlGet.Size = new System.Drawing.Size(259, 137);
            this.pnlGet.TabIndex = 7;
            // 
            // btnConfirmGet
            // 
            this.btnConfirmGet.BackColor = System.Drawing.Color.Orange;
            this.btnConfirmGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmGet.FlatAppearance.BorderSize = 0;
            this.btnConfirmGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmGet.Location = new System.Drawing.Point(93, 96);
            this.btnConfirmGet.Name = "btnConfirmGet";
            this.btnConfirmGet.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmGet.TabIndex = 23;
            this.btnConfirmGet.Text = "OK";
            this.btnConfirmGet.UseVisualStyleBackColor = false;
            this.btnConfirmGet.Click += new System.EventHandler(this.btnConfirmGet_Click);
            // 
            // cmbCommID_get
            // 
            this.cmbCommID_get.FormattingEnabled = true;
            this.cmbCommID_get.Location = new System.Drawing.Point(111, 51);
            this.cmbCommID_get.Name = "cmbCommID_get";
            this.cmbCommID_get.Size = new System.Drawing.Size(121, 21);
            this.cmbCommID_get.TabIndex = 22;
            // 
            // lblCommID_get
            // 
            this.lblCommID_get.AutoSize = true;
            this.lblCommID_get.Location = new System.Drawing.Point(32, 55);
            this.lblCommID_get.Name = "lblCommID_get";
            this.lblCommID_get.Size = new System.Drawing.Size(68, 13);
            this.lblCommID_get.TabIndex = 21;
            this.lblCommID_get.Text = "Comment ID:";
            // 
            // lblGet
            // 
            this.lblGet.AutoSize = true;
            this.lblGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGet.Location = new System.Drawing.Point(105, 13);
            this.lblGet.Name = "lblGet";
            this.lblGet.Size = new System.Drawing.Size(52, 24);
            this.lblGet.TabIndex = 4;
            this.lblGet.Text = "GET";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 445);
            this.Controls.Add(this.pnlGet);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.pnlCreate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnGet);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCreate.ResumeLayout(false);
            this.pnlCreate.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.pnlDelete.ResumeLayout(false);
            this.pnlDelete.PerformLayout();
            this.pnlGet.ResumeLayout(false);
            this.pnlGet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlCreate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCommentID;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCommentID;
        private System.Windows.Forms.Label lblPostID;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.RichTextBox rTxtBody;
        private System.Windows.Forms.Button btnConfirmCreate;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Label lblCommID_update;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Button btnConfirmUpdate;
        private System.Windows.Forms.Label lblNewValue;
        private System.Windows.Forms.TextBox txtNewValue;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.ComboBox cmbCommID_update;
        private System.Windows.Forms.ComboBox cmbPostID;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.ComboBox cmbCommID_delete;
        private System.Windows.Forms.Label lblCommID_delete;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Button btnConfirmDelete;
        private System.Windows.Forms.Panel pnlGet;
        private System.Windows.Forms.Button btnConfirmGet;
        private System.Windows.Forms.ComboBox cmbCommID_get;
        private System.Windows.Forms.Label lblCommID_get;
        private System.Windows.Forms.Label lblGet;
    }
}

