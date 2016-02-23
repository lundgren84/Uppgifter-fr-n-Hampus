using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
   public class Logger
    {
        public List<string> LoggPosts { get; private set; }

     public Logger()
        {
            this.LoggPosts = new List<string>();
        }

        public void Logg(string message)
        {
            DateTime koll = new DateTime();
            koll = DateTime.Now;
            LoggPosts.Add("Registered: "+koll+"  "+ message);     
        }
        public void ReadLog()
        {
            if (LoggPosts.Count == 0) { Console.WriteLine("LoggBok is empty");return; }
            foreach (var item in LoggPosts)
            {
                Console.WriteLine(item);
               
            }
        }
    }
}
