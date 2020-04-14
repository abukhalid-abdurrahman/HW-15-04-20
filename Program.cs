﻿using System;
using System.Data.SqlClient;

namespace Day_12
{
    class SqlHelper
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCmd;
        private SqlDataReader sqlDataReader;
        public SqlHelper(string connetctionString)
        {
            sqlConnection = new SqlConnection(connetctionString);
        }

        ///<summary>
        ///Выполняет соединение с SQL СУБД. Возвращает True - если соединение созданно успешно, иначе False
        ///</summary>
        public bool Connect()
        {
            sqlConnection.Open();
            if(sqlConnection.State == System.Data.ConnectionState.Open)
                return true;
            else
                return false;
        }

        ///<summary>
        ///Выполняет отсаединение от SQL СУБД
        ///</summary>
        public void Close()
        {
            sqlConnection.Close();
        }

        ///<summary>
        ///Выполняет добавление данных в SQL СУБД таблицу
        ///</summary>
        public void Insert(string content)
        {

        }

        ///<summary>
        ///Выполняет выбор всех данных с SQL СУБД таблицы
        ///</summary>
        public void SelectAll()
        {
            
        }

        ///<summary>
        ///Выполняет выбор определенного элемента по ID с SQL СУБД таблицы
        ///</summary>
        public void SelectByID(int ID)
        {

        }

        ///<summary>
        ///Выполняет обновление каждого элемента, кроме указонного через параметр ID
        ///</summary>
        public void Update(int ID)
        {

        }

        ///<summary>
        ///Выполняет удаление определенного элемента по ID
        ///</summary>
        public void Delete(int ID)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "\n1.\tДобавить\n"
                        + "2.\tУдалить\n"
                        + "3.\tВыбрать все\n"
                        + "4.\tВыбрать по ID\n"
                        + "5.\tОбновить\n"
                        + "0.\tВыход\n";
            Console.WriteLine("Здравствуйте! Выберите что вы хотите сделать: " + menu);
            string cmd = string.Empty;
            SqlHelper sqlHelp = new SqlHelper(@"");
            while(cmd != "0")
            {
                cmd = Console.ReadLine();
                if(cmd == "1")
                {
                    
                }
                else if(cmd == "2")
                {

                }
                else if(cmd == "3")
                {

                }
                else if(cmd == "4")
                {

                }
                else if(cmd == "5")
                {

                }
                Console.WriteLine(menu);
            }
        }
    }
}
