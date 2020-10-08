using System;
using System.Windows.Forms;
using Golikov_WinFormHospital.DataObjects;

namespace Golikov_WinFormHospital
{
    public partial class PatientForm : Form
    {
        private WorkMode workMode;
        private Form1 mainForm;
        
        public PatientForm(WorkMode wm)
        {
            InitializeComponent();
            
            workMode = wm;
            mainForm = Owner as Form1;
        }
        
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (mainForm == null) return;

            switch (workMode)
            {
                case WorkMode.Add:
                    AddPatient();
                    break;
                case WorkMode.Edit:
                    EditPatient();
                    break;
            }
            
            this.Close();
        }
        
        private void AddPatient()
        {
            // MyDb.AddDoctorToDataBase(
            //     FullnameTB.Text,
            //     SpecialtyIdTB.Text,
            //     VisitCostTB.Text,
            //     SalaryPercentTB.Text,
            //     HospitalIdTB.Text);
            // UpdateAllView();
            MyDb.AddPatientToDataBase(
                FullnameTB.Text,
                BirthDateTB.Text,
                PatientAddressTB.Text);
            mainForm.UpdateAllView();
        }

        private void EditPatient()
        {
            MyDb.EditPatientInDataBase(
                mainForm.SelectedPatientRow.Cells[0].ToString(),
                FullnameTB.Text,
                BirthDateTB.Text,
                PatientAddressTB.Text
            );
            mainForm.UpdateAllView(); //TODO LAST CHANGES
        }
    }

    public enum WorkMode
    {
        Add,
        Edit
    }
}