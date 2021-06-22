using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileSeller
{
    public partial class Accessories : Form
    {
        public Accessories()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mariia\Documents\MobileSellerDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            String query = "select * from AccessorieTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            AccessDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Accessories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (AidTb.Text == "" || AbrandTb.Text == "" || Amodel.Text == "" || Aprice.Text == "" || Astock.Text == "")
            {
                MessageBox.Show("Brak informacji");
            }
            else
            {
                try
                {
                    Con.Open();
                    String sql = "insert into AccessorieTbl values("+AidTb.Text+",'"+AbrandTb.Text+"','"+Amodel.Text+"',"+Aprice.Text+","+Astock.Text+")";
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Aksesorija dodana");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            AidTb.Text = "";
            AbrandTb.Text = "";
            Amodel.Text = "";
            Aprice.Text = "";
            Astock.Text = "";
        }

        private void AccessDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AidTb.Text = AccessDGV.SelectedRows[0].Cells[0].Value.ToString();
            AbrandTb.Text = AccessDGV.SelectedRows[0].Cells[1].Value.ToString();
            Amodel.Text = AccessDGV.SelectedRows[0].Cells[2].Value.ToString();
            Aprice.Text = AccessDGV.SelectedRows[0].Cells[3].Value.ToString();
            Astock.Text = AccessDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (AidTb.Text == "")
            {
                MessageBox.Show("Prosze wprowadzic jaki dodatek usuwamy");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from AccessorieTbl where AId=" +AidTb.Text+"";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Aksesoria jest usunieta.");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (AidTb.Text == "" || AbrandTb.Text == "" || Amodel.Text == "" || Aprice.Text == "" || Astock.Text == "")
            {
                MessageBox.Show("Brak informacji");
            }
            else
            {
                try
                {
                    Con.Open();
                    String sql = "update AccessorieTbl set ABrand='" + AbrandTb.Text + "', AModel='" + Amodel.Text + "',APrice=" + Aprice.Text + ",AStock=" + Astock.Text + " where AId=" + AidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updeate jest Poprawny");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
