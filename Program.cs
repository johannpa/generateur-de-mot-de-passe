using System;
using UtilesCS;

namespace generateur_mot_de_passe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caracteresSpeciaux = "#&+-/*€%$,;!";
            string alphabet = "";

            int choix = 0;

            while(choix <= 0 || choix > 4)
            {
                choix = outils.DemanderNombrePositifNonNul("Vous voulez un mot de passe avec : \n" +
                "1 - Uniquement des caractères en miniscule \n" +
                "2 - Des caractères minuscule et majuscules \n" +
                "3 - Des caractères et des chiffres \n" +
                "4 - Caractères, chiffres et caractères spéciaux \n" +
                "Faite votre choix : ");

                switch (choix)
                {
                    case 1:
                        alphabet = minuscules;
                        break;
                    case 2:
                        alphabet = minuscules + majuscules;
                        break;
                    case 3:
                        alphabet = minuscules + majuscules + chiffres;
                        break;
                    case 4:
                        alphabet = minuscules + majuscules + chiffres + caracteresSpeciaux;
                        break;
                    default:
                        Console.WriteLine("Vous devez choisir entre 1 et 4");
                        break;
                }

            }
            
            int longueurMotDPasse = outils.DemanderNombrePositifNonNul("Longueur du mot de passe : ");

            string motDePasse = "";
            int longueurAlphabet = alphabet.Length;
            Random rand = new Random();

            for(int i = 0; i < longueurMotDPasse; i++)
            {
                int index = rand.Next(0, longueurAlphabet);
                motDePasse += alphabet[index];
            }
            

            Console.WriteLine($"Mot de passe : {motDePasse}");

            


        }
    }
}
