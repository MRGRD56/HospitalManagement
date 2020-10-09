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
using Golikov_WinFormHospital.DataObjects;

namespace Golikov_WinFormHospital
{
    public partial class Form1 : Form
    {
        public int SelectedDoctorRowIndex;
        public DataGridViewRow SelectedDoctorRow;

        public int SelectedPatientRowIndex;
        public DataGridViewRow SelectedPatientRow;
        
        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            InitializeComponent();
            
            //MyDb.Connection.Open();
            UpdateAllView();
        }

        public void UpdateAllView()
        {
            MyDb.UpdateViewData();
            
            DoctorsDataGridView.DataSource = MyDb.DSet.Tables[0];
            PatientsDataGridView.DataSource = MyDb.DSet.Tables[1];
            DoctorVisitsDataGridView.DataSource = MyDb.DSet.Tables[2];
        }
        
        private void DoctorsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedDoctorRowIndex = e.RowIndex;
            if (SelectedDoctorRowIndex < 0) return; 
            SelectedDoctorRow = DoctorsDataGridView.Rows[SelectedDoctorRowIndex];

            FullnameTB.Text = SelectedDoctorRow.Cells[1].Value.ToString();
            SpecialtyIdTB.Text = SelectedDoctorRow.Cells[2].Value.ToString();
            VisitCostTB.Text = SelectedDoctorRow.Cells[3].Value.ToString();
            SalaryPercentTB.Text = SelectedDoctorRow.Cells[4].Value.ToString();
            HospitalIdTB.Text = SelectedDoctorRow.Cells[5].Value.ToString();
        }
        
        private void AddDoctor_Click(object sender, EventArgs e)
        {
            //MyDb.DSet.Tables[0].Rows.Add();
            MyDb.AddDoctorToDataBase(
                FullnameTB.Text,
                SpecialtyIdTB.Text,
                VisitCostTB.Text,
                SalaryPercentTB.Text,
                HospitalIdTB.Text);
            UpdateAllView();
        }

        private void EditDoctorButton_Click(object sender, EventArgs e)
        {
            if (SelectedDoctorRow == null) return;
            var doctorId = SelectedDoctorRow.Cells[0].Value.ToString();
            MyDb.EditDoctorInDataBase(
                doctorId,
                FullnameTB.Text,
                SpecialtyIdTB.Text,
                VisitCostTB.Text,
                SalaryPercentTB.Text,
                HospitalIdTB.Text
                );
            UpdateAllView();
        }

        private void DeleteDoctorButton_Click(object sender, EventArgs e)
        {
            if (SelectedDoctorRow == null) return;
            var doctorId = SelectedDoctorRow.Cells[0].Value.ToString();
            MyDb.DeleteObjectFromDataBase("Врач", doctorId);
            UpdateAllView();
        }

		private void AddPatientButton_Click(object sender, EventArgs e)
		{
            var pf = new PatientForm(WorkMode.Add, this);
            pf.Show();
        }

		private void EditPatientButton_Click(object sender, EventArgs e)
		{
            var pf = new PatientForm(WorkMode.Edit, this);
            pf.Show();
		}

		private void DeletePatientButton_Click(object sender, EventArgs e)
		{
            if (SelectedPatientRow == null) return;
            var patientId = SelectedPatientRow.Cells[0].Value.ToString();
            MyDb.DeleteObjectFromDataBase("Пациент", patientId);
            UpdateAllView();
		}

        private void PatientsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedPatientRowIndex = e.RowIndex;
            if (SelectedPatientRowIndex < 0) return; 
            SelectedPatientRow = PatientsDataGridView.Rows[SelectedPatientRowIndex];
        }
    }
}