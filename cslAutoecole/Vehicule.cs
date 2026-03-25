using Cas_Autoecole;
Eleve eleve1 = new Eleve("toto", "robert", new DateTime(2025, 1, 1), 25);
Console.WriteLine(eleve1.ToString());


public class Vehicule
{
    private string immat;
    private string module;
    private string couleur;
    private bool enEtat;

    public Vehicule(){}
    public Vehicule(string immat, string modele,string couleur)
    { this.immat = immat; 
      this.module = modele; 
      this.couleur = couleur; 
      this.enEtat = true; }
     
    public override string GetImmat()
    { return $"{immat}"; }
    public override string ToString()
    {
        return base.ToString();
    }
    public override string Vehicule()
    { return $"{enEtat}";}