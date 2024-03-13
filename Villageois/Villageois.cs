namespace libVillageois
{
    public class Villageois
    {
        private string nom;
        private int poids;
        private bool malade;

        public Villageois(string nom)
        {
            this.nom = nom;
            this.malade = false;
        }
        public Villageois(string nom, int poids, bool malade)
        {
            this.nom = nom;
            this.poids = poids;
            this.malade = malade;
        }
        public string getNom()
        {
            return nom;
        }
        public int getPoids()
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
        public int poidsSouleve(int poidsSouleve) 
        {
            poidsSouleve = (poids / 5);
            return poidsSouleve ;
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
    }   
}