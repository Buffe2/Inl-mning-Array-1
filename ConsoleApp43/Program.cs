using System;
namespace Inl_uppgift_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            string[] m = new string[5];
            m[0] = "Jag gillar glass.";
            m[1] = "Jag springer snabbt.";
            m[2] = "Jag är dålig på matte.";
            m[3] = "Jag gillar bilar.";
            m[4] = "Jag är en människa.";     //Jag vet att man kan lägga in dem i början. Men det blir tydligare såhär.

            for(int i = 0; i < m.GetLength(0); i++)
            {
                Console.Write(m[i] + "\n");
            }
        }
        
    }
}