using System;

namespace exo22test
{
    public class Program
    {

        static void Main(string[] args)
        {

            CompteSurCarnet x = new CompteSurCarnet();
            CompteSurCheque y = new CompteSurCheque();

            int choix;
            int s = -1;
            int a = -1;


            do
            {
                Console.WriteLine("/////////// Bienvenue sur votre compte bancaire. Choisissez votre action ! //////////");
                Console.WriteLine("1 - Créer un compte carnet.");
                Console.WriteLine("2 - Créer un compte cheque.");
                Console.WriteLine("3 - Afficher les comptes.");
                Console.WriteLine("4 - Suprimer un compte.");
                Console.WriteLine("5 - Afficher les info d'un compte.");
                Console.WriteLine("6 - Quitter le programe.");
                Console.WriteLine("==> Choisir une option.");
                Console.WriteLine("");

                choix = Int32.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:

                        Banque.AjouterCarnet(x);
                        break;

                    case 2:

                        Banque.AjouterCheque(y);
                        break;

                    case 3:

                        Banque.AfficherTout();
                        break;

                    case 4:

                        Banque.Suprimer(s);
                        break;

                    case 5:

                        Banque.Afficher(a);
                        break;

                    case 6:

                        //Quitter le programme
                        Console.WriteLine("Fin du programme");
                        break;

                    default:
                        Console.WriteLine(" Votre choix d'option est incorrecte !");
                        break;
                }
            }
            while (choix != 6);
            Console.ReadKey();

        }
    }
}

