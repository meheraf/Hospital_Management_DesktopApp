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

namespace Hospital_Management
{
    public partial class inPatient : Form
    {
        public inPatient()
        {
            InitializeComponent();
        }

        private void inPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalManagementSystem_DBDataSet4.tbl_room' table. You can move, or remove it, as needed.
            this.tbl_roomTableAdapter1.Fill(this.hospitalManagementSystem_DBDataSet4.tbl_room);
            // TODO: This line of code loads data into the 'hospitalManagementSystem_DBDataSet3.tbl_doctors' table. You can move, or remove it, as needed.
            this.tbl_doctorsTableAdapter.Fill(this.hospitalManagementSystem_DBDataSet3.tbl_doctors);
            // TODO: This line of code loads data into the 'hospitalManagementSystem_DBDataSet2.tbl_lab' table. You can move, or remove it, as needed.
            this.tbl_labTableAdapter.Fill(this.hospitalManagementSystem_DBDataSet2.tbl_lab);
            // TODO: This line of code loads data into the 'hospitalManagementSystem_DBDataSet1.tbl_room' table. You can move, or remove it, as needed.
            this.tbl_roomTableAdapter.Fill(this.hospitalManagementSystem_DBDataSet1.tbl_room);
            clcAll();
            lblNotification.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand($"INSERT INTO tbl_inPatient VALUES ({txtPid.Text},{cmbRoomNo.SelectedValue},'{Convert.ToDateTime(dtp1.Value)}','{Convert.ToDateTime(dtp2.Value)}',{txtAdvance.Text},{cmbLab.SelectedValue},{cmbDr.SelectedValue},'{txtDisease.Text}')", con);
            cmd.ExecuteNonQuery();

            lblNotification.Text = "Data inserted successfully";

            clcAll();
            
            con.Close();
        }
        private void clcAll()
        {
            txtPid.Text = "";
            txtAdvance.Text = "";
            txtDisease.Text = "";
            txtSearch.Text = "";
            cmbDr.SelectedIndex = -1;
            cmbLab.SelectedIndex = -1;
            cmbRoomNo.SelectedIndex = -1;
            lblPname.Text = "";
            lblName.Text = "";
            txtPid.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT p.PatientId,p.PatientName,inp.roomNo,inp.admitDate,inp.discharegeDate,inp.labId,inp.drId,inp.disease,inp.advance,inp.discharegeDate FROM tbl_inPatient inp JOIN tbl_Patient p ON inp.PatientId=p.PatientId where p.PatientId={txtSearch.Text}", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblPname.Text = "Patient Name :";
                lblName.Text= dt.Rows[0]["PatientName"].ToString();
                txtPid.Text = dt.Rows[0]["PatientId"].ToString();
                cmbRoomNo.SelectedValue = dt.Rows[0]["roomNo"];
                dtp1.Value = Convert.ToDateTime(dt.Rows[0]["admitDate"]);
                dtp2.Value = Convert.ToDateTime(dt.Rows[0]["discharegeDate"]);
                txtAdvance.Text = dt.Rows[0]["advance"].ToString();
                cmbLab.SelectedValue = dt.Rows[0]["labId"];
                cmbDr.SelectedValue = dt.Rows[0]["drId"];
                txtDisease.Text = dt.Rows[0]["disease"].ToString();
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
            SqlCommand cmd = new SqlCommand($"update tbl_inPatient set roomNo={cmbRoomNo.SelectedValue},admitDate='{Convert.ToDateTime(dtp1.Value)}',discharegeDate='{Convert.ToDateTime(dtp2.Value)}',advance={txtAdvance.Text},labId={cmbLab.SelectedValue},drId={cmbDr.SelectedValue},disease='{txtDisease.Text}' where PatientId={txtSearch.Text}", con);
            cmd.ExecuteNonQuery();
            lblNotification.Text = "Data Updated successfully";
            clcAll();

            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand($"delete from tbl_inPatient where PatientId={txtSearch.Text}", con);
            cmd.ExecuteNonQuery();
            lblNotification.Text = "Data Deleted successfully";
            clcAll();

            con.Close();
        }
    }
}
