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
    public partial class StuffList : Form
    {
        public StuffList()
        {
            InitializeComponent();
        }

        private void StuffList_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
        private void loadGrid()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"select * from tbl_stuff", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"select * from tbl_stuff where stId={txtSearch.Text}", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnClc_Click(object sender, EventArgs e)
        {
            loadGrid();
        }
    }
}
