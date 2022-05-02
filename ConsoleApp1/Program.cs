using System;

namespace ConsoleApp1 //
{
    internal class Program
    {
        public static  string[] Key = { "Basic", "Pro", "Expert","Exit" };
        public static DocumentProgram? DocProgram { get; set; }
        static void Start()
        {
            int num = Select();
            switch (num)
            {
                case 0: 
                    DocProgram = new DocumentProgram(); 
                    break;
                case 1: DocProgram = new ProDocumentProgram(); break;
                case 2: DocProgram = new ExpertDocument(); break;
                case 3: return; 

                default: break;
            }
            DocProgram?.OpenDocument();
            DocProgram?.SaveDocument();
            DocProgram?.EditDocument();
            Start();
        }
        static int Select()
        {

            while (true)
            {
                Console.Write("Enter Key: ");
                var enterKey = Console.ReadLine()?.ToUpper();
                for (int i = 0; i < Key.Length; i++)if (Key[i].ToUpper() == enterKey) { return i; }
                Console.Clear();
            }       
        }
    
        static void Main(string[] args)
        {
            Start();
        }

    }
}