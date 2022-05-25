using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Employee.Repositories
{
    class GeneralRepositories : Interface
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KTMHTIQ\MSSQLSERVER01;Initial Catalog=pegawai;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected string namaTable;

        public SqlDataReader GetAll()
        {
            conn.Open();
            Console.WriteLine("                     ========== Data Pegawai ==========");
            FormatTable.Print();
            FormatTable.PrintRow("Employee ID", "Employee Name", "Gender", "Address");
            FormatTable.Print();
            string displayQuery =$"SELECT * FROM {namaTable}";
            SqlCommand displayCommand = new SqlCommand(displayQuery, conn);
            return displayCommand.ExecuteReader();
        }

        
        public void GetInsert(string idPegawai, string namaPegawai, string jenisKelamin, string alamat)
        {
            conn.Open();
            string sqlQueryInsert = $"INSERT INTO pegawaii (id_pegawai, nama, jenis_kelamin, alamat) values ('{idPegawai}','{namaPegawai}','{jenisKelamin}','{alamat}')";
            SqlCommand command = new SqlCommand(sqlQueryInsert, conn); //pass SQL query created above and connection
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void GetUpdate(string idPegawai, string alamat)
        {
            conn.Open();
            string sqlQueryUpdate = $"UPDATE pegawaii SET alamat='{idPegawai}' WHERE id_pegawai='{alamat}'";
            SqlCommand commandUpdate = new SqlCommand(sqlQueryUpdate, conn); //pass SQL query created above and connection
            commandUpdate.ExecuteNonQuery();
            conn.Close();
        }

        public void GetDelete(string idPegawai)
        {
            conn.Open();
            string sqlQueryDelete = $"DELETE FROM pegawaii WHERE id_pegawai='{idPegawai}' ";
            SqlCommand commandDelete = new SqlCommand(sqlQueryDelete, conn); //pass SQL query created above and connection
            commandDelete.ExecuteNonQuery();
            conn.Close();
        }

        public void Menu()
        {
            throw new NotImplementedException();
        }

        public void GetInsert()
        {
            throw new NotImplementedException();
        }

        public void GetUpdate()
        {
            throw new NotImplementedException();
        }

        public void GetDelete()
        {
            throw new NotImplementedException();
        }
    }
}
