using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProDocumentProgram: DocumentProgram
    {
        public sealed override void EditDocument() { Console.WriteLine("Document Edited"); }
        public override void SaveDocument() { Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet"); }
    }
}
