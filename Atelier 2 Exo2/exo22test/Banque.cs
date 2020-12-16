using System;
using System.Collections.Generic;

namespace exo22test
{
    public class Banque
    {

        // Listes des comptes carnet et cheque.
        public static List<CompteSurCarnet> CompteCa = new List<CompteSurCarnet>();
        public static List<CompteSurCheque> CompteCh = new List<CompteSurCheque>();


        // Fontion pour chercher un compte carnet.
        static int ChercheCar(List<CompteSurCarnet> L, int car)
        {
            int a = -1;
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i].NumCompte == car)
                {
                    a = i;
                    break;
                }
            }
            return a;
        }

        // Fontion pour chercher un compte Cheque.
        static int ChercheCheq(List<CompteSurCheque> L, int car)
        {
            int a = -1;
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i].NumCompte == car)
                {
                    a = i;
                    break;
                }
            }
            return a;
        }

        // Fontion pour chercher un numéro de compte carnet.
        static int ChercherNumCarnet(List<CompteSurCarnet> L, int r)
        {
            int a = -1;
            for (int i = 0; i < L.Count; i++)
            {

                if (L[i].NumCarnet == r)
                {
                    a = i;
                    break;
                }
            }
            return a;
        }

        // Fontion pour chercher un numéro de compte cheque.
        static int ChercherNumCheque(List<CompteSurCheque> L, int r)
        {
            int a = -1;
            for (int i = 0; i < L.Count; i++)
            {

                if (L[i].NumChèque == r)
                {
                    a = i;
                    break;
                }
            }
            return a;
        }








        // 1 Ajouter un compte carnet.
        public static void AjouterCarnet(CompteSurCarnet compte)
        {
            Console.WriteLine("input Canret number.");
            compte.NumCarnet = Int32.Parse(Console.ReadLine());

            int a = ChercherNumCarnet(CompteCa, compte.NumCarnet);

            if (a != -1)
            {
                Console.WriteLine("Ce compte existe déjà !");
            }
            else
            {
                Console.WriteLine("input name.");
                compte.NomProprio = Console.ReadLine();

                Console.WriteLine("input balance.");
                compte.Solde = Int32.Parse(Console.ReadLine());


                CompteCa.Add(new CompteSurCarnet(compte.NumCompte++, compte.NumCarnet, compte.NomProprio, compte.Solde));
                Console.WriteLine("Congrat, your account has been added !");

            }
        }


        // 2 Ajouter un compte cheque.
        public static void AjouterCheque(CompteSurCheque compte)
        {

            Console.WriteLine("input cheque number.");
            compte.NumChèque = Int32.Parse(Console.ReadLine());

            int a = ChercherNumCheque(CompteCh, compte.NumChèque);

            if (a != -1)
            {
                Console.WriteLine("Ce compte existe déjà !");
            }
            else
            {
                Console.WriteLine("Veuillez saisir votre nom.");
                compte.NomProprio = Console.ReadLine();

                Console.WriteLine("Veuillez saisir votre solde.");
                compte.Solde = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Veuillez saisir la date de fin de validité de votre carte.");
                compte.DateFinValiditéCarte = Console.ReadLine();

                CompteCh.Add(new CompteSurCheque(compte.NumCompte++, compte.NumChèque, compte.NumCarte++, compte.NomProprio, compte.Solde, compte.DateFinValiditéCarte));
                Console.WriteLine("Félicitation! Votre compte carnet à été ajouté avec succès !");
            }

        }


        // 3 Afficher tous les comptes.
        public static void AfficherTout()
        {
            Console.WriteLine("******** Comptes sur carnet ********");
            foreach (CompteSurCarnet compte in CompteCa)
            {
                compte.Info();
            }
            Console.WriteLine("******** Comptes sur Cheque ********");
            foreach (CompteSurCheque compte in CompteCh)
            {
                compte.Info();
            }
            if (CompteCa.Count == 0 && CompteCh.Count == 0)
            {
                Console.WriteLine("Aucun compte n'a été trouvé !");
            }
        }


        // 4 Afficher un numéro de compte.
        public static void Afficher(int num)
        {
            Console.WriteLine("Choisissez le compte à verifier : (1) Compte Carnet     (2) Compte Cheque !");
            num = Int32.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Veuillez entrer un numéro de compte !");
                int numCompte = Int32.Parse(Console.ReadLine());
                int a;

                a = ChercheCar(CompteCa, numCompte);

                if (a == -1)
                {

                    Console.WriteLine("Ce compte n'existe pas !");
                    //return -1;
                }
                else
                {
                    foreach (var compte in CompteCa)
                    {
                        if (compte.NumCompte == numCompte)
                        {
                            compte.Info();
                        }
                    }
                }
            }
            if (num == 2)
            {
                Console.WriteLine("Veuillez entrer un numéro de compte !");
                int numCompte = Int32.Parse(Console.ReadLine());
                int a;

                a = ChercheCheq(CompteCh, numCompte);

                if (a == -1)
                {

                    Console.WriteLine("Ce compte n'existe pas !");
                    //return -1;
                }
                else
                {
                    foreach (var compte in CompteCh)
                    {
                        if (compte.NumCompte == numCompte)
                        {
                            compte.Info();

                        }
                    }
                }
            }

        }


        // 5 Supprimer un compte.
        public static void Suprimer(int num)
        {
            Console.WriteLine("Choisissez le compte à suprimer : (1) Compte Carnet     (2) Compte Cheque !");
            num = Int32.Parse(Console.ReadLine());

            if (num == 1)
            {
                int a;
                Console.WriteLine("Veuillez entrer un numéro de compte !");
                int NumCompte = Int32.Parse(Console.ReadLine());

                a = ChercheCar(CompteCa, NumCompte);

                if (a == -1)
                {
                    Console.WriteLine("Ce compte n'existe pas !");
                }
                else
                {
                    CompteCa.RemoveAt(a);

                    Console.WriteLine("Le compte a été suprimé avec succès !");
                }
            }
            if (num == 2)
            {
                int a;
                Console.WriteLine("Veuillez entrer un numéro de compte !");
                int NumCompte = Int32.Parse(Console.ReadLine());

                a = ChercheCheq(CompteCh, NumCompte);

                if (a == -1)
                {
                    Console.WriteLine("Ce compte n'existe pas !");
                }
                else
                {
                    CompteCh.RemoveAt(a);

                    Console.WriteLine("Le compte a été suprimé avec succès !");
                }
            }

        }


    }
}
