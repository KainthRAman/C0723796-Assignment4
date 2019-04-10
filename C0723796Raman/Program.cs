using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0723796Raman
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
        }
        public void Run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader(@"U:\Users\723796/beowulf.text"))
            {
                int counter = 0;
                String ln;
                while ((ln = file.ReadLine()) !=null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                file.Close();
                Console.WriteLine($"File Has {counter} lines.");
            }

        }

    }
}

    
   

    