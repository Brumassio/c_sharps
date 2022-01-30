namespace POO_HEPA.Models
{  // classe abstrata !!!
    public abstract class Conta
    {
        protected double saldo;

        public abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo é:" + saldo);
        }
    }
}