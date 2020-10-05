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

namespace Golikov_WinFormHospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string conString = @"Data Source=OCMSSQL02;Initial Catalog=Голиков3пк2_Поликлиника;Integrated Security=True";
                              //TABLE 1 - Врачи
            string sqlQuery = "SELECT Врач.Ид, Врач.ФИО, Специальность.НазваниеСпециальности, СтоимостьПриёма, " +
                              "ПроцентОтчисленияНаЗарплату, Поликлиника.Название AS \"НазваниеПоликлиники\" " +
                              "FROM Врач " +
                              "INNER JOIN Специальность ON Врач.СпециальностьИд = Специальность.Ид " +
                              "INNER JOIN Поликлиника ON Врач.ПоликлиникаИд = Поликлиника.Ид\n" +
                              //TABLE 2 - Пациенты
                              "SELECT * FROM Пациент\n" +
                              //TABLE 3 - Приёмы
                              "SELECT Приём.Ид, Пациент.ФИО AS \"ФИО пациента\", Врач.ФИО AS \"ФИО врача\", " +
                              "Кабинет.Номер AS \"НомерКабинета\", Поликлиника.Название AS \"Поликлиника\" " +
                              "FROM Приём " + 
                              "INNER JOIN Врач ON Приём.ВрачИд = Врач.Ид " +
                              "INNER JOIN Пациент ON Приём.ПациентИд = Пациент.Ид " +
                              "INNER JOIN Кабинет ON Приём.КабинетИд = Кабинет.Ид " +
                              "INNER JOIN Поликлиника ON Кабинет.ПоликлиникаИд = Поликлиника.Ид";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                adapter.Fill(ds);
                PatientsDataGridView.DataSource = ds.Tables[1];
                DoctorVisitsDataGridView.DataSource = ds.Tables[2];
                
                BindingSource bs1 = new BindingSource();
                bs1.DataSource = ds.Tables[0];

                DoctorsBindingNavigator.BindingSource = bs1;
                DoctorsDataGridView.DataSource = bs1;
            }
        }
    }
}