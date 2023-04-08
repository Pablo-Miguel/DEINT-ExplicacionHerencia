using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_ExplicacionHerencia
{
    internal abstract class Vehiculo
    {
        public String Marca { get { return Marca; } set { Marca = value; } }
        public int Anyo { get; set; }

        public Vehiculo(String marca)
        {
            Marca = marca;
            Class1 clas1 = new Class1();
        }

        //Método virual -- OPCIÓN - redefinirla en las clases
        public virtual void DarMarchaAtras() {
            Console.WriteLine("Dando marcha atrás");
        }

        //Método abstracto -- OBLIGATORIO - de definir en las clases generales.
        public abstract void SonarClaxon();

        //Propiedad abstracta
        public abstract int VelocidadMaxima { get; }


    }

    internal class Coche : Vehiculo 
    {
        public override int VelocidadMaxima => 120;
        public String Color { get { return Color; } set { Color = value; } }

        public Coche(String marca, string color) : base(marca)
        {
            Color = color;
        }

        internal void EncenderRadio() {
            Console.WriteLine("Radio encendida");
        }

        public override void SonarClaxon()
        {
            Console.WriteLine("PII - PII - PII");
        }

        public override string ToString()
        {
            return $"Coche es de la maraca: {Marca}";
        }
    }

    internal class Camion : Vehiculo
    {
        public override int VelocidadMaxima => 90;

        public Camion(string marca) : base(marca)
        {

        }

        //Estamos sobre escribiendo el método heredado con Override
        public override void DarMarchaAtras()
        {
            base.DarMarchaAtras();
            Console.WriteLine("BEEP - BEEP - BEEP");
        }

        public override void SonarClaxon()
        {
            Console.WriteLine("PUUU - PUUU - PUUU");
        }
    }

    internal class Bicicleta : Vehiculo
    {

        public override int VelocidadMaxima => 10;

        public Bicicleta(string marca) : base(marca)
        {

        }

        public override void SonarClaxon()
        {
            Console.WriteLine("RING - RING - RING");
        }
    }
}
