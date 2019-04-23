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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            BookTypeDal bookTypeDal = new BookTypeDal();
            cbxAddType.DataSource = bookTypeDal.GetAll();
            cbxAddType.DisplayMember = "name";
            cbxAddType.ValueMember = "id";
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                BookDal bookDal = new BookDal();
                bookDal.Add(new Book { name = tbxAddName.Text, page = Convert.ToInt32(tbxAddPage.Text), type = Convert.ToInt32(cbxAddType.SelectedValue), author = tbxAddAuthor.Text, content = rtbxAddContent.Text });
                MessageBox.Show("Kitap Başarıyla Eklendi!");
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            catch(Exception a)
            {
                MessageBox.Show("Kitap Eklenirken Hata Oluştu Lütfen Tekrar Deneyiniz!" + a.Message);
            }
        }
    }
}
