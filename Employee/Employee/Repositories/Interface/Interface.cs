using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Employee.Repositories
{
    interface Interface
    {
        public SqlDataReader GetAll();
        void Menu();
        void GetInsert();
        void GetUpdate();
        void GetDelete();

    }
}
