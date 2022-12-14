
namespace Hospital_Management
{
    partial class doctors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.tblgenderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagementSystem_DBDataSet11 = new Hospital_Management.hospitalManagementSystem_DBDataSet11();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtPhn = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDrId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.hospitalManagementSystem_DBDataSet7 = new Hospital_Management.hospitalManagementSystem_DBDataSet7();
            this.tblgenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_genderTableAdapter = new Hospital_Management.hospitalManagementSystem_DBDataSet7TableAdapters.tbl_genderTableAdapter();
            this.cmbDesig = new System.Windows.Forms.ComboBox();
            this.tbldesignationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagementSystem_DBDataSet8 = new Hospital_Management.hospitalManagementSystem_DBDataSet8();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.tbldepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagementSystem_DBDataSet9 = new Hospital_Management.hospitalManagementSystem_DBDataSet9();
            this.cmbAdmin = new System.Windows.Forms.ComboBox();
            this.tbladministratorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagementSystem_DBDataSet10 = new Hospital_Management.hospitalManagementSystem_DBDataSet10();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbl_designationTableAdapter = new Hospital_Management.hospitalManagementSystem_DBDataSet8TableAdapters.tbl_designationTableAdapter();
            this.tbl_departmentTableAdapter = new Hospital_Management.hospitalManagementSystem_DBDataSet9TableAdapters.tbl_departmentTableAdapter();
            this.tbl_administratorTableAdapter = new Hospital_Management.hospitalManagementSystem_DBDataSet10TableAdapters.tbl_administratorTableAdapter();
            this.tbl_genderTableAdapter1 = new Hospital_Management.hospitalManagementSystem_DBDataSet11TableAdapters.tbl_genderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblgenderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblgenderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldesignationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladministratorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGender
            // 
            this.cmbGender.DataSource = this.tblgenderBindingSource1;
            this.cmbGender.DisplayMember = "gender";
            this.cmbGender.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(373, 157);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 34);
            this.cmbGender.TabIndex = 36;
            this.cmbGender.ValueMember = "genderId";
            // 
            // tblgenderBindingSource1
            // 
            this.tblgenderBindingSource1.DataMember = "tbl_gender";
            this.tblgenderBindingSource1.DataSource = this.hospitalManagementSystem_DBDataSet11;
            // 
            // hospitalManagementSystem_DBDataSet11
            // 
            this.hospitalManagementSystem_DBDataSet11.DataSetName = "hospitalManagementSystem_DBDataSet11";
            this.hospitalManagementSystem_DBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(758, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 33);
            this.txtSearch.TabIndex = 44;
            // 
            // txtPhn
            // 
            this.txtPhn.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhn.Location = new System.Drawing.Point(373, 219);
            this.txtPhn.Name = "txtPhn";
            this.txtPhn.Size = new System.Drawing.Size(303, 33);
            this.txtPhn.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(373, 282);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(303, 33);
            this.txtEmail.TabIndex = 38;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(373, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(303, 33);
            this.txtName.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 26);
            this.label7.TabIndex = 33;
            this.label7.Text = "Admin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 26);
            this.label6.TabIndex = 32;
            this.label6.Text = "Join Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 31;
            this.label5.Text = "Depertment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 26);
            this.label4.TabIndex = 35;
            this.label4.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gender";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(311, 521);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 26);
            this.label13.TabIndex = 20;
            this.label13.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(311, 462);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 26);
            this.label12.TabIndex = 14;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(311, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 26);
            this.label11.TabIndex = 15;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(311, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 26);
            this.label10.TabIndex = 16;
            this.label10.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(311, 219);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 26);
            this.label18.TabIndex = 17;
            this.label18.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(311, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(311, 282);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 26);
            this.label16.TabIndex = 19;
            this.label16.Text = ":";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(950, 98);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 33);
            this.label20.TabIndex = 21;
            this.label20.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(311, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 26);
            this.label8.TabIndex = 28;
            this.label8.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(125, 219);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 26);
            this.label17.TabIndex = 22;
            this.label17.Text = "Phone Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Candara Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(828, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Search by ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(125, 282);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 26);
            this.label15.TabIndex = 24;
            this.label15.Text = "Email";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Teal;
            this.lblID.Location = new System.Drawing.Point(973, 95);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 39);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDrId
            // 
            this.lblDrId.AutoSize = true;
            this.lblDrId.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrId.Location = new System.Drawing.Point(745, 98);
            this.lblDrId.Name = "lblDrId";
            this.lblDrId.Size = new System.Drawing.Size(213, 33);
            this.lblDrId.TabIndex = 26;
            this.lblDrId.Text = "Patient ID will be";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name";
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.Color.Purple;
            this.lblNotification.Location = new System.Drawing.Point(356, 48);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(336, 36);
            this.lblNotification.TabIndex = 29;
            this.lblNotification.Text = "Data inserted successfully";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(450, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 45);
            this.label1.TabIndex = 30;
            this.label1.Text = "Doctors";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1004, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 41);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(469, 573);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 41);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(878, 573);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 41);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1004, 573);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 41);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // hospitalManagementSystem_DBDataSet7
            // 
            this.hospitalManagementSystem_DBDataSet7.DataSetName = "hospitalManagementSystem_DBDataSet7";
            this.hospitalManagementSystem_DBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblgenderBindingSource
            // 
            this.tblgenderBindingSource.DataMember = "tbl_gender";
            this.tblgenderBindingSource.DataSource = this.hospitalManagementSystem_DBDataSet7;
            // 
            // tbl_genderTableAdapter
            // 
            this.tbl_genderTableAdapter.ClearBeforeFill = true;
            // 
            // cmbDesig
            // 
            this.cmbDesig.DataSource = this.tbldesignationBindingSource;
            this.cmbDesig.DisplayMember = "desigTitle";
            this.cmbDesig.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDesig.FormattingEnabled = true;
            this.cmbDesig.Location = new System.Drawing.Point(373, 348);
            this.cmbDesig.Name = "cmbDesig";
            this.cmbDesig.Size = new System.Drawing.Size(244, 34);
            this.cmbDesig.TabIndex = 36;
            this.cmbDesig.ValueMember = "desigId";
            // 
            // tbldesignationBindingSource
            // 
            this.tbldesignationBindingSource.DataMember = "tbl_designation";
            this.tbldesignationBindingSource.DataSource = this.hospitalManagementSystem_DBDataSet8;
            // 
            // hospitalManagementSystem_DBDataSet8
            // 
            this.hospitalManagementSystem_DBDataSet8.DataSetName = "hospitalManagementSystem_DBDataSet8";
            this.hospitalManagementSystem_DBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbDept
            // 
            this.cmbDept.DataSource = this.tbldepartmentBindingSource;
            this.cmbDept.DisplayMember = "depName";
            this.cmbDept.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(373, 406);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(244, 34);
            this.cmbDept.TabIndex = 36;
            this.cmbDept.ValueMember = "depId";
            // 
            // tbldepartmentBindingSource
            // 
            this.tbldepartmentBindingSource.DataMember = "tbl_department";
            this.tbldepartmentBindingSource.DataSource = this.hospitalManagementSystem_DBDataSet9;
            // 
            // hospitalManagementSystem_DBDataSet9
            // 
            this.hospitalManagementSystem_DBDataSet9.DataSetName = "hospitalManagementSystem_DBDataSet9";
            this.hospitalManagementSystem_DBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbAdmin
            // 
            this.cmbAdmin.DataSource = this.tbladministratorBindingSource;
            this.cmbAdmin.DisplayMember = "adminName";
            this.cmbAdmin.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdmin.FormattingEnabled = true;
            this.cmbAdmin.Location = new System.Drawing.Point(373, 518);
            this.cmbAdmin.Name = "cmbAdmin";
            this.cmbAdmin.Size = new System.Drawing.Size(244, 34);
            this.cmbAdmin.TabIndex = 36;
            this.cmbAdmin.ValueMember = "adminId";
            this.cmbAdmin.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // tbladministratorBindingSource
            // 
            this.tbladministratorBindingSource.DataMember = "tbl_administrator";
            this.tbladministratorBindingSource.DataSource = this.hospitalManagementSystem_DBDataSet10;
            // 
            // hospitalManagementSystem_DBDataSet10
            // 
            this.hospitalManagementSystem_DBDataSet10.DataSetName = "hospitalManagementSystem_DBDataSet10";
            this.hospitalManagementSystem_DBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(373, 457);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 33);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // tbl_designationTableAdapter
            // 
            this.tbl_designationTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_departmentTableAdapter
            // 
            this.tbl_departmentTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_administratorTableAdapter
            // 
            this.tbl_administratorTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_genderTableAdapter1
            // 
            this.tbl_genderTableAdapter1.ClearBeforeFill = true;
            // 
            // doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 621);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbAdmin);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.cmbDesig);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtPhn);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblDrId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.label1);
            this.Name = "doctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doctors";
            this.Load += new System.EventHandler(this.doctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblgenderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblgenderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldesignationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladministratorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtPhn;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDrId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private hospitalManagementSystem_DBDataSet7 hospitalManagementSystem_DBDataSet7;
        private System.Windows.Forms.BindingSource tblgenderBindingSource;
        private hospitalManagementSystem_DBDataSet7TableAdapters.tbl_genderTableAdapter tbl_genderTableAdapter;
        private System.Windows.Forms.ComboBox cmbDesig;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.ComboBox cmbAdmin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private hospitalManagementSystem_DBDataSet8 hospitalManagementSystem_DBDataSet8;
        private System.Windows.Forms.BindingSource tbldesignationBindingSource;
        private hospitalManagementSystem_DBDataSet8TableAdapters.tbl_designationTableAdapter tbl_designationTableAdapter;
        private hospitalManagementSystem_DBDataSet9 hospitalManagementSystem_DBDataSet9;
        private System.Windows.Forms.BindingSource tbldepartmentBindingSource;
        private hospitalManagementSystem_DBDataSet9TableAdapters.tbl_departmentTableAdapter tbl_departmentTableAdapter;
        private hospitalManagementSystem_DBDataSet10 hospitalManagementSystem_DBDataSet10;
        private System.Windows.Forms.BindingSource tbladministratorBindingSource;
        private hospitalManagementSystem_DBDataSet10TableAdapters.tbl_administratorTableAdapter tbl_administratorTableAdapter;
        private hospitalManagementSystem_DBDataSet11 hospitalManagementSystem_DBDataSet11;
        private System.Windows.Forms.BindingSource tblgenderBindingSource1;
        private hospitalManagementSystem_DBDataSet11TableAdapters.tbl_genderTableAdapter tbl_genderTableAdapter1;
    }
}