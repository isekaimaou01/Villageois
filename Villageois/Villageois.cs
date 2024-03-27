namespace libVillageois
{
    public class Villageois
    {
        private string nom;
        private double poids;
        private bool malade;
        private Potion maPotion;

        public Villageois(string nom)
        {
            this.nom = nom;
            this.malade = false;
            this.maPotion = new Potion(0);

        }
        public Villageois(string nom, double poids, bool malade)
        {
            this.nom = nom;
            this.poids = poids;
            this.malade = malade;
            this.maPotion = new Potion(0);
        }
        public Villageois(string nom, double poids, bool malade, int unePotion)
        {
            this.nom = nom;
            this.poids = poids;
            this.malade = malade;
            this.maPotion = new Potion(unePotion);
        }
        public string getNom()
        {
            return nom;
        }
        public double getPoids()
        {
            return poids;
        }
        public bool getmalade(bool malade) 
        {
            return malade;
        }
        public override string ToString()
        {
                string malade = "malade";
                if (!this.malade)
                {
                    malade = "pas malade";
                }
                return $"Le villageois se nomme {this.nom} peut soulever {this.poids} et {this.malade}";
        }
        public double poidsSouleve() 
        {
            return poids / 5;
        }
        public void setPoids(int poids)
        {
            this.poids = poids;
        }
        public bool soulevememepoids(Villageois bagui)
        {
            bool condit = false;
            if (this.poids == bagui.getPoids())
            {
                condit = false;
            }
            return condit ;
            
        }
        public void conséquencesdoses()
        {
            if (maPotion.getDoses() < 5)
            {
                for (int i = 0; i < 6; i++)
                {
                    this.poids = this.poids * 1.1;
                }
            }
        }
        public void setDose (int dose)
        {
            this.maPotion.ajouterdose(dose);
        }
        public Potion getPotion()
        {
            return this.maPotion;
        }
        public string plusFort(Villageois b)
        {
            string rep;
            if (this.soulevememepoids(b))
            {
                rep = "ils sont de force égale";
            }
            else
            {
                if (this.getPoids() > b.getPoids())
                {
                    rep = $"{this.getNom()} est le plus fort";
                }
                else
                {
                    rep = $"{b.getNom()} est plus fort";
                }
            }
            return rep;
        }
    }   
    
}