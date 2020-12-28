namespace ExercicioContaBancaria
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; } // Método SET privado para 
        public string Titular { get; set; }

        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;                
        }

        //Sobrecarga de construtor
        public ContaBancaria(int numeroConta, string titular, double depositoInicial) : this(numeroConta, titular )
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5; //taxa de saque
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + Titular
                + ", Saldo: "
                + Saldo.ToString("F2");
        }




    }
}
