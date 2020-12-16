namespace exo22test
{
    public abstract class AbstractCompte
    {
        protected string nomProprio;
        protected int numCompte;
        protected int solde;

        public int NumCompte
        {
            get { return numCompte; }
            set { numCompte = value; }
        }

        public string NomProprio
        {
            get { return nomProprio; }
            set { nomProprio = value; }
        }

        public int Solde
        {
            get { return solde; }
            set { solde = value; }
        }

        protected AbstractCompte()
        {
        }

        protected AbstractCompte(int numCompte, string nomProprio, int solde)
        {
            this.nomProprio = nomProprio;
            this.numCompte = numCompte;
            this.solde = solde;
        }

        public abstract void Info();
        public abstract void Créditer(double a);
        public abstract void Débiter(double r);


    }
}
