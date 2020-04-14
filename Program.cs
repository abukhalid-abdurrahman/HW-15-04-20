using System;
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
        public void Insert(params string[] content)
        {
            string cmd = $"insert into Person(LastName, FirstName, MiddleName, BirthDay) values({content[0]}, {content[1]}, {content[2]}, {content[3]})";
            sqlCmd = new SqlCommand(cmd, sqlConnection);
            if(this.Connect())
            {
                sqlCmd.ExecuteNonQuery();
                this.Close();
                Console.WriteLine("Данные добавлены");
            }
            else
                Console.WriteLine("Ошибка соединения");
        }

        ///<summary>
        ///Выполняет выбор всех данных с SQL СУБД таблицы
        ///</summary>
        public void SelectAll()
        {
            string cmd = "select * from Person";
            sqlCmd = new SqlCommand(cmd, sqlConnection);
            if(this.Connect())
            {
                sqlCmd.ExecuteNonQuery();
                this.Close();
                Console.WriteLine("Все элементы были выбраны.");
            }
            else
                Console.WriteLine("Ошибка соединения");
        }

        ///<summary>
        ///Выполняет выбор определенного элемента по ID с SQL СУБД таблицы
        ///</summary>
        public void SelectByID(int ID)
        {
            string cmd = $"select (LastName, FirstName, MiddleName, BirthDay) from Person where ID = {ID}";
            sqlCmd = new SqlCommand(cmd, sqlConnection);
            if(this.Connect())
            {
                sqlCmd.ExecuteNonQuery();
                this.Close();
                Console.WriteLine($"Данные выбраны по {ID}");
            }
            else
                Console.WriteLine("Ошибка соединения");
        }

        ///<summary>
        ///Выполняет обновление каждого элемента, по указонному параметру ID
        ///</summary>
        public void Update(int ID, params string[] data)
        {
            string cmd = $"update Person set LastName = {data[0]}, FirstName = {data[1]}, MiddleName = {data[2]}, BirthDay = {data[3]} where ID = {ID}";
            sqlCmd = new SqlCommand(cmd, sqlConnection);
            if(this.Connect())
            {
                sqlCmd.ExecuteNonQuery();
                this.Close();
                Console.WriteLine("Данные обновленны");
            }
            else
                Console.WriteLine("Ошибка соединения");
        }

        ///<summary>
        ///Выполняет удаление определенного элемента по ID
        ///</summary>
        public void Delete(int ID)
        {
            string cmd = $"delete Person where ID = {ID}";
            sqlCmd = new SqlCommand(cmd, sqlConnection);
            if(this.Connect())
            {
                sqlCmd.ExecuteNonQuery();
                this.Close();
                Console.WriteLine("Данные удаленны");
            }
            else
                Console.WriteLine("Ошибка соединения");
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
            SqlHelper sqlHelp = new SqlHelper(@"Data Source=.;Initial Catalog=Sample;Integrated Security=true;");
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
