using System;

namespace jeu_de_maths
{
    class Program
    {
        enum e_operator
        {
            ADDITION = 1 , 
            MULTIPLICATION = 2,
            SOUSTRACTION = 3
        }

        static bool PoserQuestion(int min, int max)
        {
            int reponseInt = 0;

            while (true)
            {
                Random rand = new Random();

                int a = rand.Next(min, max +1);
                int b = rand.Next(min, max + 1);

                // Sélection de l'opérateur
                e_operator o = (e_operator)rand.Next(1, 4);
                // o => 
                //      1 => Addition
                //      2 => Multiplication
                //      3 => ...

                int expectedResult;

                switch (o)
                {
                    case e_operator.ADDITION:
                        expectedResult = a + b;
                        Console.Write($"{a} + {b} = ");
                        break;
                    case e_operator.MULTIPLICATION:
                        expectedResult = a * b;
                        Console.Write($"{a} x {b} = ");
                        break;
                    case e_operator.SOUSTRACTION:
                        expectedResult = a - b;
                        Console.Write($"{a} - {b} = ");
                        break;
                    default:
                        Console.WriteLine("ERREUR: Opérateur inconnu");
                        return false;
                }

                string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);
                    if ( reponseInt == expectedResult)
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
            const int NB_QUESTIONS = 10;

            int score = 0;

            for (int i = 1; i <= NB_QUESTIONS; i++) 
            {
                Console.WriteLine("Question " + i + "/" + NB_QUESTIONS);
                bool bonneReponse = PoserQuestion(NOMBRE_MIN, NOMBRE_MAX);
                if (bonneReponse)
                {
                    Console.WriteLine("Bonne réponse !");
                    score++;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse !");                  
                }
                Console.WriteLine();
            }
            Console.WriteLine("Vous avez un score de " + score + "/" + NB_QUESTIONS);

            float moyenne = NB_QUESTIONS / 2f;

            if (score == NB_QUESTIONS) 
            {
                Console.WriteLine("Excellent");
            }
            else if (score == 0) 
            {
                Console.WriteLine("Révisez vos maths");
            }
            else if (score >= moyenne)
            {
                Console.WriteLine("Pas mal");
            }
            else 
            {
                Console.WriteLine("Peut mieux faire");
            }
        }
    }
}