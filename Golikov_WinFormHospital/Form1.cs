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
        private int selectedRowIndex;
        
        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            InitializeComponent();
            
            //MyDb.Connection.Open();
            UpdateAllView();
        }

        private void UpdateAllView()
        {
            MyDb.UpdateViewData();
            
            DoctorsDataGridView.DataSource = MyDb.DSet.Tables[0];
            PatientsDataGridView.DataSource = MyDb.DSet.Tables[1];
            DoctorVisitsDataGridView.DataSource = MyDb.DSet.Tables[2];
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
        }

        private void DoctorsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            if (selectedRowIndex < 0) return; 
            DataGridViewRow row = DoctorsDataGridView.Rows[selectedRowIndex];

            FullnameTB.Text = row.Cells[1].Value.ToString();
            SpecialtyIdTB.Text = row.Cells[2].Value.ToString();
            VisitCostTB.Text = row.Cells[3].Value.ToString();
            SalaryPercentTB.Text = row.Cells[4].Value.ToString();
            HospitalIdTB.Text = row.Cells[5].Value.ToString();
        }
    }
}