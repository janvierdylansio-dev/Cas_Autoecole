namespace Cas_Autoecole
{
    public class Eleve
    {
        private string Nom { get; set; }
        private string prenom;
        private DateTime dateInsription;
        private int credit;


        public Eleve(string nom, string prenom, DateTime dateinscription, int credit)
        {
            this.Nom = nom;
            this.prenom = prenom;
            this.dateInsription = dateinscription;
        }
        public override string ToString()
        {
            return $"{Nom}";
        }


    }
}