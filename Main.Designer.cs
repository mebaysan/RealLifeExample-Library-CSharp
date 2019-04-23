namespace Library
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgwBookType = new System.Windows.Forms.DataGridView();
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.lblType = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.tbxSearchBook = new System.Windows.Forms.TextBox();
            this.btnAddForm = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.dgwDeneme = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDeneme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBookType
            // 
            this.dgwBookType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBookType.Location = new System.Drawing.Point(12, 68);
            this.dgwBookType.Name = "dgwBookType";
            this.dgwBookType.Size = new System.Drawing.Size(273, 213);
            this.dgwBookType.TabIndex = 0;
            this.dgwBookType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwBookType_CellClick);
            // 
            // dgwBooks
            // 
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooks.Location = new System.Drawing.Point(386, 68);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.Size = new System.Drawing.Size(402, 213);
            this.dgwBooks.TabIndex = 0;
            this.dgwBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwBooks_CellClick);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(30, 37);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(63, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Kitap Türleri";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(394, 40);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(42, 13);
            this.lblBooks.TabIndex = 2;
            this.lblBooks.Text = "Kitaplar";
            // 
            // tbxSearchBook
            // 
            this.tbxSearchBook.Location = new System.Drawing.Point(498, 34);
            this.tbxSearchBook.Name = "tbxSearchBook";
            this.tbxSearchBook.Size = new System.Drawing.Size(240, 20);
            this.tbxSearchBook.TabIndex = 3;
            this.tbxSearchBook.TextChanged += new System.EventHandler(this.TbxSearchBook_TextChanged);
            // 
            // btnAddForm
            // 
            this.btnAddForm.Location = new System.Drawing.Point(498, 320);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(75, 23);
            this.btnAddForm.TabIndex = 4;
            this.btnAddForm.Text = "Kitap Ekle";
            this.btnAddForm.UseVisualStyleBackColor = true;
            this.btnAddForm.Click += new System.EventHandler(this.BtnAddForm_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(80, 320);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(111, 23);
            this.btnAddType.TabIndex = 5;
            this.btnAddType.Text = "Kitap Türü Ekle";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.BtnAddType_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(484, 359);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(122, 23);
            this.btnDeleteBook.TabIndex = 6;
            this.btnDeleteBook.Text = "Seçili Kitabı Sil";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.BtnDeleteBook_Click);
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.Location = new System.Drawing.Point(642, 5);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(96, 23);
            this.btnRefreshData.TabIndex = 7;
            this.btnRefreshData.Text = "Listeyi Yenile";
            this.btnRefreshData.UseVisualStyleBackColor = true;
            this.btnRefreshData.Click += new System.EventHandler(this.BtnRefreshData_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(484, 397);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(122, 23);
            this.btnUpdateBook.TabIndex = 8;
            this.btnUpdateBook.Text = "Seçili Kitabı Güncelle";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.BtnUpdateBook_Click);
            // 
            // dgwDeneme
            // 
            this.dgwDeneme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDeneme.Location = new System.Drawing.Point(814, 68);
            this.dgwDeneme.Name = "dgwDeneme";
            this.dgwDeneme.Size = new System.Drawing.Size(240, 213);
            this.dgwDeneme.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 450);
            this.Controls.Add(this.dgwDeneme);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnRefreshData);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.btnAddForm);
            this.Controls.Add(this.tbxSearchBook);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.dgwBooks);
            this.Controls.Add(this.dgwBookType);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDeneme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgwBookType;
        private System.Windows.Forms.DataGridView dgwBooks;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.TextBox tbxSearchBook;
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnRefreshData;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.DataGridView dgwDeneme;
    }
}

