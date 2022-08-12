using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Singleton_Pattern
{
    public class Database
    {
        private static readonly object lockObject = new object();
        private static Database db;
        private List<string> data;
        private Database()
        {
            data = new List<string>() 
            { 
                "Ron",
                "Le",
                "Manh"
            };
        }

        public static Database getInstance()
        {
            // Lazy Initialization
            if (db == null)
            {
                db = new Database();
            }

            /*
            Thread safe
            lock (lockObject)
            {
                if (db == null)
                {
                    db = new Database();
                }
            }
            */

            /* 
            Double check
            if (db == null)
            {
                lock (lockObject)
                {
                    if (db == null)
                    {
                        db = new Database();
                    }
                }
            }
            */
            return db;
        }

        public List<string> query(Func<string, bool> expression)
        {
            return data.Where(expression).ToList();
        }
    }
}
