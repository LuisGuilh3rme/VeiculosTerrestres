using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculosTerrestres.Veiculo
{
    internal class Tanque : VeiculoTerrestre
    {
        public int Capacidade { get; set; }
        public Tanque(int rodas, double velocidadeMaxima, string cor, int capacidade) : base(rodas, velocidadeMaxima, cor)
        {
            Categoria = "Tanque";
            Capacidade = capacidade;
        }

        public virtual string Diferencial()
        {
            return $"{Capacidade} tiros disponíveis";
        }
    }
}
