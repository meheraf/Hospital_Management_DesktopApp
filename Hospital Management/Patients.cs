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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Patients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalManagementSystem_DBDataSet.tbl_gender' table. You can move, or remove it, as needed.
            this.tbl_genderTableAdapter.Fill(this.hospitalManagementSystem_DBDataSet.tbl_gender);
            clcAll();
            newID();
            lblNotification.Text = "";
        }
        private void clcAll()
        {
            txtName.Text = "";
            cmbGender.SelectedIndex = -1;
            txtEmail.Text = "";
            txtPhn.Text = "";
            txtAddress.Text = "";
            txtPostal.Text = "";
            txtCity.Text = "Dhaka";
            txtCountry.Text = "Bangladesh";
            txtSearch.Text = "";
            txtName.Focus();
        }
        private void newID()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"select max(PatientId)+1 as ID from tbl_patient", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblID.Text = dt.Rows[0]["ID"].ToString();
            }
            con.Close();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand($"INSERT INTO tbl_patient VALUES ('{txtName.Text}', '{txtEmail.Text}', '{txtPhn.Text}', {cmbGender.SelectedValue}, '{txtAddress.Text}', {txtPostal.Text}, '{txtCity.Text}', '{txtCountry.Text}')", con);
            cmd.ExecuteNonQuery();
            
            lblNotification.Text = "Data inserted successfully";

            clcAll();
            newID();
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"select * from tbl_patient where contactNo='{txtSearch.Text}'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblPatientId.Text = "Patient ID";
                lblID.Text = dt.Rows[0]["PatientId"].ToString();
                txtName.Text = dt.Rows[0]["PatientName"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtPhn.Text = dt.Rows[0]["contactNo"].ToString();
                cmbGender.SelectedValue = dt.Rows[0]["genderId"];
                txtAddress.Text = dt.Rows[0]["streetAddress"].ToString();
                txtPostal.Text = dt.Rows[0]["postalCode"].ToString();
                txtCity.Text = dt.Rows[0]["city"].ToString();
                txtCountry.Text = dt.Rows[0]["country"].ToString();
                lblNotification.Text = "Data found";
            }
            else
            {
                lblNotification.Text = "Data not found";
                lblPatientId.Text = "Patient ID will be";
                
                newID();
                clcAll();
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand($"update tbl_patient set PatientName='{txtName.Text}',email='{txtEmail.Text}',contactNo='{txtPhn.Text}',genderId={cmbGender.SelectedValue},streetAddress='{txtAddress.Text}',postalCode={txtPostal.Text},city='{txtCity.Text}',country='{txtCountry.Text}' where PatientId={lblID.Text}", con);
            cmd.ExecuteNonQuery();

            lblNotification.Text = "Data Updated successfully";

            clcAll();
            newID();
            lblPatientId.Text = "Patient ID will be";
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand($"delete from tbl_patient where PatientId={lblID.Text}", con);
            cmd.ExecuteNonQuery();

            lblNotification.Text = "Data Deleted successfully";

            clcAll();
            newID();
            lblPatientId.Text = "Patient ID will be";
            con.Close();
        }
    }
}
