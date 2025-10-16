using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace prelab_3
{
    internal class Resisteur
    {
        public double Ohm {  get; set; }
        public Resisteur Resisteur1 { get; set; }
        public Resisteur Resisteur2 { get; set; }
        public string Type { get; set; }
        public Tension TensionAssocie { get; set; }
        public double Tension { get; set; }
        public double Courant { get; set; }
        public Courant CourantAssocie { get; set; }

        public Resisteur(double omh)
        {
            Ohm = omh;
        }
        public Resisteur(Resisteur resisteur1,Resisteur resisteur2,string type)
        {
            Resisteur1 = resisteur1;
            Resisteur2 = resisteur2;
            Type = type;
            double valeur1 = resisteur1.Ohm;
            double valeur2 = resisteur2.Ohm;
            if (type == "p")
            {
                Ohm =  1 / (1 / Convert.ToDouble(valeur1) + 1 / Convert.ToDouble(valeur2));
            }
            else if (type == "s")
            {
                Ohm =  Convert.ToDouble(valeur1) + Convert.ToDouble(valeur2);

            }
            else
            {
                Ohm = 0;
            }
        }

        public double Ohm1(Tension T)
        {
            Tension = T.Volt / Ohm;
            return T.Volt / Ohm;
        }

        public double Ohm2(Courant T)
        {
            Courant =  T.Amperemetre * Ohm;
            return T.Amperemetre * Ohm;
        }

        public void Show()
        {
            Console.WriteLine("Resistamce : "+Ohm);
            Console.WriteLine("Tension : "+Tension);
            Console.WriteLine("Courant : "+Courant);
        }
    }
}
