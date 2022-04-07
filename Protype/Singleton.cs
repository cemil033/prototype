using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public  class Database
    {
        private static Database? instance;
        public static Database? getInstance()
        {
            if (Database.instance == null)
            {
                Database.instance = new Database();
            }
            return Database.instance;
        }
    }
    public class Singleton
    {
    }
}
