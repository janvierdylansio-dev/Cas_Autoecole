// See https://aka.ms/new-console-template for more information

public class lecon
{
    private DateTime dateLecon;
    private DateTime heureLecon;
    private Eleve elv;
    private Vehicule vhc;

    public lecon(DateTime dateLecon, DateTime heureLecon, bool effectuee, Eleve,  Vehicule)
    {
        this.dateLecon = dateLecon;
        this.heureLecon = heureLecon;
        this.effectuee = effectuee;
        this.vhc = Vehicule;
    }

    public override DateTime GetdateLecon()
    { return $"{dateLecon}"; }
    public override DateTime heureLecon()
   
    vehicule vchl1 = new vehicule("41AF65", "opel", "Corsa", "2019", "sans", 1500, true);
}
