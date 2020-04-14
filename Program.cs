using System;

namespace Day_12
{
    class SqlHelper
    {
        private string _conStr = string.Empty;
        
        public SqlHelper(string connetctionString)
        {
            _conStr = connetctionString;
        }

        ///<summary>
        ///Выполняет соединение с SQL СУБД. Возвращает True - если соединение созданно успешно, иначе False
        ///</summary>
        public bool Connetc()
        {
            if(connection.State == ConnectionState.Open)
                return true;
            else
                return false;
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

        }
    }
}
