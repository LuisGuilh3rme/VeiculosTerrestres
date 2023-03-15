using System.Transactions;

namespace VeiculosTerrestres
{
    internal class VeiculoTerrestre
    {
        public int Rodas { get; set; }
        public double VelocidadeMaxima { get; set; }
        public string Cor { get; set; }
        public string Categoria { get; set; }

        public VeiculoTerrestre(int rodas, double velocidadeMaxima, string cor)
        {
            Rodas = rodas;
            VelocidadeMaxima = velocidadeMaxima;
            Cor = cor;
        }

        public override string ToString()
        {
            return $"{Categoria} {Cor}, possuindo {Rodas} rodas, velocidade máxima {VelocidadeMaxima} KM/h, {Diferencial()}";
        }

        public virtual string Diferencial()
        {
            return "";
        }
    }
}
