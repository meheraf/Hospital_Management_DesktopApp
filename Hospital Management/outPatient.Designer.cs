
namespace Hospital_Management
{
    partial class outPatient
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLab = new System.Windows.Forms.ComboBox();
            this.tbllabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagementSystem_DBDataSet5 = new Hospital_Management.hospitalManagementSystem_DBDataSet5();
            this.cmbDr = new System.Windows.Forms.ComboBox();
            this.tbldoctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagementSystem_DBDataSet6 = new Hospital_Management.hospitalManagementSystem_DBDataSet6();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPname = new System.Windows.Forms.Label();
            this.tbl_labTableAdapter = new Hospital_Management.hospitalManagementSystem_DBDataSet5TableAdapters.tbl_labTableAdapter();
            this.tbl_doctorsTableAdapter = new Hospital_Management.hospitalManagementSystem_DBDataSet6TableAdapters.tbl_doctorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbllabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldoctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(371, 201);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(303, 31);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1011, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(886, 492);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 38);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(467, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 38);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1011, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 38);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(765, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 33);
            this.txtSearch.TabIndex = 5;
            // 
            // txtPid
            // 
            this.txtPid.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPid.Location = new System.Drawing.Point(371, 139);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(303, 33);
            this.txtPid.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 26);
            this.label6.TabIndex = 62;
            this.label6.Text = "Doctor Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 26);
            this.label5.TabIndex = 47;
            this.label5.Text = "Lab";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(309, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 26);
            this.label12.TabIndex = 58;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(309, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 26);
            this.label11.TabIndex = 57;
            this.label11.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(309, 198);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 26);
            this.label18.TabIndex = 55;
            this.label18.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(309, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 26);
            this.label8.TabIndex = 52;
            this.label8.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(123, 198);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 26);
            this.label17.TabIndex = 51;
            this.label17.Text = "Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Candara Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(817, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "Search by Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 139);
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
            this.lblNotification.Location = new System.Drawing.Point(354, 68);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(336, 36);
            this.lblNotification.TabIndex = 66;
            this.lblNotification.Text = "Data inserted successfully";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(414, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 45);
            this.label1.TabIndex = 46;
            this.label1.Text = "Out-Patients";
            // 
            // cmbLab
            // 
            this.cmbLab.DataSource = this.tbllabBindingSource;
            this.cmbLab.DisplayMember = "category";
            this.cmbLab.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Location = new System.Drawing.Point(371, 262);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.Size = new System.Drawing.Size(189, 34);
            this.cmbLab.TabIndex = 67;
            this.cmbLab.ValueMember = "labId";
            // 
            // tbllabBindingSource
            // 
            this.tbllabBindingSource.DataMember = "tbl_lab";
            this.tbllabBindingSource.DataSource = this.hospitalManagementSystem_DBDataSet5;
            // 
            // hospitalManagementSystem_DBDataSet5
            // 
            this.hospitalManagementSystem_DBDataSet5.DataSetName = "hospitalManagementSystem_DBDataSet5";
            this.hospitalManagementSystem_DBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbDr
            // 
            this.cmbDr.DataSource = this.tbldoctorsBindingSource;
            this.cmbDr.DisplayMember = "drName";
            this.cmbDr.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDr.FormattingEnabled = true;
            this.cmbDr.Location = new System.Drawing.Point(371, 315);
            this.cmbDr.Name = "cmbDr";
            this.cmbDr.Size = new System.Drawing.Size(189, 34);
            this.cmbDr.TabIndex = 67;
            this.cmbDr.ValueMember = "drId";
            // 
            // tbldoctorsBindingSource
            // 
            this.tbldoctorsBindingSource.DataMember = "tbl_doctors";
            this.tbldoctorsBindingSource.DataSource = this.hospitalManagementSystem_DBDataSet6;
            // 
            // hospitalManagementSystem_DBDataSet6
            // 
            this.hospitalManagementSystem_DBDataSet6.DataSetName = "hospitalManagementSystem_DBDataSet6";
            this.hospitalManagementSystem_DBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(911, 198);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 26);
            this.lblName.TabIndex = 68;
            this.lblName.Text = "name";
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPname.Location = new System.Drawing.Point(760, 198);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(145, 26);
            this.lblPname.TabIndex = 69;
            this.lblPname.Text = "Patient Name :";
            // 
            // tbl_labTableAdapter
            // 
            this.tbl_labTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_doctorsTableAdapter
            // 
            this.tbl_doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // outPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 537);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPname);
            this.Controls.Add(this.cmbDr);
            this.Controls.Add(this.cmbLab);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtPid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.label1);
            this.Name = "outPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "outPatient";
            this.Load += new System.EventHandler(this.outPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbllabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldoctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementSystem_DBDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLab;
        private System.Windows.Forms.ComboBox cmbDr;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPname;
        private hospitalManagementSystem_DBDataSet5 hospitalManagementSystem_DBDataSet5;
        private System.Windows.Forms.BindingSource tbllabBindingSource;
        private hospitalManagementSystem_DBDataSet5TableAdapters.tbl_labTableAdapter tbl_labTableAdapter;
        private hospitalManagementSystem_DBDataSet6 hospitalManagementSystem_DBDataSet6;
        private System.Windows.Forms.BindingSource tbldoctorsBindingSource;
        private hospitalManagementSystem_DBDataSet6TableAdapters.tbl_doctorsTableAdapter tbl_doctorsTableAdapter;
    }
}