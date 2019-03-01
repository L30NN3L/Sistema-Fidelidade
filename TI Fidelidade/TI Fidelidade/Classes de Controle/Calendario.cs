using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_Fidelidade
{
    public static class Calendario
    {
        private static double[] _static_pontos_Mes;

        public static double[] _Static_Pontos_Mes
        {
            set { _static_pontos_Mes = value; }
            get { return _static_pontos_Mes; }
        }
    }
}
