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
    public partial class Lab : Form
    {
        public Lab()
        {
            InitializeComponent();
        }

        private void Lab_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
        private void loadGrid()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"select * from tbl_lab", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
