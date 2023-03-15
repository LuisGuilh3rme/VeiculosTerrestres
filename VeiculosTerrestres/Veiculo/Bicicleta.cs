using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculosTerrestres.Veiculo
{
    internal class Bicicleta : VeiculoTerrestre
    {
        public int NivelBuzina { get; set; }

        public Bicicleta(int rodas, double velocidadeMaxima, string cor, int nivelBuzina) : base(rodas, velocidadeMaxima, cor)
        {
            Categoria = "Bicicleta";
            NivelBuzina = nivelBuzina;
        }

        public override string Diferencial()
        {
            return $"nível da buzina {NivelBuzina}";
        }
    }
}
