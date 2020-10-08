using System;

namespace Golikov_WinFormHospital
{
    partial class Form1
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
	        this.MainTabControl = new System.Windows.Forms.TabControl();
	        this.DoctorsTabPage = new System.Windows.Forms.TabPage();
	        this.panel1 = new System.Windows.Forms.Panel();
	        this.FullnameTB = new System.Windows.Forms.TextBox();
	        this.HospitalIdTB = new System.Windows.Forms.TextBox();
	        this.AddDoctorButton = new System.Windows.Forms.Button();
	        this.SalaryPercentTB = new System.Windows.Forms.TextBox();
	        this.EditDoctorButton = new System.Windows.Forms.Button();
	        this.VisitCostTB = new System.Windows.Forms.TextBox();
	        this.DeleteDoctorButton = new System.Windows.Forms.Button();
	        this.SpecialtyIdTB = new System.Windows.Forms.TextBox();
	        this.label1 = new System.Windows.Forms.Label();
	        this.label2 = new System.Windows.Forms.Label();
	        this.label4 = new System.Windows.Forms.Label();
	        this.label3 = new System.Windows.Forms.Label();
	        this.label5 = new System.Windows.Forms.Label();
	        this.DoctorsDataGridView = new System.Windows.Forms.DataGridView();
	        this.PatientsTabPage = new System.Windows.Forms.TabPage();
	        this.button1 = new System.Windows.Forms.Button();
	        this.button2 = new System.Windows.Forms.Button();
	        this.button3 = new System.Windows.Forms.Button();
	        this.PatientsDataGridView = new System.Windows.Forms.DataGridView();
	        this.DoctorVisitsTabPage = new System.Windows.Forms.TabPage();
	        this.DoctorVisitsDataGridView = new System.Windows.Forms.DataGridView();
	        this.MainTabControl.SuspendLayout();
	        this.DoctorsTabPage.SuspendLayout();
	        this.panel1.SuspendLayout();
	        ((System.ComponentModel.ISupportInitialize) (this.DoctorsDataGridView)).BeginInit();
	        this.PatientsTabPage.SuspendLayout();
	        ((System.ComponentModel.ISupportInitialize) (this.PatientsDataGridView)).BeginInit();
	        this.DoctorVisitsTabPage.SuspendLayout();
	        ((System.ComponentModel.ISupportInitialize) (this.DoctorVisitsDataGridView)).BeginInit();
	        this.SuspendLayout();
	        // 
	        // MainTabControl
	        // 
	        this.MainTabControl.Controls.Add(this.DoctorsTabPage);
	        this.MainTabControl.Controls.Add(this.PatientsTabPage);
	        this.MainTabControl.Controls.Add(this.DoctorVisitsTabPage);
	        this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
	        this.MainTabControl.Location = new System.Drawing.Point(0, 0);
	        this.MainTabControl.Name = "MainTabControl";
	        this.MainTabControl.SelectedIndex = 0;
	        this.MainTabControl.Size = new System.Drawing.Size(998, 593);
	        this.MainTabControl.TabIndex = 0;
	        // 
	        // DoctorsTabPage
	        // 
	        this.DoctorsTabPage.Controls.Add(this.panel1);
	        this.DoctorsTabPage.Controls.Add(this.DoctorsDataGridView);
	        this.DoctorsTabPage.Location = new System.Drawing.Point(4, 22);
	        this.DoctorsTabPage.Name = "DoctorsTabPage";
	        this.DoctorsTabPage.Padding = new System.Windows.Forms.Padding(3);
	        this.DoctorsTabPage.Size = new System.Drawing.Size(990, 567);
	        this.DoctorsTabPage.TabIndex = 0;
	        this.DoctorsTabPage.Text = "Врачи";
	        this.DoctorsTabPage.UseVisualStyleBackColor = true;
	        // 
	        // panel1
	        // 
	        this.panel1.Controls.Add(this.FullnameTB);
	        this.panel1.Controls.Add(this.HospitalIdTB);
	        this.panel1.Controls.Add(this.AddDoctorButton);
	        this.panel1.Controls.Add(this.SalaryPercentTB);
	        this.panel1.Controls.Add(this.EditDoctorButton);
	        this.panel1.Controls.Add(this.VisitCostTB);
	        this.panel1.Controls.Add(this.DeleteDoctorButton);
	        this.panel1.Controls.Add(this.SpecialtyIdTB);
	        this.panel1.Controls.Add(this.label1);
	        this.panel1.Controls.Add(this.label2);
	        this.panel1.Controls.Add(this.label4);
	        this.panel1.Controls.Add(this.label3);
	        this.panel1.Controls.Add(this.label5);
	        this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
	        this.panel1.Location = new System.Drawing.Point(3, 441);
	        this.panel1.Name = "panel1";
	        this.panel1.Size = new System.Drawing.Size(984, 123);
	        this.panel1.TabIndex = 12;
	        // 
	        // FullnameTB
	        // 
	        this.FullnameTB.Location = new System.Drawing.Point(162, 3);
	        this.FullnameTB.Name = "FullnameTB";
	        this.FullnameTB.Size = new System.Drawing.Size(248, 20);
	        this.FullnameTB.TabIndex = 9;
	        // 
	        // HospitalIdTB
	        // 
	        this.HospitalIdTB.Location = new System.Drawing.Point(162, 97);
	        this.HospitalIdTB.Name = "HospitalIdTB";
	        this.HospitalIdTB.Size = new System.Drawing.Size(248, 20);
	        this.HospitalIdTB.TabIndex = 11;
	        // 
	        // AddDoctorButton
	        // 
	        this.AddDoctorButton.Location = new System.Drawing.Point(906, 3);
	        this.AddDoctorButton.Name = "AddDoctorButton";
	        this.AddDoctorButton.Size = new System.Drawing.Size(75, 23);
	        this.AddDoctorButton.TabIndex = 1;
	        this.AddDoctorButton.Text = "Add";
	        this.AddDoctorButton.UseVisualStyleBackColor = true;
	        this.AddDoctorButton.Click += new System.EventHandler(this.AddDoctor_Click);
	        // 
	        // SalaryPercentTB
	        // 
	        this.SalaryPercentTB.Location = new System.Drawing.Point(162, 74);
	        this.SalaryPercentTB.Name = "SalaryPercentTB";
	        this.SalaryPercentTB.Size = new System.Drawing.Size(248, 20);
	        this.SalaryPercentTB.TabIndex = 11;
	        // 
	        // EditDoctorButton
	        // 
	        this.EditDoctorButton.Location = new System.Drawing.Point(906, 32);
	        this.EditDoctorButton.Name = "EditDoctorButton";
	        this.EditDoctorButton.Size = new System.Drawing.Size(75, 23);
	        this.EditDoctorButton.TabIndex = 2;
	        this.EditDoctorButton.Text = "Edit";
	        this.EditDoctorButton.UseVisualStyleBackColor = true;
	        this.EditDoctorButton.Click += new System.EventHandler(this.EditDoctorButton_Click);
	        // 
	        // VisitCostTB
	        // 
	        this.VisitCostTB.Location = new System.Drawing.Point(162, 50);
	        this.VisitCostTB.Name = "VisitCostTB";
	        this.VisitCostTB.Size = new System.Drawing.Size(248, 20);
	        this.VisitCostTB.TabIndex = 11;
	        // 
	        // DeleteDoctorButton
	        // 
	        this.DeleteDoctorButton.Location = new System.Drawing.Point(906, 61);
	        this.DeleteDoctorButton.Name = "DeleteDoctorButton";
	        this.DeleteDoctorButton.Size = new System.Drawing.Size(75, 23);
	        this.DeleteDoctorButton.TabIndex = 3;
	        this.DeleteDoctorButton.Text = "Delete";
	        this.DeleteDoctorButton.UseVisualStyleBackColor = true;
	        this.DeleteDoctorButton.Click += new System.EventHandler(this.DeleteDoctorButton_Click);
	        // 
	        // SpecialtyIdTB
	        // 
	        this.SpecialtyIdTB.Location = new System.Drawing.Point(162, 26);
	        this.SpecialtyIdTB.Name = "SpecialtyIdTB";
	        this.SpecialtyIdTB.Size = new System.Drawing.Size(248, 20);
	        this.SpecialtyIdTB.TabIndex = 10;
	        // 
	        // label1
	        // 
	        this.label1.Location = new System.Drawing.Point(2, 3);
	        this.label1.Name = "label1";
	        this.label1.Size = new System.Drawing.Size(154, 18);
	        this.label1.TabIndex = 4;
	        this.label1.Text = "ФИО: ";
	        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
	        // 
	        // label2
	        // 
	        this.label2.Location = new System.Drawing.Point(2, 26);
	        this.label2.Name = "label2";
	        this.label2.Size = new System.Drawing.Size(154, 18);
	        this.label2.TabIndex = 5;
	        this.label2.Text = "СпециальностьИд: ";
	        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
	        // 
	        // label4
	        // 
	        this.label4.Location = new System.Drawing.Point(2, 97);
	        this.label4.Name = "label4";
	        this.label4.Size = new System.Drawing.Size(154, 18);
	        this.label4.TabIndex = 8;
	        this.label4.Text = "ПоликлиникаИд: ";
	        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
	        // 
	        // label3
	        // 
	        this.label3.Location = new System.Drawing.Point(2, 50);
	        this.label3.Name = "label3";
	        this.label3.Size = new System.Drawing.Size(154, 18);
	        this.label3.TabIndex = 6;
	        this.label3.Text = "Стоимость приёма: ";
	        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
	        // 
	        // label5
	        // 
	        this.label5.Location = new System.Drawing.Point(2, 74);
	        this.label5.Name = "label5";
	        this.label5.Size = new System.Drawing.Size(154, 18);
	        this.label5.TabIndex = 7;
	        this.label5.Text = "Процент отчисления на з/п: ";
	        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
	        // 
	        // DoctorsDataGridView
	        // 
	        this.DoctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	        this.DoctorsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
	        this.DoctorsDataGridView.Location = new System.Drawing.Point(3, 3);
	        this.DoctorsDataGridView.Name = "DoctorsDataGridView";
	        this.DoctorsDataGridView.Size = new System.Drawing.Size(984, 437);
	        this.DoctorsDataGridView.TabIndex = 0;
	        this.DoctorsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorsDataGridView_CellClick);
	        // 
	        // PatientsTabPage
	        // 
	        this.PatientsTabPage.Controls.Add(this.button1);
	        this.PatientsTabPage.Controls.Add(this.button2);
	        this.PatientsTabPage.Controls.Add(this.button3);
	        this.PatientsTabPage.Controls.Add(this.PatientsDataGridView);
	        this.PatientsTabPage.Location = new System.Drawing.Point(4, 22);
	        this.PatientsTabPage.Name = "PatientsTabPage";
	        this.PatientsTabPage.Padding = new System.Windows.Forms.Padding(3);
	        this.PatientsTabPage.Size = new System.Drawing.Size(990, 567);
	        this.PatientsTabPage.TabIndex = 1;
	        this.PatientsTabPage.Text = "Пациенты";
	        this.PatientsTabPage.UseVisualStyleBackColor = true;
	        // 
	        // button1
	        // 
	        this.button1.Location = new System.Drawing.Point(5, 6);
	        this.button1.Name = "button1";
	        this.button1.Size = new System.Drawing.Size(51, 23);
	        this.button1.TabIndex = 4;
	        this.button1.Text = "Add";
	        this.button1.UseVisualStyleBackColor = true;
	        this.button1.Click += new System.EventHandler(this.AddPatientButton_Click);
	        // 
	        // button2
	        // 
	        this.button2.Location = new System.Drawing.Point(62, 6);
	        this.button2.Name = "button2";
	        this.button2.Size = new System.Drawing.Size(51, 23);
	        this.button2.TabIndex = 5;
	        this.button2.Text = "Edit";
	        this.button2.UseVisualStyleBackColor = true;
	        this.button2.Click += new System.EventHandler(this.EditPatientButton_Click);
	        // 
	        // button3
	        // 
	        this.button3.Location = new System.Drawing.Point(119, 6);
	        this.button3.Name = "button3";
	        this.button3.Size = new System.Drawing.Size(51, 23);
	        this.button3.TabIndex = 6;
	        this.button3.Text = "Delete";
	        this.button3.UseVisualStyleBackColor = true;
	        this.button3.Click += new System.EventHandler(this.DeletePatientButton_Click);
	        // 
	        // PatientsDataGridView
	        // 
	        this.PatientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	        this.PatientsDataGridView.Location = new System.Drawing.Point(3, 32);
	        this.PatientsDataGridView.Name = "PatientsDataGridView";
	        this.PatientsDataGridView.Size = new System.Drawing.Size(984, 532);
	        this.PatientsDataGridView.TabIndex = 0;
	        // 
	        // DoctorVisitsTabPage
	        // 
	        this.DoctorVisitsTabPage.Controls.Add(this.DoctorVisitsDataGridView);
	        this.DoctorVisitsTabPage.Location = new System.Drawing.Point(4, 22);
	        this.DoctorVisitsTabPage.Name = "DoctorVisitsTabPage";
	        this.DoctorVisitsTabPage.Padding = new System.Windows.Forms.Padding(3);
	        this.DoctorVisitsTabPage.Size = new System.Drawing.Size(990, 567);
	        this.DoctorVisitsTabPage.TabIndex = 2;
	        this.DoctorVisitsTabPage.Text = "Приёмы";
	        this.DoctorVisitsTabPage.UseVisualStyleBackColor = true;
	        // 
	        // DoctorVisitsDataGridView
	        // 
	        this.DoctorVisitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	        this.DoctorVisitsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
	        this.DoctorVisitsDataGridView.Location = new System.Drawing.Point(3, 3);
	        this.DoctorVisitsDataGridView.Name = "DoctorVisitsDataGridView";
	        this.DoctorVisitsDataGridView.Size = new System.Drawing.Size(984, 561);
	        this.DoctorVisitsDataGridView.TabIndex = 0;
	        // 
	        // Form1
	        // 
	        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	        this.ClientSize = new System.Drawing.Size(998, 593);
	        this.Controls.Add(this.MainTabControl);
	        this.Name = "Form1";
	        this.Text = "Hospital";
	        this.MainTabControl.ResumeLayout(false);
	        this.DoctorsTabPage.ResumeLayout(false);
	        this.panel1.ResumeLayout(false);
	        this.panel1.PerformLayout();
	        ((System.ComponentModel.ISupportInitialize) (this.DoctorsDataGridView)).EndInit();
	        this.PatientsTabPage.ResumeLayout(false);
	        ((System.ComponentModel.ISupportInitialize) (this.PatientsDataGridView)).EndInit();
	        this.DoctorVisitsTabPage.ResumeLayout(false);
	        ((System.ComponentModel.ISupportInitialize) (this.DoctorVisitsDataGridView)).EndInit();
	        this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox HospitalIdTB;
        private System.Windows.Forms.TextBox SalaryPercentTB;
        private System.Windows.Forms.TextBox SpecialtyIdTB;
        private System.Windows.Forms.TextBox VisitCostTB;

        private System.Windows.Forms.TextBox FullnameTB;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button AddDoctorButton;
        private System.Windows.Forms.Button DeleteDoctorButton;
        private System.Windows.Forms.Button EditDoctorButton;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridView DoctorVisitsDataGridView;

        private System.Windows.Forms.TabPage DoctorVisitsTabPage;
        private System.Windows.Forms.TabControl MainTabControl;

        public System.Windows.Forms.DataGridView PatientsDataGridView;

        private System.Windows.Forms.TabPage PatientsTabPage;

        private System.Windows.Forms.DataGridView DoctorsDataGridView;

        private System.Windows.Forms.TabPage DoctorsTabPage;

        #endregion
    }
}