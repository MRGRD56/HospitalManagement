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
            this.DoctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.PatientsTabPage = new System.Windows.Forms.TabPage();
            this.PatientsDataGridView = new System.Windows.Forms.DataGridView();
            this.DoctorVisitsTabPage = new System.Windows.Forms.TabPage();
            this.DoctorVisitsDataGridView = new System.Windows.Forms.DataGridView();
            this.MainTabControl.SuspendLayout();
            this.DoctorsTabPage.SuspendLayout();
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
            this.MainTabControl.Size = new System.Drawing.Size(800, 450);
            this.MainTabControl.TabIndex = 0;
            // 
            // DoctorsTabPage
            // 
            this.DoctorsTabPage.Controls.Add(this.DoctorsDataGridView);
            this.DoctorsTabPage.Location = new System.Drawing.Point(4, 22);
            this.DoctorsTabPage.Name = "DoctorsTabPage";
            this.DoctorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DoctorsTabPage.Size = new System.Drawing.Size(792, 424);
            this.DoctorsTabPage.TabIndex = 0;
            this.DoctorsTabPage.Text = "Врачи";
            this.DoctorsTabPage.UseVisualStyleBackColor = true;
            // 
            // DoctorsDataGridView
            // 
            this.DoctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.DoctorsDataGridView.Name = "DoctorsDataGridView";
            this.DoctorsDataGridView.Size = new System.Drawing.Size(786, 418);
            this.DoctorsDataGridView.TabIndex = 0;
            // 
            // PatientsTabPage
            // 
            this.PatientsTabPage.Controls.Add(this.PatientsDataGridView);
            this.PatientsTabPage.Location = new System.Drawing.Point(4, 22);
            this.PatientsTabPage.Name = "PatientsTabPage";
            this.PatientsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PatientsTabPage.Size = new System.Drawing.Size(792, 424);
            this.PatientsTabPage.TabIndex = 1;
            this.PatientsTabPage.Text = "Пациенты";
            this.PatientsTabPage.UseVisualStyleBackColor = true;
            // 
            // PatientsDataGridView
            // 
            this.PatientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.PatientsDataGridView.Name = "PatientsDataGridView";
            this.PatientsDataGridView.Size = new System.Drawing.Size(786, 418);
            this.PatientsDataGridView.TabIndex = 0;
            // 
            // DoctorVisitsTabPage
            // 
            this.DoctorVisitsTabPage.Controls.Add(this.DoctorVisitsDataGridView);
            this.DoctorVisitsTabPage.Location = new System.Drawing.Point(4, 22);
            this.DoctorVisitsTabPage.Name = "DoctorVisitsTabPage";
            this.DoctorVisitsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DoctorVisitsTabPage.Size = new System.Drawing.Size(792, 424);
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
            this.DoctorVisitsDataGridView.Size = new System.Drawing.Size(786, 418);
            this.DoctorVisitsDataGridView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTabControl);
            this.Name = "Form1";
            this.Text = "Hospital";
            this.MainTabControl.ResumeLayout(false);
            this.DoctorsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.DoctorsDataGridView)).EndInit();
            this.PatientsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.PatientsDataGridView)).EndInit();
            this.DoctorVisitsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.DoctorVisitsDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView DoctorVisitsDataGridView;

        private System.Windows.Forms.TabPage DoctorVisitsTabPage;
        private System.Windows.Forms.TabControl MainTabControl;

        private System.Windows.Forms.DataGridView PatientsDataGridView;

        private System.Windows.Forms.TabPage PatientsTabPage;

        private System.Windows.Forms.DataGridView DoctorsDataGridView;

        private System.Windows.Forms.TabPage DoctorsTabPage;

        #endregion
    }
}