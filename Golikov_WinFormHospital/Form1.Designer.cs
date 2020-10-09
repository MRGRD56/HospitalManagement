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
	        this.components = new System.ComponentModel.Container();
	        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
	        this.DoctorVisitsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
	        this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
	        this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
	        this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
	        this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
	        this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
	        this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
	        this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
	        this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
	        this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
	        this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
	        this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
	        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
	        this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
	        this.DoctorVisitsDataGridView = new System.Windows.Forms.DataGridView();
	        this.MainTabControl.SuspendLayout();
	        this.DoctorsTabPage.SuspendLayout();
	        this.panel1.SuspendLayout();
	        ((System.ComponentModel.ISupportInitialize) (this.DoctorsDataGridView)).BeginInit();
	        this.PatientsTabPage.SuspendLayout();
	        ((System.ComponentModel.ISupportInitialize) (this.PatientsDataGridView)).BeginInit();
	        this.DoctorVisitsTabPage.SuspendLayout();
	        ((System.ComponentModel.ISupportInitialize) (this.DoctorVisitsBindingNavigator)).BeginInit();
	        this.DoctorVisitsBindingNavigator.SuspendLayout();
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
	        this.PatientsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsDataGridView_CellClick);
	        // 
	        // DoctorVisitsTabPage
	        // 
	        this.DoctorVisitsTabPage.Controls.Add(this.DoctorVisitsBindingNavigator);
	        this.DoctorVisitsTabPage.Controls.Add(this.DoctorVisitsDataGridView);
	        this.DoctorVisitsTabPage.Location = new System.Drawing.Point(4, 22);
	        this.DoctorVisitsTabPage.Name = "DoctorVisitsTabPage";
	        this.DoctorVisitsTabPage.Padding = new System.Windows.Forms.Padding(3);
	        this.DoctorVisitsTabPage.Size = new System.Drawing.Size(990, 567);
	        this.DoctorVisitsTabPage.TabIndex = 2;
	        this.DoctorVisitsTabPage.Text = "Приёмы";
	        this.DoctorVisitsTabPage.UseVisualStyleBackColor = true;
	        // 
	        // DoctorVisitsBindingNavigator
	        // 
	        this.DoctorVisitsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
	        this.DoctorVisitsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
	        this.DoctorVisitsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
	        this.DoctorVisitsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2, this.bindingNavigatorAddNewItem, this.bindingNavigatorDeleteItem, this.toolStripSeparator1, this.toolStripButton1});
	        this.DoctorVisitsBindingNavigator.Location = new System.Drawing.Point(3, 3);
	        this.DoctorVisitsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
	        this.DoctorVisitsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
	        this.DoctorVisitsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
	        this.DoctorVisitsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
	        this.DoctorVisitsBindingNavigator.Name = "DoctorVisitsBindingNavigator";
	        this.DoctorVisitsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
	        this.DoctorVisitsBindingNavigator.Size = new System.Drawing.Size(984, 25);
	        this.DoctorVisitsBindingNavigator.TabIndex = 1;
	        this.DoctorVisitsBindingNavigator.Text = "bindingNavigator1";
	        // 
	        // bindingNavigatorAddNewItem
	        // 
	        this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	        this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image) (resources.GetObject("bindingNavigatorAddNewItem.Image")));
	        this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
	        this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
	        this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
	        this.bindingNavigatorAddNewItem.Text = "Добавить";
	        // 
	        // bindingNavigatorCountItem
	        // 
	        this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
	        this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
	        this.bindingNavigatorCountItem.Text = "для {0}";
	        this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
	        // 
	        // bindingNavigatorDeleteItem
	        // 
	        this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	        this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image) (resources.GetObject("bindingNavigatorDeleteItem.Image")));
	        this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
	        this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
	        this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
	        this.bindingNavigatorDeleteItem.Text = "Удалить";
	        // 
	        // bindingNavigatorMoveFirstItem
	        // 
	        this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	        this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image) (resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
	        this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
	        this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
	        this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
	        this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
	        // 
	        // bindingNavigatorMovePreviousItem
	        // 
	        this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	        this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image) (resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
	        this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
	        this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
	        this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
	        this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
	        // 
	        // bindingNavigatorSeparator
	        // 
	        this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
	        this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
	        // 
	        // bindingNavigatorPositionItem
	        // 
	        this.bindingNavigatorPositionItem.AccessibleName = "Положение";
	        this.bindingNavigatorPositionItem.AutoSize = false;
	        this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
	        this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
	        this.bindingNavigatorPositionItem.Text = "0";
	        this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
	        // 
	        // bindingNavigatorSeparator1
	        // 
	        this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
	        this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
	        // 
	        // bindingNavigatorMoveNextItem
	        // 
	        this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	        this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image) (resources.GetObject("bindingNavigatorMoveNextItem.Image")));
	        this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
	        this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
	        this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
	        this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
	        // 
	        // bindingNavigatorMoveLastItem
	        // 
	        this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	        this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image) (resources.GetObject("bindingNavigatorMoveLastItem.Image")));
	        this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
	        this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
	        this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
	        this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
	        // 
	        // bindingNavigatorSeparator2
	        // 
	        this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
	        this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
	        // 
	        // toolStripSeparator1
	        // 
	        this.toolStripSeparator1.Name = "toolStripSeparator1";
	        this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
	        // 
	        // toolStripButton1
	        // 
	        this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
	        this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
	        this.toolStripButton1.Image = ((System.Drawing.Image) (resources.GetObject("toolStripButton1.Image")));
	        this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
	        this.toolStripButton1.Name = "toolStripButton1";
	        this.toolStripButton1.Size = new System.Drawing.Size(42, 22);
	        this.toolStripButton1.Text = "SAVE";
	        this.toolStripButton1.Click += new System.EventHandler(this.SaveToolStripButton_Click);
	        // 
	        // DoctorVisitsDataGridView
	        // 
	        this.DoctorVisitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	        this.DoctorVisitsDataGridView.Location = new System.Drawing.Point(3, 30);
	        this.DoctorVisitsDataGridView.Name = "DoctorVisitsDataGridView";
	        this.DoctorVisitsDataGridView.Size = new System.Drawing.Size(984, 534);
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
	        this.DoctorVisitsTabPage.PerformLayout();
	        ((System.ComponentModel.ISupportInitialize) (this.DoctorVisitsBindingNavigator)).EndInit();
	        this.DoctorVisitsBindingNavigator.ResumeLayout(false);
	        this.DoctorVisitsBindingNavigator.PerformLayout();
	        ((System.ComponentModel.ISupportInitialize) (this.DoctorVisitsDataGridView)).EndInit();
	        this.ResumeLayout(false);
        }

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripButton toolStripButton1;

        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator DoctorVisitsBindingNavigator;

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