using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_ExplicacionHerencia
{
    internal interface IMiInterfaz
    {
        void miMetodo();
        void miMetodo2(int x);
        bool MiPropiedad { get; set; }
    }

    internal class MiClase : IMiInterfaz
    {
        public bool MiPropiedad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void miMetodo()
        {
            throw new NotImplementedException();
        }

        public void miMetodo2(int x)
        {
            throw new NotImplementedException();
        }
    }
}
