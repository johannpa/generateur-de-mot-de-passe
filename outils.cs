using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// generateur_mot_de_passe.outils.DemanderNombrePositifNonNul

namespace UtilesCS
{
    static class outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            //int numero = DemanderNombre(question);
            //if(numero > 0)
            //{
            //    return numero;
            //}
            //Console.WriteLine("ERREUR : Le nombre doit être supérieur à 0");
            //return DemanderNombrePositifNonNul(question);

            return DemanderNombreEntre(question, 1, int.MaxValue);
        }


        public static int DemanderNombreEntre(string question, int min, int max)
        {
            while (true)
            {
                int nombre = DemanderNombre(question);

                if (nombre >= min && nombre <= max)
                {
                    return nombre;
                }
                Console.WriteLine($"ERREUR : Le nombre doit être entre {min} et {max}");
            }
        }

        public static int DemanderNombre(string question)
        {

            int reponseInt = 0;

            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();

                try
                {
                    reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR : il faut un nombre !");
                }
            }
        }
    }
}
