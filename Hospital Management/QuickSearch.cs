using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class QuickSearch : Form
    {
        public QuickSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            if (rdId.Checked && cmbFrom.SelectedIndex == 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter($"select * from tbl_patient where PatientId={txtSearch.Text}", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    lblNotification.Text = "Data Found";
                }
                else
                {
                    lblNotification.Text = "Data not Found. Try again";
                }

            }
            else if (rdPhn.Checked && cmbFrom.SelectedIndex == 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter($"select * from tbl_patient where contactNo='{txtSearch.Text}'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    lblNotification.Text = "Data Found";
                }
                else
                {
                    lblNotification.Text = "Data not Found. Try again";
                }
            }
            else if (rdId.Checked && cmbFrom.SelectedIndex == 1)
            {
                SqlDataAdapter sda = new SqlDataAdapter($"select * from tbl_doctors where drId={txtSearch.Text}", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    lblNotification.Text = "Data Found";
                }
                else
                {
                    lblNotification.Text = "Data not Found. Try again";
                }
            }
            else if (rdPhn.Checked && cmbFrom.SelectedIndex == 1)
            {
                SqlDataAdapter sda = new SqlDataAdapter($"select * from tbl_doctors where contactNo='{txtSearch.Text}'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    lblNotification.Text = "Data Found";
                }
                else
                {
                    lblNotification.Text = "Data not Found. Try again";
                }
            }
            else if (rdId.Checked && cmbFrom.SelectedIndex == 2)
            {
                SqlDataAdapter sda = new SqlDataAdapter($"select * from tbl_stuff where stId={txtSearch.Text}", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    lblNotification.Text = "Data Found";
                }
                else
                {
                    lblNotification.Text = "Data not Found. Try again";
                }
            }
            else if (rdPhn.Checked && cmbFrom.SelectedIndex == 2)
            {
                SqlDataAdapter sda = new SqlDataAdapter($"select * from tbl_stuff where contactNo='{txtSearch.Text}'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    lblNotification.Text = "Data Found";
                }
                else
                {
                    lblNotification.Text = "Data not Found. Try again";
                }
            }
            else
            {
                lblNotification.Text = "Please Check the variables";
            }

            con.Close();
        }

        private void QuickSearch_Load(object sender, EventArgs e)
        {
            lblNotification.Text = "";
        }
    }
}
