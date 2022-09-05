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
    public partial class stuff : Form
    {
        public stuff()
        {
            InitializeComponent();
        }

        private void stuff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalManagementSystem_DBDataSet14.tbl_administrator' table. You can move, or remove it, as needed.
            this.tbl_administratorTableAdapter.Fill(this.hospitalManagementSystem_DBDataSet14.tbl_administrator);
            // TODO: This line of code loads data into the 'hospitalManagementSystem_DBDataSet13.tbl_department' table. You can move, or remove it, as needed.
            this.tbl_departmentTableAdapter.Fill(this.hospitalManagementSystem_DBDataSet13.tbl_department);
            // TODO: This line of code loads data into the 'hospitalManagementSystem_DBDataSet12.tbl_designation' table. You can move, or remove it, as needed.
            this.tbl_designationTableAdapter.Fill(this.hospitalManagementSystem_DBDataSet12.tbl_designation);
            clcAll();
            newID();
            lblNotification.Text = "";
        }

        private void clcAll()
        {
            txtName.Text = "";
            cmbGender.SelectedIndex = -1;
            cmbAdmin.SelectedIndex = -1;
            cmbDept.SelectedIndex = -1;
            cmbDesig.SelectedIndex = -1;
            txtEmail.Text = "";
            txtPhn.Text = "";
            txtNid.Text = "";
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
            SqlDataAdapter sda = new SqlDataAdapter($"select max(stId)+1 as ID from tbl_stuff", con);
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
            SqlCommand cmd = new SqlCommand($"INSERT INTO tbl_stuff VALUES ('{txtName.Text}','{txtEmail.Text}','{txtPhn.Text}',{txtNid.Text},{cmbGender.SelectedValue},'{Convert.ToDateTime(dtpDob.Value)}',{cmbDesig.SelectedValue},{cmbDept.SelectedValue},{cmbAdmin.SelectedValue},'{Convert.ToDateTime(dtpJoin.Value)}','{txtAddress.Text}',{txtPostal.Text},'{txtCity.Text}','{txtCountry.Text}')", con);
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
            SqlDataAdapter sda = new SqlDataAdapter($"select * from tbl_stuff where contactNo='{txtSearch.Text}'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblStuffId.Text = "Stuff ID";
                lblID.Text = dt.Rows[0]["stId"].ToString();
                txtName.Text = dt.Rows[0]["stName"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtPhn.Text = dt.Rows[0]["contactNo"].ToString();
                txtNid.Text = dt.Rows[0]["NID"].ToString();
                cmbGender.SelectedValue = dt.Rows[0]["genderId"];
                dtpDob.Value = Convert.ToDateTime(dt.Rows[0]["birthDate"]);
                cmbDesig.SelectedValue = dt.Rows[0]["desigId"];
                cmbDept.SelectedValue = dt.Rows[0]["depName"];
                cmbAdmin.SelectedValue = dt.Rows[0]["adminId"];
                dtpJoin.Value = Convert.ToDateTime(dt.Rows[0]["joinDate"]);

                txtAddress.Text = dt.Rows[0]["streetAddress"].ToString();
                txtPostal.Text = dt.Rows[0]["postalCode"].ToString();
                txtCity.Text = dt.Rows[0]["city"].ToString();
                txtCountry.Text = dt.Rows[0]["country"].ToString();
                lblNotification.Text = "Data found";
            }
            else
            {
                lblNotification.Text = "Data not found";
                lblStuffId.Text = "Stuff ID will be";

                newID();
                clcAll();
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand($"update tbl_stuff set stName='{txtName.Text}',email='{txtEmail.Text}',contactNo='{txtPhn.Text}',NID='{txtNid.Text}',genderID={cmbGender.SelectedValue},birthDate='{Convert.ToDateTime(dtpDob.Value)}',desigId={cmbDesig.SelectedValue},depName={cmbDept.SelectedValue},adminId={cmbAdmin.SelectedValue},joinDate='{Convert.ToDateTime(dtpJoin.Value)}',streetAddress='{txtAddress.Text}',postalCode={txtPostal.Text},city='{txtCity.Text}',country='{txtCountry.Text}' where stId={lblID.Text}", con);
            cmd.ExecuteNonQuery();

            lblNotification.Text = "Data Updated successfully";

            clcAll();
            newID();
            lblStuffId.Text = "Stuff ID will be";
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E4NOQQD;Initial Catalog=hospitalManagementSystem_DB;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand($"delete from tbl_stuff where stId={lblID.Text}", con);
            cmd.ExecuteNonQuery();

            lblNotification.Text = "Data Deleted successfully";

            clcAll();
            newID();
            lblStuffId.Text = "Stuff ID will be";
            con.Close();
        }
    }
}
