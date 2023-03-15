using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculosTerrestres.Veiculo
{
    internal class Onibus : VeiculoTerrestre
    {
        public int Passageiros { get; set; }

        public Onibus(int rodas, double velocidadeMaxima, string cor, int passageiros) : base(rodas, velocidadeMaxima, cor)
        {
            Categoria = "Onibus";
            Passageiros = passageiros;
        }

        public override string Diferencial()
        {
            return $"capacidade para {Passageiros} pessoas";
        }
    }
}
