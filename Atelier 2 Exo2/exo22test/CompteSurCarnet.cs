using System;
using System.Collections.Generic;

namespace exo22test
{
    public class CompteSurCarnet : AbstractCompte
    {
        protected int numCarnet;

        public int NumCarnet
        {
            get { return numCarnet; }
            set { numCarnet = value; }
        }


        public CompteSurCarnet()
        {

        }

        public CompteSurCarnet(int numCompte, int numCarnet, string nomProprio, int solde) : base(numCompte, nomProprio, solde)
        {
            this.numCarnet = numCarnet;
        }

        public override void Info()
        {

            Console.WriteLine("Compte n° : " + NumCompte);
            Console.WriteLine("Propriétaire : " + NomProprio);
            Console.WriteLine("Solde : " + Solde + " DH");
            Console.WriteLine("Carnet n° : " + NumCarnet);
            Console.WriteLine("");

        }


        public static int ChercheCompte(List<CompteSurCarnet> L, int car)
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
                Console.WriteLine("Attention !! La somme à débiter dépasse votre solde ! : {0}", ex.Message);
            }
        }

    }
}
