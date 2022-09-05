
namespace Hospital_Management
{
    partial class inPatient
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
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.txtDisease = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtPid = new System.Windows.Forms.TextBox();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoomNo = new System.Windows.Forms.ComboBox();
            this.tblroomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagementSystem_DBDataSet4 = new Hospital_Management.hospitalManagementSystem_DBDataSet4();
            this.hospitalManagementSystem_DBDataSet1 = new Hospital_Management.hospitalManagementSystem_DBDataSet1();
            this.tblroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_roomTableAdapter = new Hospital_Management.hospitalManagementSystem_DBDataSet1TableAdapters.tbl_roomTableAdapter();
            this.cmbLab = new System.Windows.Forms.ComboBox();
            this.tbllabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagementSystem_DBDataSet2 = new Hospital_Management.hospitalManagementSystem_DBDataSet2();
            this.cmbDr = new System.Windows.Forms.ComboBox();
            this.tbldoctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagementSystem_DBDataSet3 = new Hospital_Management.hospitalManagementSystem_DBDataSet3();
            this.tbl_labTableAdapter = new Hospital_Management.hospitalManagementSystem_DBDataSet2TableAdapters.tbl_labTableAdapter();
            this.tbl_doctorsTableAdapter = new Hospital_Management.hospitalManagementSystem_DBDataSet3TableAdapters.tbl_doctorsTableAdapter();
            this.tbl_roomTableAdapter1 = new Hospital_Management.hospitalManagementSystem_DBDataSet4TableAdapters.tbl_roomTableAdapter();
            this.lblPname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblroomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldoctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp2
            // 
            this.dtp2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp2.Location = new System.Drawing.Point(368, 268);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(185, 31);
            this.dtp2.TabIndex = 77;
            // 
            // dtp1
            // 
            this.dtp1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(368, 212);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(185, 31);
            this.dtp1.TabIndex = 76;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1000, 520);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 38);
            this.btnDelete.TabIndex = 75;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(879, 520);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 38);
            this.btnUpdate.TabIndex = 74;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(368, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 38);
            this.btnSave.TabIndex = 71;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1000, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 38);
            this.btnSearch.TabIndex = 73;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAdvance
            // 
            this.txtAdvance.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvance.Location = new System.Drawing.Point(368, 320);
            this.txtAdvance.Multiline = true;
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(212, 33);
            this.txtAdvance.TabIndex = 67;
            // 
            // txtDisease
            // 
            this.txtDisease.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisease.Location = new System.Drawing.Point(368, 480);
            this.txtDisease.Name = "txtDisease";
            this.txtDisease.Size = new System.Drawing.Size(303, 33);
            this.txtDisease.TabIndex = 70;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(754, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 33);
            this.txtSearch.TabIndex = 72;
            // 
            // txtPid
            // 
            this.txtPid.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPid.Location = new System.Drawing.Point(368, 105);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(303, 33);
            this.txtPid.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 26);
            this.label7.TabIndex = 63;
            this.label7.Text = "Disease";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 26);
            this.label6.TabIndex = 62;
            this.label6.Text = "Doctor Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 26);
            this.label5.TabIndex = 47;
            this.label5.Text = "Lab";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 61;
            this.label4.Text = "Advance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 26);
            this.label3.TabIndex = 60;
            this.label3.Text = "Room No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(306, 483);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 26);
            this.label13.TabIndex = 59;
            this.label13.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(306, 425);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 26);
            this.label12.TabIndex = 58;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(306, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 26);
            this.label11.TabIndex = 57;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(306, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 26);
            this.label10.TabIndex = 56;
            this.label10.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(306, 209);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 26);
            this.label18.TabIndex = 55;
            this.label18.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(306, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 26);
            this.label9.TabIndex = 54;
            this.label9.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(306, 272);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 26);
            this.label16.TabIndex = 53;
            this.label16.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 26);
            this.label8.TabIndex = 52;
            this.label8.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(120, 209);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 26);
            this.label17.TabIndex = 51;
            this.label17.Text = "Admit Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Candara Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(806, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "Search by Patient ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(120, 272);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 26);
            this.label15.TabIndex = 49;
            this.label15.Text = "Dis-charge Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Patient ID";
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.Color.Purple;
            this.lblNotification.Location = new System.Drawing.Point(350, 51);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(339, 36);
            this.lblNotification.TabIndex = 66;
            this.lblNotification.Text = "Data inserted Successfully";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(425, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 45);
            this.label1.TabIndex = 46;
            this.label1.Text = "In-Patients";
            // 
            // cmbRoomNo
            // 
            this.cmbRoomNo.DataSource = this.tblroomBindingSource1;
            this.cmbRoomNo.DisplayMember = "roomType";
            this.cmbRoomNo.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomNo.FormattingEnabled = true;
            this.cmbRoomNo.Location = new System.Drawing.Point(368, 160);
            this.cmbRoomNo.Name = "cmbRoomNo";
            this.cmbRoomNo.Size = new System.Drawing.Size(185, 34);
            this.cmbRoomNo.TabIndex = 78;
            this.cmbRoomNo.ValueMember = "roomNo";
            // 
            // tblroomBindingSource1
            // 
            this.tblroomBindingSource1.DataMember = "tbl_room";
            this.tblroomBindingSource1.DataSource = this.hospitalManagementSystem_DBDataSet4;
            // 
            // hospitalManagementSystem_DBDataSet4
            // 
            this.hospitalManagementSystem_DBDataSet4.DataSetName = "hospitalManagementSystem_DBDataSet4";
            this.hospitalManagementSystem_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalManagementSystem_DBDataSet1
            // 
            this.hospitalManagementSystem_DBDataSet1.DataSetName = "hospitalManagementSystem_DBDataSet1";
            this.hospitalManagementSystem_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblroomBindingSource
            // 
            this.tblroomBindingSource.DataMember = "tbl_room";
            this.tblroomBindingSource.DataSource = this.hospitalManagementSystem_DBDataSet1;
            // 
            // tbl_roomTableAdapter
            // 
            this.tbl_roomTableAdapter.ClearBeforeFill = true;
            // 
            // cmbLab
            // 
            this.cmbLab.DataSource = this.tbllabBindingSource;
            this.cmbLab.DisplayMember = "category";
            this.cmbLab.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Location = new System.Drawing.Point(368, 370);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.Size = new System.Drawing.Size(195, 34);
            this.cmbLab.TabIndex = 79;
            this.cmbLab.ValueMember = "labId";
            // 
            // tbllabBindingSource
            // 
            this.tbllabBindingSource.DataMember = "tbl_lab";
            this.tbllabBindingSource.DataSource = this.hospitalManagementSystem_DBDataSet2;
            // 
            // hospitalManagementSystem_DBDataSet2
            // 
            this.hospitalManagementSystem_DBDataSet2.DataSetName = "hospitalManagementSystem_DBDataSet2";
            this.hospitalManagementSystem_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbDr
            // 
            this.cmbDr.DataSource = this.tbldoctorsBindingSource;
            this.cmbDr.DisplayMember = "drName";
            this.cmbDr.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDr.FormattingEnabled = true;
            this.cmbDr.Location = new System.Drawing.Point(368, 421);
            this.cmbDr.Name = "cmbDr";
            this.cmbDr.Size = new System.Drawing.Size(195, 34);
            this.cmbDr.TabIndex = 79;
            this.cmbDr.ValueMember = "drId";
            // 
            // tbldoctorsBindingSource
            // 
            this.tbldoctorsBindingSource.DataMember = "tbl_doctors";
            this.tbldoctorsBindingSource.DataSource = this.hospitalManagementSystem_DBDataSet3;
            // 
            // hospitalManagementSystem_DBDataSet3
            // 
            this.hospitalManagementSystem_DBDataSet3.DataSetName = "hospitalManagementSystem_DBDataSet3";
            this.hospitalManagementSystem_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_labTableAdapter
            // 
            this.tbl_labTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_doctorsTableAdapter
            // 
            this.tbl_doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_roomTableAdapter1
            // 
            this.tbl_roomTableAdapter1.ClearBeforeFill = true;
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPname.Location = new System.Drawing.Point(738, 143);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(145, 26);
            this.lblPname.TabIndex = 48;
            this.lblPname.Text = "Patient Name :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(889, 143);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 26);
            this.lblName.TabIndex = 48;
            this.lblName.Text = "name";
            // 
            // inPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 578);
            this.Controls.Add(this.cmbDr);
            this.Controls.Add(this.cmbLab);
            this.Controls.Add(this.cmbRoomNo);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAdvance);
            this.Controls.Add(this.txtDisease);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtPid);
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.label1);
            this.Name = "inPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inPatient";
            this.Load += new System.EventHandler(this.inPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblroomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldoctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.TextBox txtDisease;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtPid;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoomNo;
        private hospitalManagementSystem_DBDataSet1 hospitalManagementSystem_DBDataSet1;
        private System.Windows.Forms.BindingSource tblroomBindingSource;
        private hospitalManagementSystem_DBDataSet1TableAdapters.tbl_roomTableAdapter tbl_roomTableAdapter;
        private System.Windows.Forms.ComboBox cmbLab;
        private System.Windows.Forms.ComboBox cmbDr;
        private hospitalManagementSystem_DBDataSet2 hospitalManagementSystem_DBDataSet2;
        private System.Windows.Forms.BindingSource tbllabBindingSource;
        private hospitalManagementSystem_DBDataSet2TableAdapters.tbl_labTableAdapter tbl_labTableAdapter;
        private hospitalManagementSystem_DBDataSet3 hospitalManagementSystem_DBDataSet3;
        private System.Windows.Forms.BindingSource tbldoctorsBindingSource;
        private hospitalManagementSystem_DBDataSet3TableAdapters.tbl_doctorsTableAdapter tbl_doctorsTableAdapter;
        private hospitalManagementSystem_DBDataSet4 hospitalManagementSystem_DBDataSet4;
        private System.Windows.Forms.BindingSource tblroomBindingSource1;
        private hospitalManagementSystem_DBDataSet4TableAdapters.tbl_roomTableAdapter tbl_roomTableAdapter1;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.Label lblName;
    }
}