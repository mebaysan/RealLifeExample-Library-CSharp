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
    public partial class UpdateBook : Form
    {
        int id = 0;
        public UpdateBook(int _id)
        {
            this.id = _id;
            InitializeComponent();
        }
        BookDal bookDal = new BookDal();
        private void UpdateBook_Load(object sender, EventArgs e)
        {
            BookTypeDal bookTypeDal = new BookTypeDal();
            List<Book> bookItem = bookDal.GetAll().Where(w => w.id == id).ToList(); // linq ile sorgu attık.
            tbxUpdateName.Text = bookItem[0].name; 
            tbxUpdateAuthor.Text = bookItem[0].author;
            tbxUpdatePage.Text = Convert.ToString(bookItem[0].page);
            cbxUpdateType.Text = bookItem[0].type.ToString();
            rtbxUpdateContent.Text = bookItem[0].content;
            cbxUpdateType.DataSource = bookTypeDal.GetAll();
            cbxUpdateType.DisplayMember = "name";
            cbxUpdateType.ValueMember = "id";
        }

        private void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
                BookDal bookDal = new BookDal();
                bookDal.Update(new Book { id = this.id, name = tbxUpdateName.Text, author = tbxUpdateAuthor.Text, content = rtbxUpdateContent.Text, page = Convert.ToInt32(tbxUpdatePage.Text), type = Convert.ToInt32(cbxUpdateType.SelectedValue) });
                MessageBox.Show(String.Format("{0} id'li kitap başarıyla güncellendi!", this.id.ToString()));
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            catch (Exception a)
            {
                MessageBox.Show("Kitap güncellenemedi! Hata Kodu :\n" + a.Message);

                throw;
            }
        }
    }
}
