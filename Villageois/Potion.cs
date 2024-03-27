namespace libVillageois
{
    public class Potion
    {
        private int dose;


        public Potion(int dose)
        {
            this.dose = dose;
        }
        public void ajouterdose(int nbdose)
        {
            dose = nbdose + dose ;
        }
        public int getDoses()
        {
            return dose;
        }
        public double conséquencesdoses()
        {
            double ret = 0;
            if (dose < 5)
            {
               ret = 0.5;
            }
            return ret;
        }
    }
    
}