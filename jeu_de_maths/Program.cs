using System;

namespace jeu_de_maths
{
    class Program
    {
        static void PoserQuestion()
        {
            int reponseInt = 0;

            Console.WriteLine("5 + 2 = ");
            string reponse = Console.ReadLine();

            try
            {
                reponseInt = int.Parse(reponse);

            }
            catch 
            {
                Console.WriteLine("ERREUR: Vous devez rentrer un nombre");
            }

        } 


        static void Main(string[] args)
        {
            PoserQuestion();
        }
    }
}