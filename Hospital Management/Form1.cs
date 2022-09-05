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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patients p = new Patients();
            p.MdiParent = this;
            p.Show();
        }

        private void inPatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inPatient iP = new inPatient();
            iP.MdiParent = this;
            iP.Show();
        }
        private void outPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outPatient oP = new outPatient();
            oP.MdiParent = this;
            oP.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void patientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientList pL = new patientList();
            pL.MdiParent = this;
            pL.Show();
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void stuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void doctorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            doctors dr = new doctors();
            dr.MdiParent = this;
            dr.Show();
        }

        private void stuffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stuff stf = new stuff();
            stf.MdiParent = this;
            stf.Show();
        }

        private void doctorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorList drl = new DoctorList();
            drl.MdiParent = this;
            drl.Show();
        }

        private void stuffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuffList stfl = new StuffList();
            stfl.MdiParent = this;
            stfl.Show();
        }

        private void depertmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Depertments dpt = new Depertments();
            dpt.MdiParent = this;
            dpt.Show();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rooms rms = new Rooms();
            rms.MdiParent = this;
            rms.Show();
        }

        private void labsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab lb = new Lab();
            lb.MdiParent = this;
            lb.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            QuickSearch qs = new QuickSearch();
            qs.MdiParent = this;
            qs.Show();
        }
    }
}
