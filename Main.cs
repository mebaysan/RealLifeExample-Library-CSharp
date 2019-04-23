using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BookTypeDal bookTypeDal = new BookTypeDal();
            dgwBookType.DataSource = bookTypeDal.GetAll();
            BookDal bookDal = new BookDal();
            dgwBooks.DataSource = bookDal.GetAll();
            dgwBooks.Columns[0].HeaderText = "Id"; // dgwBook datagridview'in columns listesinin 0. elemanının user tarafından görüntüsünü değiştirdik.
            dgwBooks.Columns[1].HeaderText = "Kitap Adı";
            dgwBooks.Columns[2].HeaderText = "Sayfa Sayısı";
            dgwBooks.Columns[3].HeaderText = "Yazar Adı";
            dgwBooks.Columns[4].HeaderText = "Konusu";
            dgwBooks.Columns[5].HeaderText = "Tür Id";
            dgwDeneme.Columns.Add("ID", "ID"); // ilk parametre kolon adı , ikinci parametre user'İn gördüğü kolon adı -> kolon ekledik
            dgwDeneme.Columns.Add("Kitap", "Kitap");
            dgwDeneme.Columns.Add("Yazar", "Yazar");

            //dgwDeneme.Columns[1].HeaderText = "ID";
            //dgwDeneme.Columns[2].HeaderText = "Kitap";
            //dgwDeneme.Columns[3].HeaderText = "Yazar";

        }

        private void BtnAddForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBook addBook = new AddBook();
            addBook.Show();
        }

        private void BtnAddType_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddType addType = new AddType();
            addType.Show();

        }

        private void SearchBook(string key) // burada datagrid'e sorgu atıyor büyük küçük harf duyarlılığı var
        {
            BookDal bookDal = new BookDal();
            dgwBooks.DataSource = bookDal.GetAll().Where(p => p.name.Contains(key)).ToList(); //
            // datagrid'in datakaynağı = bookDal nesnesinin GetAll fonksiyonu olsun fakat bu fonksiyodan gelen dataya linq ile sorgu atıyoruz.Where p için(p istediğimiz bir değişken burada datadaki eleman) p.name -> p iteminin name propu contains -> içersin key-> verilen değeri ve sonunda bunu bir listeye atadık
        }
        private void SearchBook2() // fakat burada direkt database'e sorgu atıyor ve küçük büyük harf duyarlılığı yok
        {
            BookDal bookDal = new BookDal();
            dgwBooks.DataSource = bookDal.GetByName(tbxSearchBook.Text);

        }
        private void TbxSearchBook_TextChanged(object sender, EventArgs e)
        {
            SearchBook2();

        }

        private void DgwBookType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BookDal bookDal = new BookDal();
            dgwBooks.DataSource = bookDal.GetByType(Convert.ToInt32(dgwBookType.CurrentRow.Cells[0].Value.ToString()));

        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                BookDal bookDal = new BookDal();
                bookDal.Delete(new Book { id = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value) });
                MessageBox.Show("Seçili Kitap Başarıyla Silindi!");
                dgwBooks.DataSource = bookDal.GetAll();
            }
            catch (Exception a)
            {
                MessageBox.Show("Seçili Kitap Silinemedi!" + a.Message);
                throw;
            }
        }

        private void BtnRefreshData_Click(object sender, EventArgs e)
        {
            BookDal bookDal = new BookDal();
            dgwBooks.DataSource = bookDal.GetAll();
        }

        private void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateBook updateBook = new UpdateBook(int.Parse(dgwBooks.CurrentRow.Cells[0].Value.ToString()));
            updateBook.Show();
        }

        private void DgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BookDal bookDal = new BookDal();
            List<Book> Books = bookDal.GetByProp(Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value)); 

            int i = 0;
            foreach (Book item in Books) // book türünde books listesinde döngü başlattık
            {
                dgwDeneme.Rows[i].Cells["ID"].Value = item.id; // 3. datagridin i'ninci(0) kolonuna ID dedik ve books listesindeki book item'in id'sini verdik
                dgwDeneme.Rows[i].Cells[1].Value = item.name; // sadece kolon adı ile değil kolon numarası ile de veri ekleyebiliriz.
                dgwDeneme.Rows[i].Cells["Yazar"].Value = item.author;

                i++;
            }

        }
    }
}
