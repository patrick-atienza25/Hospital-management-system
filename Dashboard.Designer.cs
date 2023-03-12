namespace Hospital_management_system
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.diagnosisPanel = new System.Windows.Forms.Panel();
            this.comboBoxWardType = new System.Windows.Forms.ComboBox();
            this.comboBoxWardRequired = new System.Windows.Forms.ComboBox();
            this.txtBoxMedications = new System.Windows.Forms.TextBox();
            this.txtBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.txtBoxSymptoms = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.labelWardRequired = new System.Windows.Forms.Label();
            this.labelMedications = new System.Windows.Forms.Label();
            this.labelDiagnosis = new System.Windows.Forms.Label();
            this.labelSymptoms = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPIDDiagnosisPanel = new System.Windows.Forms.TextBox();
            this.PID = new System.Windows.Forms.Label();
            this.informationLabelHeader = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.newPatientPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBloodType = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtEmergency = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnAddDiagnosis = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.indicator1 = new System.Windows.Forms.Label();
            this.indicator2 = new System.Windows.Forms.Label();
            this.indicator3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.fullHistoryPanel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.diagnosisPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.newPatientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.fullHistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // diagnosisPanel
            // 
            this.diagnosisPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.diagnosisPanel.Controls.Add(this.comboBoxWardType);
            this.diagnosisPanel.Controls.Add(this.comboBoxWardRequired);
            this.diagnosisPanel.Controls.Add(this.txtBoxMedications);
            this.diagnosisPanel.Controls.Add(this.txtBoxDiagnosis);
            this.diagnosisPanel.Controls.Add(this.txtBoxSymptoms);
            this.diagnosisPanel.Controls.Add(this.label16);
            this.diagnosisPanel.Controls.Add(this.labelWardRequired);
            this.diagnosisPanel.Controls.Add(this.labelMedications);
            this.diagnosisPanel.Controls.Add(this.labelDiagnosis);
            this.diagnosisPanel.Controls.Add(this.labelSymptoms);
            this.diagnosisPanel.Controls.Add(this.dataGridView1);
            this.diagnosisPanel.Controls.Add(this.txtPIDDiagnosisPanel);
            this.diagnosisPanel.Controls.Add(this.PID);
            this.diagnosisPanel.Controls.Add(this.informationLabelHeader);
            this.diagnosisPanel.Controls.Add(this.buttonSave);
            this.diagnosisPanel.Location = new System.Drawing.Point(282, 9);
            this.diagnosisPanel.Name = "diagnosisPanel";
            this.diagnosisPanel.Size = new System.Drawing.Size(590, 440);
            this.diagnosisPanel.TabIndex = 20;
            // 
            // comboBoxWardType
            // 
            this.comboBoxWardType.FormattingEnabled = true;
            this.comboBoxWardType.Items.AddRange(new object[] {
            "Pediatric",
            "Maternity",
            "Geriatric",
            "Psychiatric"});
            this.comboBoxWardType.Location = new System.Drawing.Point(419, 313);
            this.comboBoxWardType.Name = "comboBoxWardType";
            this.comboBoxWardType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWardType.TabIndex = 15;
            this.comboBoxWardType.Text = "Choose Type";
            this.comboBoxWardType.SelectedIndexChanged += new System.EventHandler(this.comboBoxWardType_SelectedIndexChanged);
            // 
            // comboBoxWardRequired
            // 
            this.comboBoxWardRequired.FormattingEnabled = true;
            this.comboBoxWardRequired.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxWardRequired.Location = new System.Drawing.Point(419, 261);
            this.comboBoxWardRequired.Name = "comboBoxWardRequired";
            this.comboBoxWardRequired.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWardRequired.TabIndex = 13;
            // 
            // txtBoxMedications
            // 
            this.txtBoxMedications.Location = new System.Drawing.Point(117, 365);
            this.txtBoxMedications.Name = "txtBoxMedications";
            this.txtBoxMedications.Size = new System.Drawing.Size(175, 20);
            this.txtBoxMedications.TabIndex = 12;
            // 
            // txtBoxDiagnosis
            // 
            this.txtBoxDiagnosis.Location = new System.Drawing.Point(117, 314);
            this.txtBoxDiagnosis.Name = "txtBoxDiagnosis";
            this.txtBoxDiagnosis.Size = new System.Drawing.Size(175, 20);
            this.txtBoxDiagnosis.TabIndex = 11;
            // 
            // txtBoxSymptoms
            // 
            this.txtBoxSymptoms.Location = new System.Drawing.Point(117, 261);
            this.txtBoxSymptoms.Name = "txtBoxSymptoms";
            this.txtBoxSymptoms.Size = new System.Drawing.Size(175, 20);
            this.txtBoxSymptoms.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(310, 315);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 19);
            this.label16.TabIndex = 8;
            this.label16.Text = "Ward Type";
            // 
            // labelWardRequired
            // 
            this.labelWardRequired.AutoSize = true;
            this.labelWardRequired.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWardRequired.Location = new System.Drawing.Point(310, 262);
            this.labelWardRequired.Name = "labelWardRequired";
            this.labelWardRequired.Size = new System.Drawing.Size(103, 19);
            this.labelWardRequired.TabIndex = 7;
            this.labelWardRequired.Text = "Ward required?";
            // 
            // labelMedications
            // 
            this.labelMedications.AutoSize = true;
            this.labelMedications.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedications.Location = new System.Drawing.Point(31, 365);
            this.labelMedications.Name = "labelMedications";
            this.labelMedications.Size = new System.Drawing.Size(84, 19);
            this.labelMedications.TabIndex = 6;
            this.labelMedications.Text = "Medications";
            // 
            // labelDiagnosis
            // 
            this.labelDiagnosis.AutoSize = true;
            this.labelDiagnosis.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiagnosis.Location = new System.Drawing.Point(31, 315);
            this.labelDiagnosis.Name = "labelDiagnosis";
            this.labelDiagnosis.Size = new System.Drawing.Size(68, 19);
            this.labelDiagnosis.TabIndex = 5;
            this.labelDiagnosis.Text = "Diagnosis";
            this.labelDiagnosis.Click += new System.EventHandler(this.label13_Click);
            // 
            // labelSymptoms
            // 
            this.labelSymptoms.AutoSize = true;
            this.labelSymptoms.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSymptoms.Location = new System.Drawing.Point(31, 262);
            this.labelSymptoms.Name = "labelSymptoms";
            this.labelSymptoms.Size = new System.Drawing.Size(75, 19);
            this.labelSymptoms.TabIndex = 4;
            this.labelSymptoms.Text = "Symptoms";
            this.labelSymptoms.Click += new System.EventHandler(this.label12_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 144);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtPIDDiagnosisPanel
            // 
            this.txtPIDDiagnosisPanel.Location = new System.Drawing.Point(273, 52);
            this.txtPIDDiagnosisPanel.Name = "txtPIDDiagnosisPanel";
            this.txtPIDDiagnosisPanel.Size = new System.Drawing.Size(159, 20);
            this.txtPIDDiagnosisPanel.TabIndex = 2;
            this.txtPIDDiagnosisPanel.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // PID
            // 
            this.PID.AutoSize = true;
            this.PID.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PID.Location = new System.Drawing.Point(137, 52);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(129, 21);
            this.PID.TabIndex = 1;
            this.PID.Text = "Enter Patient ID";
            this.PID.Click += new System.EventHandler(this.PID_Click);
            // 
            // informationLabelHeader
            // 
            this.informationLabelHeader.AutoSize = true;
            this.informationLabelHeader.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationLabelHeader.Location = new System.Drawing.Point(142, 13);
            this.informationLabelHeader.Name = "informationLabelHeader";
            this.informationLabelHeader.Size = new System.Drawing.Size(290, 31);
            this.informationLabelHeader.TabIndex = 0;
            this.informationLabelHeader.Text = "Patient Diagnosis Portal";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(419, 365);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // newPatientPanel
            // 
            this.newPatientPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newPatientPanel.Controls.Add(this.label10);
            this.newPatientPanel.Controls.Add(this.btnSave);
            this.newPatientPanel.Controls.Add(this.label11);
            this.newPatientPanel.Controls.Add(this.txtBloodType);
            this.newPatientPanel.Controls.Add(this.txtPhoneNumber);
            this.newPatientPanel.Controls.Add(this.label9);
            this.newPatientPanel.Controls.Add(this.label8);
            this.newPatientPanel.Controls.Add(this.label7);
            this.newPatientPanel.Controls.Add(this.label6);
            this.newPatientPanel.Controls.Add(this.label5);
            this.newPatientPanel.Controls.Add(this.label4);
            this.newPatientPanel.Controls.Add(this.label3);
            this.newPatientPanel.Controls.Add(this.txtGender);
            this.newPatientPanel.Controls.Add(this.txtAge);
            this.newPatientPanel.Controls.Add(this.txtEmergency);
            this.newPatientPanel.Controls.Add(this.txtAddress);
            this.newPatientPanel.Controls.Add(this.txtName);
            this.newPatientPanel.Controls.Add(this.txtPid);
            this.newPatientPanel.Location = new System.Drawing.Point(282, 9);
            this.newPatientPanel.Name = "newPatientPanel";
            this.newPatientPanel.Size = new System.Drawing.Size(590, 440);
            this.newPatientPanel.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(108, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(387, 31);
            this.label10.TabIndex = 20;
            this.label10.Text = "Enter New Patient Information";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Blood Type";
            // 
            // txtBloodType
            // 
            this.txtBloodType.Location = new System.Drawing.Point(170, 318);
            this.txtBloodType.Name = "txtBloodType";
            this.txtBloodType.Size = new System.Drawing.Size(396, 20);
            this.txtBloodType.TabIndex = 17;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(170, 224);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(396, 20);
            this.txtPhoneNumber.TabIndex = 16;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phone Number";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Emergency Contact";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Patient ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(170, 289);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(396, 20);
            this.txtGender.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(170, 258);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(396, 20);
            this.txtAge.TabIndex = 5;
            // 
            // txtEmergency
            // 
            this.txtEmergency.Location = new System.Drawing.Point(170, 195);
            this.txtEmergency.Name = "txtEmergency";
            this.txtEmergency.Size = new System.Drawing.Size(396, 20);
            this.txtEmergency.TabIndex = 3;
            this.txtEmergency.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(170, 153);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(396, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(170, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(396, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPid
            // 
            this.txtPid.Location = new System.Drawing.Point(171, 67);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(396, 20);
            this.txtPid.TabIndex = 0;
            this.txtPid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(886, 470);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Management Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(48, 87);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(205, 42);
            this.btnAddPatient.TabIndex = 1;
            this.btnAddPatient.Text = "Add New Patient Record";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddDiagnosis
            // 
            this.btnAddDiagnosis.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDiagnosis.Location = new System.Drawing.Point(48, 156);
            this.btnAddDiagnosis.Name = "btnAddDiagnosis";
            this.btnAddDiagnosis.Size = new System.Drawing.Size(205, 42);
            this.btnAddDiagnosis.TabIndex = 2;
            this.btnAddDiagnosis.Text = "Add Diagnosis of Patient";
            this.btnAddDiagnosis.UseVisualStyleBackColor = true;
            this.btnAddDiagnosis.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(48, 226);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(205, 42);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "Full History of Patient";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(108, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Menu";
            // 
            // indicator1
            // 
            this.indicator1.AutoSize = true;
            this.indicator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicator1.Location = new System.Drawing.Point(3, 96);
            this.indicator1.Name = "indicator1";
            this.indicator1.Size = new System.Drawing.Size(34, 24);
            this.indicator1.TabIndex = 10;
            this.indicator1.Text = ">>";
            this.indicator1.Click += new System.EventHandler(this.indicator1_Click);
            // 
            // indicator2
            // 
            this.indicator2.AutoSize = true;
            this.indicator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicator2.Location = new System.Drawing.Point(3, 164);
            this.indicator2.Name = "indicator2";
            this.indicator2.Size = new System.Drawing.Size(34, 24);
            this.indicator2.TabIndex = 11;
            this.indicator2.Text = ">>";
            this.indicator2.Click += new System.EventHandler(this.label4_Click);
            // 
            // indicator3
            // 
            this.indicator3.AutoSize = true;
            this.indicator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicator3.Location = new System.Drawing.Point(3, 235);
            this.indicator3.Name = "indicator3";
            this.indicator3.Size = new System.Drawing.Size(34, 24);
            this.indicator3.TabIndex = 12;
            this.indicator3.Text = ">>";
            this.indicator3.Click += new System.EventHandler(this.indicator3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // fullHistoryPanel
            // 
            this.fullHistoryPanel.Controls.Add(this.label12);
            this.fullHistoryPanel.Controls.Add(this.dataGridView2);
            this.fullHistoryPanel.Location = new System.Drawing.Point(282, 9);
            this.fullHistoryPanel.Name = "fullHistoryPanel";
            this.fullHistoryPanel.Size = new System.Drawing.Size(590, 440);
            this.fullHistoryPanel.TabIndex = 21;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(29, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(536, 379);
            this.dataGridView2.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(143, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(303, 42);
            this.label12.TabIndex = 1;
            this.label12.Text = "History of patient";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.fullHistoryPanel);
            this.Controls.Add(this.newPatientPanel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.indicator3);
            this.Controls.Add(this.indicator2);
            this.Controls.Add(this.indicator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnAddDiagnosis);
            this.Controls.Add(this.diagnosisPanel);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.diagnosisPanel.ResumeLayout(false);
            this.diagnosisPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.newPatientPanel.ResumeLayout(false);
            this.newPatientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.fullHistoryPanel.ResumeLayout(false);
            this.fullHistoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDiagnosis;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label indicator1;
        private System.Windows.Forms.Label indicator2;
        private System.Windows.Forms.Label indicator3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Panel newPatientPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtEmergency;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBloodType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label informationLabelHeader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPIDDiagnosisPanel;
        private System.Windows.Forms.Label PID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelWardRequired;
        private System.Windows.Forms.Label labelMedications;
        private System.Windows.Forms.Label labelDiagnosis;
        private System.Windows.Forms.Label labelSymptoms;
        private System.Windows.Forms.ComboBox comboBoxWardType;
        private System.Windows.Forms.ComboBox comboBoxWardRequired;
        private System.Windows.Forms.TextBox txtBoxMedications;
        private System.Windows.Forms.TextBox txtBoxDiagnosis;
        private System.Windows.Forms.TextBox txtBoxSymptoms;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel diagnosisPanel;
        private System.Windows.Forms.Panel fullHistoryPanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}