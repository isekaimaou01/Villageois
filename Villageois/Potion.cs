namespace libVillageois
{
    public class Potion
    {
        private double dose;


        public Potion(int dose)
        {
            this.dose = dose;
        }
        public void ajouterdose(int nbdose)
        {
            dose = nbdose + dose ;
        }
        public double getDoses()
        {
            return dose;
        }

    }
}