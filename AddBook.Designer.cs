namespace Library
{
    partial class AddBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.tbxAddName = new System.Windows.Forms.TextBox();
            this.tbxAddAuthor = new System.Windows.Forms.TextBox();
            this.tbxAddPage = new System.Windows.Forms.TextBox();
            this.rtbxAddContent = new System.Windows.Forms.RichTextBox();
            this.cbxAddType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türü :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sayfa Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yazar Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "İçerik :";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(317, 351);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(65, 19);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Ekle";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // tbxAddName
            // 
            this.tbxAddName.Location = new System.Drawing.Point(229, 40);
            this.tbxAddName.Name = "tbxAddName";
            this.tbxAddName.Size = new System.Drawing.Size(251, 20);
            this.tbxAddName.TabIndex = 6;
            // 
            // tbxAddAuthor
            // 
            this.tbxAddAuthor.Location = new System.Drawing.Point(229, 140);
            this.tbxAddAuthor.Name = "tbxAddAuthor";
            this.tbxAddAuthor.Size = new System.Drawing.Size(251, 20);
            this.tbxAddAuthor.TabIndex = 7;
            // 
            // tbxAddPage
            // 
            this.tbxAddPage.Location = new System.Drawing.Point(229, 103);
            this.tbxAddPage.Name = "tbxAddPage";
            this.tbxAddPage.Size = new System.Drawing.Size(251, 20);
            this.tbxAddPage.TabIndex = 8;
            // 
            // rtbxAddContent
            // 
            this.rtbxAddContent.Location = new System.Drawing.Point(229, 190);
            this.rtbxAddContent.Name = "rtbxAddContent";
            this.rtbxAddContent.Size = new System.Drawing.Size(251, 96);
            this.rtbxAddContent.TabIndex = 9;
            this.rtbxAddContent.Text = "";
            // 
            // cbxAddType
            // 
            this.cbxAddType.FormattingEnabled = true;
            this.cbxAddType.Location = new System.Drawing.Point(229, 72);
            this.cbxAddType.Name = "cbxAddType";
            this.cbxAddType.Size = new System.Drawing.Size(251, 21);
            this.cbxAddType.TabIndex = 10;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxAddType);
            this.Controls.Add(this.rtbxAddContent);
            this.Controls.Add(this.tbxAddPage);
            this.Controls.Add(this.tbxAddAuthor);
            this.Controls.Add(this.tbxAddName);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox tbxAddName;
        private System.Windows.Forms.TextBox tbxAddAuthor;
        private System.Windows.Forms.TextBox tbxAddPage;
        private System.Windows.Forms.RichTextBox rtbxAddContent;
        private System.Windows.Forms.ComboBox cbxAddType;
    }
}