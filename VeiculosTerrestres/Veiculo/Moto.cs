using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculosTerrestres.Veiculo
{
    internal class Moto : VeiculoTerrestre
    {

        public Moto(int rodas, double velocidadeMaxima, string cor) : base(rodas, velocidadeMaxima, cor)
        {
            Categoria = "Moto";
        }
    }
}
