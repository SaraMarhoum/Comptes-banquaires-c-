using System;
using System.Collections.Generic;

namespace exo22test
{
    public class CompteSurCheque : AbstractCompte
    {

        protected int numChèque;
        protected int numCarte;
        protected string dateFinValiditéCarte;

        public int NumChèque
        {
            get { return numChèque; }
            set { numChèque = value; }
        }

        public int NumCarte
        {
            get { return numCarte; }
            set { numCarte = value; }
        }

        public string DateFinValiditéCarte
        {
            get { return dateFinValiditéCarte; }
            set { dateFinValiditéCarte = value; }
        }


        public CompteSurCheque()
        {
        }

        public CompteSurCheque(int numCompte, int numChèque, int numCarte, string nomProprio, int solde, string dateFinValiditéCarte) : base(numCompte, nomProprio, solde)
        {
            this.numChèque = numChèque;
            this.numCarte = numCarte;
            this.dateFinValiditéCarte = dateFinValiditéCarte;
        }


        public override void Info()
        {

            Console.WriteLine("Compte n° : " + NumCompte);
            Console.WriteLine("Propriétaire : " + NomProprio);
            Console.WriteLine("Solde : " + Solde + " DH");
            Console.WriteLine("Chèque n° : " + NumChèque);
            Console.WriteLine("Carte n° : " + NumCarte);
            Console.WriteLine("Date d'éxpiration : " + DateFinValiditéCarte);
            Console.WriteLine();

        }

        public static int ChercheCompte(List<CompteSurCheque> L, int car)
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

        public override void Créditer(double a)
        {

        }
        public override void Débiter(double r)
        {
            try
            {
                if (r < solde)
                {
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solde insuffisant ! Attention, La somme à débiter dépasse votre solde ! : {0}", ex.Message);
            }

            try
            {
                if (r < 10000)
                {
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Plafond dépassé ! Attention, La somme à débiter dépasse le plafond fixé à 10000 Dh ! : {0}", ex.Message);
            }
        }
    }
}
