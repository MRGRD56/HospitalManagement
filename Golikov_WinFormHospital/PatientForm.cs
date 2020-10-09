using System;
using System.Windows.Forms;
using Golikov_WinFormHospital.DataObjects;

namespace Golikov_WinFormHospital
{
    public partial class PatientForm : Form
    {
        private WorkMode workMode;
        private Form1 mainForm;
        
        public PatientForm(WorkMode wm, Form1 owner)
        {
            InitializeComponent();
            
            workMode = wm;
            mainForm = owner;
            
            if (wm == WorkMode.Edit)
            {
                if (mainForm.SelectedPatientRow == null) return;
                var selPat = mainForm.SelectedPatientRow.Cells;
                FullnameTB.Text = selPat[1].Value.ToString();
                BirthDateTB.Text = selPat[2].Value.ToString();
                PatientAddressTB.Text = selPat[3].Value.ToString();
            }
        }
        
        private void OkButton_Click(object sender, EventArgs e)
        {
            // mainForm = Owner as Form1;
            if (mainForm == null) return;

            switch (workMode)
            {
                case WorkMode.Add:
                    AddPatient();
                    break;
                case WorkMode.Edit:
                    EditPatient();
                    break;
                default:
                    MessageBox.Show("The work mode is not set.");
                    break;
            }
            
            this.Close();
        }
        
        private void AddPatient()
        {
            MyDb.AddPatientToDataBase(
                FullnameTB.Text,
                BirthDateTB.Text,
                PatientAddressTB.Text);
            mainForm.UpdateAllView();
        }

        private void EditPatient()
        {
            MyDb.EditPatientInDataBase(
                mainForm.SelectedPatientRow.Cells[0].Value.ToString(),
                FullnameTB.Text,
                BirthDateTB.Text,
                PatientAddressTB.Text
            );
            mainForm.UpdateAllView();
        }

        private void CloseButton_Click(object sender, EventArgs e) => Close();
    }

    public enum WorkMode
    {
        Add,
        Edit
    }
}