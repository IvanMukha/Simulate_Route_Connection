using System.Collections.Generic;
using CourseWork.Entities;

namespace CourseWork.DataStorage
{
    public class Database
    {
        private static Database database;

        public static Database getInstance()
        {
            return database ?? (database = new Database());
        }

        public Router[] routers { get; set; } = new Router[2];
    }
}