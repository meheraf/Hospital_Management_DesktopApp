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
    public partial class outPatient : Form
    {
        public outPatient()
        {
            InitializeComponent();
        }

        private void outPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalManagementSystem_DBDataSet6.tbl_doctors' table. You can move, or remove it, as needed.
            this.tbl_doctorsTableAdapter.Fill(this.hospitalManagementSystem_DBDataSet6.tbl_doctors);
            // TODO: This line of code loads data into the 'hospitalManagementSystem_DBDataSet5.tbl_lab' table. You can move, or remove it, as needed.
            this.tbl_labTableAdapter.Fill(this.hospitalManagementSystem_DBDataSet5.tbl_lab);
            clcAll();
            lblNotification.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand($"INSERT INTO tbl_outPatient VALUES ({txtPid.Text},'{Convert.ToDateTime(dateTimePicker1.Value)}',{cmbLab.SelectedValue},{cmbDr.SelectedValue})", con);
            cmd.ExecuteNonQuery();

            lblNotification.Text = "Data inserted successfully";

            clcAll();

            con.Close();
        }
        private void clcAll()
        {
            txtPid.Text = "";
            
            txtSearch.Text = "";
            cmbDr.SelectedIndex = -1;
            cmbLab.SelectedIndex = -1;
            
            lblPname.Text = "";
            lblName.Text = "";
            txtPid.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT p.PatientId,p.PatientName,op.[date],op.labId,op.drId FROM tbl_outPatient op JOIN tbl_Patient p ON op.PatientId=p.PatientId where p.PatientId={txtSearch.Text}", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblPname.Text = "Patient Name :";
                lblName.Text = dt.Rows[0]["PatientName"].ToString();
                txtPid.Text = dt.Rows[0]["PatientId"].ToString();
                
                dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["date"]);
                
                cmbLab.SelectedValue = dt.Rows[0]["labId"];
                cmbDr.SelectedValue = dt.Rows[0]["drId"];
                lblNotification.Text = "Data found";
            }
            else
            {
                lblNotification.Text = "Data not found";

                clcAll();
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand($"update tbl_outPatient set [date]='{Convert.ToDateTime(dateTimePicker1.Value)}', labId={cmbLab.SelectedValue},drId={cmbDr.SelectedValue} where PatientId={txtSearch.Text}", con);
            cmd.ExecuteNonQuery();
            lblNotification.Text = "Data Updated successfully";
            clcAll();

            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand($"delete from tbl_outPatient where PatientId={txtSearch.Text}", con);
            cmd.ExecuteNonQuery();
            lblNotification.Text = "Data Deleted successfully";
            clcAll();

            con.Close();
        }
    }
}
