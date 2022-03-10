using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {

            string numeroNPCstring;

            Console.WriteLine("Quantos NPCs existem: ");
            numeroNPCstring = Console.ReadLine();

            int numeroNPCint = int.Parse(numeroNPCstring);


            Perks[] matrix = new Perks[numeroNPCint];

            for(int i=0; i< matrix.Length ; i++)
            {

                string resposta1 , resposta2 , resposta3, resposta4;
                
                

                
                Console.WriteLine("O NPC é class Stealth? (s / n): ");
                Console.ReadLine(resposta1);

                int resposta1int = int.Parse(resposta1);

                if(resposta1int == "s")
                {
                    matrix[i] |= Perks.Stealth;

                }

                Console.WriteLine("O NPC é class Combat? (s / n): ");
                Console.ReadLine(resposta2);

                int resposta2int = int.Parse(resposta2);

                if(resposta2int == "s")
                {
                    matrix[i] |= Perks.Combat;

                }


                Console.WriteLine("O NPC é class Lockpick? (s / n): ");
                Console.ReadLine(resposta3);

                int resposta3int = int.Parse(resposta3);

                if(resposta3int == "s")
                {
                    matrix[i] |= Perks.LockPick;

                }


                Console.WriteLine("O NPC é class Luck?(s / n): ");
                Console.ReadLine(resposta4);

                int resposta4int = int.Parse(resposta4);

                if(resposta4int == "s")
                {
                    matrix[i] |= Perks.Luck;

                }

                
            

            
            }
              
            

              

        }
    }
}
