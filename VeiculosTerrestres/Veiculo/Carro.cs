using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculosTerrestres.Veiculo
{
    internal class Carro : VeiculoTerrestre
    {
        public int Passageiros { get; set; }
        public Carro(int rodas, double velocidadeMaxima, string cor, int passageiros) : base(rodas, velocidadeMaxima, cor)
        {
            Categoria = "Carro";
            Passageiros = passageiros;
        }

        public override string Diferencial()
        {
            return $"capacidade para {Passageiros} pessoas";
        }
    }
}
