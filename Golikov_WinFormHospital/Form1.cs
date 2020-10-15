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
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");

            InitializeComponent();

            //MyDb.Connection.Open();


            UpdateAllView();
        }

        private void ShowAppError(string msg) =>
            MessageBox.Show(msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public void UpdateAllView()
        {
            try
            {
                MyDb.ResetViewData();

                DoctorsDataGridView.DataSource = MyDb.DSet.Tables[0];
                PatientsDataGridView.DataSource = MyDb.DSet.Tables[1];
                var doctorVisitsDataSourse = new BindingSource {DataSource = MyDb.DSet.Tables[2]};
                DoctorVisitsDataGridView.DataSource = doctorVisitsDataSourse;
                DoctorVisitsBindingNavigator.BindingSource = doctorVisitsDataSourse;
            }
            catch (Exception e)
            {
                ShowAppError(e.Message);
            }
        }

        public void FilterDoctorsAndUpdateView(string fullName, string id)
        {
            try
            {
                MyDb.FilterDoctors(fullName, id);

                DoctorsDataGridView.DataSource = MyDb.DSet.Tables[0];
                PatientsDataGridView.DataSource = MyDb.DSet.Tables[1];
                var doctorVisitsDataSourse = new BindingSource {DataSource = MyDb.DSet.Tables[2]};
                DoctorVisitsDataGridView.DataSource = doctorVisitsDataSourse;
                DoctorVisitsBindingNavigator.BindingSource = doctorVisitsDataSourse;
            }
            catch (Exception e)
            {
                ShowAppError(e.Message);
            }
        }

        private void DoctorsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception e1)
            {
                ShowAppError(e1.Message);
            }
        }

        private void AddDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                //MyDb.DSet.Tables[0].Rows.Add();
                MyDb.AddDoctorToDataBase(
                    FullnameTB.Text,
                    SpecialtyIdTB.Text,
                    VisitCostTB.Text,
                    SalaryPercentTB.Text.Replace(",", "."),
                    HospitalIdTB.Text);
                UpdateAllView();
            }
            catch (Exception e2)
            {
                ShowAppError(e2.Message);
            }
        }

        private void EditDoctorButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedDoctorRow == null) return;
                var doctorId = SelectedDoctorRow.Cells[0].Value.ToString();
                MyDb.EditDoctorInDataBase(
                    doctorId,
                    FullnameTB.Text,
                    SpecialtyIdTB.Text,
                    VisitCostTB.Text,
                    SalaryPercentTB.Text.Replace(",", "."),
                    HospitalIdTB.Text
                );
                UpdateAllView();
            }
            catch (Exception e3)
            {
                ShowAppError(e3.Message);
            }
        }

        private void DeleteDoctorButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedDoctorRow == null) return;
                var doctorId = SelectedDoctorRow.Cells[0].Value.ToString();
                if (MessageBox.Show($"Удалить строку с ID = '{doctorId}'?", "Удаление",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MyDb.DeleteObjectFromDataBase("Врач", doctorId);
                    UpdateAllView();
                }
            }
            catch (Exception e4)
            {
                ShowAppError(e4.Message);
            }
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                var pf = new PatientForm(WorkMode.Add, this);
                pf.Show();
            }
            catch (Exception e5)
            {
                ShowAppError(e5.Message);
            }
        }

        private void EditPatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                var pf = new PatientForm(WorkMode.Edit, this);
                pf.Show();
            }
            catch (Exception e6)
            {
                ShowAppError(e6.Message);
            }
        }

        private void DeletePatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedPatientRow == null) return;
                var patientId = SelectedPatientRow.Cells[0].Value.ToString();
                MyDb.DeleteObjectFromDataBase("Пациент", patientId);
                UpdateAllView();
            }
            catch (Exception e7)
            {
                ShowAppError(e7.Message);
            }
        }

        private void PatientsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedPatientRowIndex = e.RowIndex;
                if (SelectedPatientRowIndex < 0) return;
                SelectedPatientRow = PatientsDataGridView.Rows[SelectedPatientRowIndex];
            }
            catch (Exception e8)
            {
                ShowAppError(e8.Message);
            }
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //overwriting the table
                //MyDb.RunSql("SET IDENTITY_INSERT Приём ON");
                MyDb.RunSql("TRUNCATE TABLE Приём");

                for (int r = 0; r < DoctorVisitsDataGridView.Rows.Count; r++)
                {
                    var row = DoctorVisitsDataGridView.Rows[r];
                    if (row.Cells[0].Value == null) break;
                    var id = row.Cells[0].Value.ToString();
                    var patientId = row.Cells[1].Value.ToString();
                    var doctorId = row.Cells[2].Value.ToString();
                    var officeId = row.Cells[3].Value.ToString();
                    var visitTime = row.Cells[4].Value.ToString();

                    MyDb.RunSql("SET IDENTITY_INSERT Приём ON \n" +
                                "INSERT INTO Приём (Ид, ПациентИд, ВрачИд, КабинетИд, ВремяПриёма) " +
                                $"VALUES ('{id}', '{patientId}', '{doctorId}', '{officeId}', '{visitTime}') ");
                }

                MyDb.RunSql(@"SET IDENTITY_INSERT Приём OFF");
            }
            catch (Exception e9)
            {
                ShowAppError(e9.Message);
            }
        }

        private void DoctorSearchingTB_TextChanged(object sender, EventArgs e) =>
            FilterDoctors(DoctorSearchingTB.Text.Trim(), DoctorIdFilterTB.Text.Trim());

        private void FilterDoctors(string fullName, string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fullName) && string.IsNullOrWhiteSpace(id))
                    UpdateAllView();
                else
                    FilterDoctorsAndUpdateView(fullName, id);
            }
            catch (Exception e10)
            {
                ShowAppError(e10.Message);
            }
        }

        private void DoctorIdFilterTB_TextChanged(object sender, EventArgs e) =>
            FilterDoctors(DoctorSearchingTB.Text.Trim(), DoctorIdFilterTB.Text.Trim());
    }
}