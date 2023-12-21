using System;

namespace jeu_de_maths
{
    class Program
    {
        static bool PoserQuestion(int min, int max, int nombreQuestion, int numQuestion)
        {
            int reponseInt = 0;
            while (true)
            {
                Random rand = new Random();

                int a = rand.Next(min, max +1);
                int b = rand.Next(min, max + 1);

                int result = a + b;

                Console.WriteLine();
                Console.WriteLine("Question numéro " + numQuestion + "/" + nombreQuestion);
                Console.Write($"{a} + {b} = ");
                string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);
                    if ( reponseInt == result )
                    {
                        return true;                     
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    Console.WriteLine("ERREUR: Vous devez rentrer un nombre");
                }
            }
        } 

        static void Main(string[] args)
        {
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            const int NB_QUESTIONS = 3;

            for (int i = 1; i <= NB_QUESTIONS; i++) 
            {
                bool bonneReponse = PoserQuestion(NOMBRE_MIN, NOMBRE_MAX, NB_QUESTIONS, i);
                if (bonneReponse)
                {
                    Console.WriteLine("Bonne réponse !");
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse !");
                }
            }
        }
    }
}