namespace LibManagementSystem_Updated
{
    partial class Form1
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
            this.studbutton = new System.Windows.Forms.Button();
            this.libbutton = new System.Windows.Forms.Button();
            this.bookbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studbutton
            // 
            this.studbutton.Location = new System.Drawing.Point(360, 251);
            this.studbutton.Name = "studbutton";
            this.studbutton.Size = new System.Drawing.Size(259, 147);
            this.studbutton.TabIndex = 0;
            this.studbutton.Text = "Students";
            this.studbutton.UseVisualStyleBackColor = true;
            this.studbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // libbutton
            // 
            this.libbutton.Location = new System.Drawing.Point(716, 251);
            this.libbutton.Name = "libbutton";
            this.libbutton.Size = new System.Drawing.Size(259, 147);
            this.libbutton.TabIndex = 1;
            this.libbutton.Text = "Librarians";
            this.libbutton.UseVisualStyleBackColor = true;
            this.libbutton.Click += new System.EventHandler(this.libbutton_Click);
            // 
            // bookbutton
            // 
            this.bookbutton.Location = new System.Drawing.Point(1079, 251);
            this.bookbutton.Name = "bookbutton";
            this.bookbutton.Size = new System.Drawing.Size(259, 147);
            this.bookbutton.TabIndex = 2;
            this.bookbutton.Text = "Books";
            this.bookbutton.UseVisualStyleBackColor = true;
            this.bookbutton.Click += new System.EventHandler(this.bookbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 755);
            this.Controls.Add(this.bookbutton);
            this.Controls.Add(this.libbutton);
            this.Controls.Add(this.studbutton);
            this.Name = "Form1";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studbutton;
        private System.Windows.Forms.Button libbutton;
        private System.Windows.Forms.Button bookbutton;
    }
}

