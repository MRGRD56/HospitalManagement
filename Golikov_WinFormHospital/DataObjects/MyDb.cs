using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;

namespace Golikov_WinFormHospital.DataObjects
{
    public static class MyDb
    {
        static MyDb()
        {
            Connection.Open();
            ResetViewData();
        }
        
        // private static string SelectQuery { get; } =
        //     "SELECT Врач.Ид, Врач.ФИО, Специальность.НазваниеСпециальности, СтоимостьПриёма, " +
        //     "ПроцентОтчисленияНаЗарплату, Поликлиника.Название AS \"НазваниеПоликлиники\" " +
        //     "FROM Врач " +
        //     "INNER JOIN Специальность ON Врач.СпециальностьИд = Специальность.Ид " +
        //     "INNER JOIN Поликлиника ON Врач.ПоликлиникаИд = Поликлиника.Ид\n" +
        //     //TABLE 2 - Пациенты
        //     "SELECT * FROM Пациент\n" +
        //     //TABLE 3 - Приёмы
        //     "SELECT Приём.Ид, Пациент.ФИО AS \"ФИО пациента\", Врач.ФИО AS \"ФИО врача\", " +
        //     "Кабинет.Номер AS \"НомерКабинета\", Поликлиника.Название AS \"Поликлиника\" " +
        //     "FROM Приём " +
        //     "INNER JOIN Врач ON Приём.ВрачИд = Врач.Ид " +
        //     "INNER JOIN Пациент ON Приём.ПациентИд = Пациент.Ид " +
        //     "INNER JOIN Кабинет ON Приём.КабинетИд = Кабинет.Ид " +
        //     "INNER JOIN Поликлиника ON Кабинет.ПоликлиникаИд = Поликлиника.Ид";

        public static SqlConnection Connection { get; } = new SqlConnection(
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Голиков3пк2_Поликлиника;Integrated Security=True");
        
        // @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Голиков3пк2_Поликлиника;Integrated Security=True"
        // @"Data Source=OCMSSQL02;Initial Catalog=Голиков3пк2_Поликлиника;Integrated Security=True"

        public static void RunSql(string sql) => new SqlCommand(sql, Connection).ExecuteNonQuery();

        private static string SelectQuery { get; } =
            "SELECT * FROM Врач\n" +
            //TABLE 2 - Пациенты
            "SELECT * FROM Пациент\n" +
            //TABLE 3 - Приёмы
            "SELECT * FROM Приём ";
        
        public static DataSet DSet { get; set; } = new DataSet();
        public static SqlDataAdapter Adapter { get; set; }

        public static void UpdateViewData(string sql)
        {
            //Connection.Open();
            DSet = new DataSet();
            Adapter = new SqlDataAdapter(sql, Connection);
            Adapter.Fill(DSet);
        }
        
        public static void ResetViewData() => UpdateViewData(SelectQuery);

        public static void FilterDoctors(string fullName, string id)
        {
            if (string.IsNullOrWhiteSpace(id)) id = "%";
            
            UpdateViewData($"SELECT * FROM Врач WHERE ФИО LIKE '%{fullName}%' AND Ид LIKE '{id}'\n" +
                           "SELECT * FROM Пациент\n" +
                           "SELECT * FROM Приём ");
        }

        public static void AddDoctorToDataBase(string fullName, string specialtyId, string visitCost, string salaryPercent, string hospitalId)
        {
            new SqlCommand(
                    $"INSERT INTO Врач(ФИО, СпециальностьИд, СтоимостьПриёма, ПроцентОтчисленияНаЗарплату, ПоликлиникаИд) " +
                    $"VALUES ('{fullName}', '{specialtyId}', '{visitCost}', '{salaryPercent}', '{hospitalId}')", Connection)
                .ExecuteNonQuery();
        }

        public static void EditDoctorInDataBase(string id, string fullName, string specialtyId, string visitCost,
            string salaryPercent, string hospitalId)
        {
            RunSql(
                $"UPDATE Врач SET ФИО = '{fullName}', СпециальностьИд = '{specialtyId}', СтоимостьПриёма = '{visitCost}', " +
                $"ПроцентОтчисленияНаЗарплату = '{salaryPercent}', ПоликлиникаИд = '{hospitalId}' " +
                $"WHERE Ид = '{id}'");
        }

        public static void DeleteObjectFromDataBase(string objectName, string id, string idName = "Ид")
        {
            RunSql($"DELETE FROM {objectName} WHERE {idName} = {id}");
        }

        public static void AddPatientToDataBase(string fullName, string birthDate, string patientAddress)
        {
            RunSql(
                 "INSERT INTO Пациент (ФИО, ДатаРождения, АдресПациента) " +
                $"VALUES ('{fullName}', '{birthDate}', '{patientAddress}')");
        }

        public static void EditPatientInDataBase(string id, string fullName, string birthDate, string patientAddress)
        {
            RunSql(
                $"UPDATE Пациент SET ФИО = '{fullName}', ДатаРождения = '{birthDate}', АдресПациента = '{patientAddress}' " +
                $"WHERE Ид = '{id}'");
        }
    }
}