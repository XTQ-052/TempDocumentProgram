using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter keyword : ");
            string keyword = Console.ReadLine();
            if (keyword.Equals(Keyword.Basic))
            {
                DocumentProgram docProgram1 = new DocumentProgram();
                docProgram1.OpenDocument();
                docProgram1.EditDocument();
                docProgram1.SaveDocument();
            }
            else if (keyword.Equals(Keyword.Pro))
            {
                DocumentProgram docProgram2 = new ProDocumentProgram();
                docProgram2.OpenDocument();
                docProgram2.EditDocument();
                docProgram2.SaveDocument();
            }
            else if (keyword.Equals(Keyword.Expert))
            {
                DocumentProgram docProgram3 = new ExpertDocumentProgram();
                docProgram3.OpenDocument();
                docProgram3.EditDocument();
                docProgram3.SaveDocument();
            }
            else
            {
                Console.WriteLine("Your keyword is wrong !");
            }

            Console.ReadKey();
        }
    }
}
