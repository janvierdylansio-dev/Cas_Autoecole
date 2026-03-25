namespace Cas_Autoecole
{

    public class Vehicule
    {
        private string immat;
        private string module;
        private string couleur;
        private bool enEtat;

        public Vehicule() { }
        public Vehicule(string immat, string modele, string couleur)
        {
            this.immat = immat;
            this.module = modele;
            this.couleur = couleur;
            this.enEtat = true;
        }

        public string GetImmat()
        { return $"{immat}"; }
        public override string ToString()
        {
            return $"{enEtat}";
        }
    }
    }