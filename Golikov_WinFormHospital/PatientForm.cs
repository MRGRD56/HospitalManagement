using System;
using System.Windows.Forms;
using Golikov_WinFormHospital.DataObjects;

namespace Golikov_WinFormHospital
{
    public partial class PatientForm : Form
    {
        private WorkMode workMode;
        
        public PatientForm(WorkMode wm)
        {
            InitializeComponent();
            
            workMode = wm;
        }
        
        private void OkButton_Click(object sender, EventArgs e)
        {
            var mainForm = Owner as Form1;
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
            // //MyDb.DSet.Tables[0].Rows.Add();
            // MyDb.AddDoctorToDataBase(
            //     FullnameTB.Text,
            //     SpecialtyIdTB.Text,
            //     VisitCostTB.Text,
            //     SalaryPercentTB.Text,
            //     HospitalIdTB.Text);
            // UpdateAllView();
        }

        private void EditPatient()
        {
            
        }
    }

    public enum WorkMode
    {
        Add,
        Edit
    }
}