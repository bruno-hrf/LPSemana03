using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            string c;

            Console.WriteLine("Escreva uma frase: ");
            s = Console.ReadLine();

            Console.WriteLine("Escreva um character: ");
            c = Console.ReadLine();
            int charConvert = Convert.ToInt32(c[0]);

            for(int i = 0 ; i<s.Length ; i++ )
            {
                int fraseConvert = Convert.ToInt32(s[i]);
                
                if (fraseConvert != charConvert)
                {
                    Console.Write(s[i]);
                }
            }


        }
    }
}
