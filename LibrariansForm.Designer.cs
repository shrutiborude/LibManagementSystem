namespace LibManagementSystem_Updated
{
    partial class LibrariansForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLibName = new System.Windows.Forms.TextBox();
            this.dataGridViewLibrarianForm = new System.Windows.Forms.DataGridView();
            this.btnLibDelete = new System.Windows.Forms.Button();
            this.btnLibUpdate = new System.Windows.Forms.Button();
            this.btnLibSave = new System.Windows.Forms.Button();
            this.textBoxLibContact = new System.Windows.Forms.TextBox();
            this.textBoxLibID = new System.Windows.Forms.TextBox();
            this.labelLibContact = new System.Windows.Forms.Label();
            this.labelLibID = new System.Windows.Forms.Label();
            this.labelLibName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrarianForm)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLibName
            // 
            this.textBoxLibName.Location = new System.Drawing.Point(567, 80);
            this.textBoxLibName.Name = "textBoxLibName";
            this.textBoxLibName.Size = new System.Drawing.Size(193, 38);
            this.textBoxLibName.TabIndex = 20;
            // 
            // dataGridViewLibrarianForm
            // 
            this.dataGridViewLibrarianForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibrarianForm.Location = new System.Drawing.Point(12, 434);
            this.dataGridViewLibrarianForm.Name = "dataGridViewLibrarianForm";
            this.dataGridViewLibrarianForm.RowHeadersWidth = 102;
            this.dataGridViewLibrarianForm.RowTemplate.Height = 40;
            this.dataGridViewLibrarianForm.Size = new System.Drawing.Size(1796, 713);
            this.dataGridViewLibrarianForm.TabIndex = 19;
            this.dataGridViewLibrarianForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLibrarianForm_CellContentClick);
            // 
            // btnLibDelete
            // 
            this.btnLibDelete.Location = new System.Drawing.Point(1514, 166);
            this.btnLibDelete.Name = "btnLibDelete";
            this.btnLibDelete.Size = new System.Drawing.Size(161, 86);
            this.btnLibDelete.TabIndex = 18;
            this.btnLibDelete.Text = "Delete";
            this.btnLibDelete.UseVisualStyleBackColor = true;
            this.btnLibDelete.Click += new System.EventHandler(this.btnLibDelete_Click);
            // 
            // btnLibUpdate
            // 
            this.btnLibUpdate.Location = new System.Drawing.Point(1244, 169);
            this.btnLibUpdate.Name = "btnLibUpdate";
            this.btnLibUpdate.Size = new System.Drawing.Size(161, 86);
            this.btnLibUpdate.TabIndex = 17;
            this.btnLibUpdate.Text = "Update";
            this.btnLibUpdate.UseVisualStyleBackColor = true;
            this.btnLibUpdate.Click += new System.EventHandler(this.btnLibUpdate_Click);
            // 
            // btnLibSave
            // 
            this.btnLibSave.Location = new System.Drawing.Point(997, 166);
            this.btnLibSave.Name = "btnLibSave";
            this.btnLibSave.Size = new System.Drawing.Size(161, 86);
            this.btnLibSave.TabIndex = 16;
            this.btnLibSave.Text = "Save";
            this.btnLibSave.UseVisualStyleBackColor = true;
            this.btnLibSave.Click += new System.EventHandler(this.btnLibSave_Click);
            // 
            // textBoxLibContact
            // 
            this.textBoxLibContact.Location = new System.Drawing.Point(567, 274);
            this.textBoxLibContact.Name = "textBoxLibContact";
            this.textBoxLibContact.Size = new System.Drawing.Size(193, 38);
            this.textBoxLibContact.TabIndex = 15;
            // 
            // textBoxLibID
            // 
            this.textBoxLibID.Location = new System.Drawing.Point(567, 169);
            this.textBoxLibID.Name = "textBoxLibID";
            this.textBoxLibID.Size = new System.Drawing.Size(193, 38);
            this.textBoxLibID.TabIndex = 14;
            // 
            // labelLibContact
            // 
            this.labelLibContact.AutoSize = true;
            this.labelLibContact.Location = new System.Drawing.Point(237, 274);
            this.labelLibContact.Name = "labelLibContact";
            this.labelLibContact.Size = new System.Drawing.Size(112, 32);
            this.labelLibContact.TabIndex = 13;
            this.labelLibContact.Text = "Contact";
            // 
            // labelLibID
            // 
            this.labelLibID.AutoSize = true;
            this.labelLibID.Location = new System.Drawing.Point(237, 169);
            this.labelLibID.Name = "labelLibID";
            this.labelLibID.Size = new System.Drawing.Size(175, 32);
            this.labelLibID.TabIndex = 12;
            this.labelLibID.Text = "Employee ID";
            // 
            // labelLibName
            // 
            this.labelLibName.AutoSize = true;
            this.labelLibName.Location = new System.Drawing.Point(237, 68);
            this.labelLibName.Name = "labelLibName";
            this.labelLibName.Size = new System.Drawing.Size(89, 32);
            this.labelLibName.TabIndex = 11;
            this.labelLibName.Text = "Name";
            // 
            // LibrariansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 1160);
            this.Controls.Add(this.textBoxLibName);
            this.Controls.Add(this.dataGridViewLibrarianForm);
            this.Controls.Add(this.btnLibDelete);
            this.Controls.Add(this.btnLibUpdate);
            this.Controls.Add(this.btnLibSave);
            this.Controls.Add(this.textBoxLibContact);
            this.Controls.Add(this.textBoxLibID);
            this.Controls.Add(this.labelLibContact);
            this.Controls.Add(this.labelLibID);
            this.Controls.Add(this.labelLibName);
            this.Name = "LibrariansForm";
            this.Text = "Librarians Page";
            this.Load += new System.EventHandler(this.LibrariansForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrarianForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLibName;
        private System.Windows.Forms.DataGridView dataGridViewLibrarianForm;
        private System.Windows.Forms.Button btnLibDelete;
        private System.Windows.Forms.Button btnLibUpdate;
        private System.Windows.Forms.Button btnLibSave;
        private System.Windows.Forms.TextBox textBoxLibContact;
        private System.Windows.Forms.TextBox textBoxLibID;
        private System.Windows.Forms.Label labelLibContact;
        private System.Windows.Forms.Label labelLibID;
        private System.Windows.Forms.Label labelLibName;
    }
}