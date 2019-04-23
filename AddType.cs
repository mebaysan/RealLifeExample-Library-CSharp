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
    public partial class AddType : Form
    {
        public AddType()
        {
            InitializeComponent();
        }

        private void BtnAddType_Click(object sender, EventArgs e)
        {
            try
            {
                BookTypeDal bookTypeDal = new BookTypeDal();
                bookTypeDal.Add(new BookType { name = tbxAddType.Text });
                MessageBox.Show("Kitap Türü Başarıyla Eklendi!");
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            catch
            {
                MessageBox.Show("Kitap Türü Eklenemedi!");
            }

        }
    }
}
