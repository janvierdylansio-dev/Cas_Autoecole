namespace Cas_Autoecole
{

    public class lecon
    {
        private DateTime dateLecon;
        private DateTime heureLecon;
        private bool effectuer;
        private Eleve elv;
        private Vehicule vhc;

        public lecon(DateTime dateLecon, DateTime heureL, bool effectuee, Eleve elv, Vehicule vhc)
        {
            this.dateLecon = dateLecon;
            this.heureLecon = heureL;
            this.effectuer = effectuee;
            this.elv = elv;
            this.vhc = vhc;
        }

        public override string ToString()
        { return $"{dateLecon} {heureLecon} {effectuer} "; }

  
       


  
    }
}