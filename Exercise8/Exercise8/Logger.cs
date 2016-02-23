using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
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
            LoggPosts.Add(message);
        }
        public void ReadLog()
        {
            foreach (var item in LoggPosts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
