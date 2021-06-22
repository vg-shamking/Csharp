using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileSeller
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PassTb.Text = "";
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if(UidTb.Text == "" || PassTb.Text == ""){
                MessageBox.Show("Wprowadz imie i haslo");
            }
            else if(UidTb.Text == "Admin" && PassTb.Text == "Admin"){
                Home home = new Home();
                home.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Niepoprawne Login albo Haslo");
            }
        }
    }
}
