using Employee.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Employee
{
    class Program
    {
        /// belajar git (tortoise git)
        static void Main(string[] args)
        {
            GeneralRepositories general = new GeneralRepositories();
  
            try
            {             
                string answer;
                do
                {
                    Menu();
                    var option = int.Parse(Console.ReadLine());
                    Data data = new Data();
                    Models.EmployeeModels model = new Models.EmployeeModels();
                    switch (option)
                    {
                        case 1:
                            SqlDataReader userData =  data.GetAll();
                            while (userData.Read())
                            {
                                FormatTable.PrintRow(userData.GetValue(0).ToString()
                                                  , userData.GetValue(1).ToString()
                                                  , userData.GetValue(2).ToString()
                                                  , userData.GetValue(3).ToString());
                            }
                            break;
                        case 2:
                            Console.WriteLine("===== Insert Data =====");
                            Console.Write("Employee ID    : ");
                            model.id = Console.ReadLine();
                            Console.Write("Employee Name  : ");
                            model.nama = Console.ReadLine();
                            Console.Write("Gender         : ");
                            model.jenisKelamin = Console.ReadLine();
                            Console.Write("Address        : ");
                            model.alamat = Console.ReadLine();
                            data.GetInsert(model.id, model.nama, model.jenisKelamin, model.alamat);

                            break;
                        case 3:
                            Console.WriteLine("===== Update Data =====");
                            Console.Write("Employee ID   : ");
                            model.id = Console.ReadLine();
                            Console.Write("Address       : ");
                            model.alamat = Console.ReadLine();
                            data.GetUpdate(model.id, model.alamat);
                            break;
                        case 4:
                            Console.WriteLine("===== Delete Data =====");
                            Console.Write("ID Pegawai    :");
                            model.id = Console.ReadLine();
                            data.GetDelete(model.id);
                            break;
                        case 5:
                            option = 5;
                            break;
                        default:
                            Console.WriteLine("Not in options!!!");
                            break;
                    }

                    if (option != 5)
                    {
                        Console.WriteLine("Do you want to try again?");
                        answer = Console.ReadLine();
                    }
                    else
                    {
                        answer = "No";
                    }

                } while (answer == "Yes" || answer == "yes");
                Console.WriteLine("===== Thank You =====");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


        }
        ///test git
        static void Menu()
        {
            Console.WriteLine("===== Make Your Choice =====");
            Console.WriteLine("1. Read");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Exit");
            Console.Write("Input choice : ");
        }

    }
}
