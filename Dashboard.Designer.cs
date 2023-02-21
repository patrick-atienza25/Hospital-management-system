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
            this.label1 = new System.Windows.Forms.Label();
            this.patientButton = new System.Windows.Forms.Button();
            this.diagnosisButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(347, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // patientButton
            // 
            this.patientButton.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientButton.Location = new System.Drawing.Point(84, 141);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(205, 42);
            this.patientButton.TabIndex = 1;
            this.patientButton.Text = "Add New Patient Record";
            this.patientButton.UseVisualStyleBackColor = true;
            this.patientButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // diagnosisButton
            // 
            this.diagnosisButton.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosisButton.Location = new System.Drawing.Point(84, 191);
            this.diagnosisButton.Name = "diagnosisButton";
            this.diagnosisButton.Size = new System.Drawing.Size(205, 42);
            this.diagnosisButton.TabIndex = 2;
            this.diagnosisButton.Text = "Add Diagnosis Information";
            this.diagnosisButton.UseVisualStyleBackColor = true;
            this.diagnosisButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(84, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(84, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtMenu
            // 
            this.txtMenu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMenu.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenu.Location = new System.Drawing.Point(129, 99);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(100, 36);
            this.txtMenu.TabIndex = 5;
            this.txtMenu.Text = "Menu";
            this.txtMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.txtMenu);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.diagnosisButton);
            this.Controls.Add(this.patientButton);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button diagnosisButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtMenu;
    }
}