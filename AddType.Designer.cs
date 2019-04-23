namespace Library
{
    partial class AddType
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
            this.btnAddType = new System.Windows.Forms.Button();
            this.lblAddType = new System.Windows.Forms.Label();
            this.tbxAddType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(304, 176);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(110, 23);
            this.btnAddType.TabIndex = 0;
            this.btnAddType.Text = "Kitap Türü Ekle";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.BtnAddType_Click);
            // 
            // lblAddType
            // 
            this.lblAddType.AutoSize = true;
            this.lblAddType.Location = new System.Drawing.Point(241, 102);
            this.lblAddType.Name = "lblAddType";
            this.lblAddType.Size = new System.Drawing.Size(56, 13);
            this.lblAddType.TabIndex = 1;
            this.lblAddType.Text = "Kitap Türü";
            // 
            // tbxAddType
            // 
            this.tbxAddType.Location = new System.Drawing.Point(341, 99);
            this.tbxAddType.Name = "tbxAddType";
            this.tbxAddType.Size = new System.Drawing.Size(100, 20);
            this.tbxAddType.TabIndex = 2;
            // 
            // AddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxAddType);
            this.Controls.Add(this.lblAddType);
            this.Controls.Add(this.btnAddType);
            this.Name = "AddType";
            this.Text = "AddType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Label lblAddType;
        private System.Windows.Forms.TextBox tbxAddType;
    }
}