namespace Library
{
    partial class UpdateBook
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
            this.cbxUpdateType = new System.Windows.Forms.ComboBox();
            this.rtbxUpdateContent = new System.Windows.Forms.RichTextBox();
            this.tbxUpdatePage = new System.Windows.Forms.TextBox();
            this.tbxUpdateAuthor = new System.Windows.Forms.TextBox();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxUpdateType
            // 
            this.cbxUpdateType.FormattingEnabled = true;
            this.cbxUpdateType.Location = new System.Drawing.Point(328, 92);
            this.cbxUpdateType.Name = "cbxUpdateType";
            this.cbxUpdateType.Size = new System.Drawing.Size(251, 21);
            this.cbxUpdateType.TabIndex = 21;
            // 
            // rtbxUpdateContent
            // 
            this.rtbxUpdateContent.Location = new System.Drawing.Point(328, 210);
            this.rtbxUpdateContent.Name = "rtbxUpdateContent";
            this.rtbxUpdateContent.Size = new System.Drawing.Size(251, 96);
            this.rtbxUpdateContent.TabIndex = 20;
            this.rtbxUpdateContent.Text = "";
            // 
            // tbxUpdatePage
            // 
            this.tbxUpdatePage.Location = new System.Drawing.Point(328, 123);
            this.tbxUpdatePage.Name = "tbxUpdatePage";
            this.tbxUpdatePage.Size = new System.Drawing.Size(251, 20);
            this.tbxUpdatePage.TabIndex = 19;
            // 
            // tbxUpdateAuthor
            // 
            this.tbxUpdateAuthor.Location = new System.Drawing.Point(328, 160);
            this.tbxUpdateAuthor.Name = "tbxUpdateAuthor";
            this.tbxUpdateAuthor.Size = new System.Drawing.Size(251, 20);
            this.tbxUpdateAuthor.TabIndex = 18;
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(328, 60);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(251, 20);
            this.tbxUpdateName.TabIndex = 17;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(416, 371);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(65, 19);
            this.btnUpdateBook.TabIndex = 16;
            this.btnUpdateBook.Text = "Güncelle";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.BtnUpdateBook_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "İçerik :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Yazar Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sayfa Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Türü :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Adı :";
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxUpdateType);
            this.Controls.Add(this.rtbxUpdateContent);
            this.Controls.Add(this.tbxUpdatePage);
            this.Controls.Add(this.tbxUpdateAuthor);
            this.Controls.Add(this.tbxUpdateName);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateBook";
            this.Text = "UpdateBook";
            this.Load += new System.EventHandler(this.UpdateBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxUpdateType;
        private System.Windows.Forms.RichTextBox rtbxUpdateContent;
        private System.Windows.Forms.TextBox tbxUpdatePage;
        private System.Windows.Forms.TextBox tbxUpdateAuthor;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}