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
    public partial class Mobile : Form
    {
        public Mobile()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mariia\Documents\MobileSellerDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            Con.Open();
            String query = "select * from MobileSellerDB";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            MobileDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (MobidTb.Text == "" || brandtb.Text == "" || modeltb.Text == "" || pricetb.Text == "" || stocktb.Text == "" || cameratb.Text == "")
            {
                MessageBox.Show("Brak informacji");
            }
            else
            {
                try
                {
                    Con.Open();
                    String sql = "insert into MobileSellerDB values("+MobidTb.Text+",'"+brandtb.Text+"','"+modeltb.Text+"',"+pricetb.Text+","+stocktb.Text+","+ramcb.SelectedItem.ToString()+","+romcb.SelectedItem.ToString()+","+cameratb.Text+")";
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dodane, jest git");
                    Con.Close();
                    populate();
                } catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Mobile_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void MobileDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MobidTb.Text = MobileDGV.SelectedRows[0].Cells[0].Value.ToString();
            brandtb.Text = MobileDGV.SelectedRows[0].Cells[1].Value.ToString();
            modeltb.Text = MobileDGV.SelectedRows[0].Cells[2].Value.ToString();
            pricetb.Text = MobileDGV.SelectedRows[0].Cells[3].Value.ToString();
            stocktb.Text = MobileDGV.SelectedRows[0].Cells[4].Value.ToString();
            ramcb.Text = MobileDGV.SelectedRows[0].Cells[5].Value.ToString();
            romcb.Text = MobileDGV.SelectedRows[0].Cells[6].Value.ToString();
            cameratb.Text = MobileDGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            MobidTb.Text = "";
            brandtb.Text = "";
            modeltb.Text = "";
            pricetb.Text = "";
            stocktb.Text = "";
            ramcb.Text = "";
            romcb.Text = "";
            cameratb.Text = "";
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if(MobidTb.Text == "")
            {
                MessageBox.Show("Prosze wprowadzic jaki telefon usuwamy");
            }else
            {
                try
                {
                    Con.Open();
                    string query = "delete from MobileSellerDB where MobId="+ MobidTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Telefon usuniety.");
                    Con.Close();
                    populate();
                }catch(Exception Ex)
                {

                }
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (MobidTb.Text == "" || brandtb.Text == "" || modeltb.Text == "" || pricetb.Text == "" || stocktb.Text == "" || cameratb.Text == "")
            {
                MessageBox.Show("Brak informacji");
            }
            else
            {
                try
                {
                    Con.Open();
                    String sql = "update MobileSellerDB set Bbrand='"+brandtb.Text+"', MModel='"+modeltb.Text+"',MPrice="+pricetb.Text+",MStock="+stocktb.Text+",MRam="+ramcb.SelectedItem.ToString()+",MRom="+romcb.SelectedItem.ToString()+",MCam="+cameratb.Text+" where MobId="+MobidTb.Text+";";
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Z-Updejtowane Poprawnie");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MobidTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void brandtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pricetb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void stocktb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ramcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void romcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cameratb_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
