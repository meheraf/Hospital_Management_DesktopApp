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
    public partial class doctors : Form
    {
        public doctors()
        {
            InitializeComponent();
        }

        private void doctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalManagementSystem_DBDataSet11.tbl_gender' table. You can move, or remove it, as needed.
            this.tbl_genderTableAdapter1.Fill(this.hospitalManagementSystem_DBDataSet11.tbl_gender);
            // TODO: This line of code loads data into the 'hospitalManagementSystem_DBDataSet10.tbl_administrator' table. You can move, or remove it, as needed.
            this.tbl_administratorTableAdapter.Fill(this.hospitalManagementSystem_DBDataSet10.tbl_administrator);
            // TODO: This line of code loads data into the 'hospitalManagementSystem_DBDataSet9.tbl_department' table. You can move, or remove it, as needed.
            this.tbl_departmentTableAdapter.Fill(this.hospitalManagementSystem_DBDataSet9.tbl_department);
            // TODO: This line of code loads data into the 'hospitalManagementSystem_DBDataSet8.tbl_designation' table. You can move, or remove it, as needed.
            this.tbl_designationTableAdapter.Fill(this.hospitalManagementSystem_DBDataSet8.tbl_designation);
            // TODO: This line of code loads data into the 'hospitalManagementSystem_DBDataSet7.tbl_gender' table. You can move, or remove it, as needed.
            this.tbl_genderTableAdapter.Fill(this.hospitalManagementSystem_DBDataSet7.tbl_gender);
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
            cmbDesig.SelectedIndex = -1;
            cmbDept.SelectedIndex = -1;
            cmbAdmin.SelectedIndex = -1;
            
            txtSearch.Text = "";
            txtName.Focus();
        }
        private void newID()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"select max(drId)+1 as ID from tbl_doctors", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblID.Text = dt.Rows[0]["ID"].ToString();
            }
            con.Close();

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand($"INSERT INTO tbl_doctors VALUES ('{txtName.Text}','{txtEmail.Text}','{txtPhn.Text}',{cmbGender.SelectedValue},{cmbDesig.SelectedValue},{cmbDept.SelectedValue},'{Convert.ToDateTime(dateTimePicker1.Value)}',{cmbAdmin.SelectedValue})", con);
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
            SqlDataAdapter sda = new SqlDataAdapter($"select * from tbl_doctors where drId={txtSearch.Text}", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblDrId.Text = "Doctor ID";
                lblID.Text = dt.Rows[0]["drId"].ToString();
                txtName.Text = dt.Rows[0]["drName"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtPhn.Text = dt.Rows[0]["contactNo"].ToString();
                cmbGender.SelectedValue = dt.Rows[0]["genderID"];
                cmbDesig.SelectedValue = dt.Rows[0]["desigId"];
                cmbDept.SelectedValue = dt.Rows[0]["depId"];
                dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["joinDate"]);
                cmbAdmin.SelectedValue = dt.Rows[0]["adminId"];
                lblNotification.Text = "Data found";

            }
            else
            {
                lblNotification.Text = "Data not found";
                lblDrId.Text = "Doctor ID will be";

                newID();
                clcAll();
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand($"update tbl_doctors set drName='{txtName.Text}',email='{txtEmail.Text}',contactNo='{txtPhn.Text}',genderId={cmbGender.SelectedValue},desigId={cmbGender.SelectedValue},depId={cmbGender.SelectedValue},joinDate='{Convert.ToDateTime(dateTimePicker1.Value)}',adminId={cmbGender.SelectedValue} where drId={txtSearch.Text}", con);
            cmd.ExecuteNonQuery();

            lblNotification.Text = "Data Updated successfully";

            clcAll();
            newID();
            lblDrId.Text = "Doctor ID will be";
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand($"delete from tbl_doctors where drId={txtSearch.Text}", con);
            cmd.ExecuteNonQuery();

            lblNotification.Text = "Data Deleted successfully";

            clcAll();
            newID();
            lblDrId.Text = "Patient ID will be";
            con.Close();
        }
    }
}
