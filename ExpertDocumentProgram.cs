using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProgram
{
    class ExpertDocumentProgram : ProDocumentProgram
    {
        public sealed override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
}
