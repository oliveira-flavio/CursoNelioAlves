namespace MembrosEstaticos

    // Classe estática, não precisa ser instanciada para chamar os métodos.
    // Para utilização dos membros, basta fazer a chamada da classe (Calculadora)
    // mais o nome método (Circunferencia).
    // Ex: Calculadora.Cincunferencia();

{
    class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double raioEntrada)
        {
            return 2 * Pi * raioEntrada;

        }

        public static double Volume(double raioEntrada)
        {
            return 4 / 3 * Pi * raioEntrada * raioEntrada * raioEntrada;
        }

    }
}
