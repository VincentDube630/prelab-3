namespace prelab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Créer les résisteurs du circuit
            Resisteur r1 = new Resisteur(1);
            Resisteur r2 = new Resisteur(2);
            Resisteur r3 = new Resisteur(3);
            Resisteur r4 = new Resisteur(6);
            Resisteur r5 = new Resisteur(4);
            //Créer les résisteurs équivalents en indiquant le type
            Resisteur r12 = new Resisteur(r1, r2, "s");
            Resisteur r123 = new Resisteur(r12, r3, "s");
            Resisteur r1234 = new Resisteur(r123, r4, "p");
            Resisteur req = new Resisteur(r1234, r5, "s");

            //Appeler la fonction Ohm (avec une électromotance de 21 ici).
            req.Ohm1(new Tension(21));

            req.Show();

        }
    }
}
