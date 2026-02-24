using ClasseConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c1 = new Conta();
        c1.numero = 1;
        c1.titular = "Renan";
        c1.saldo = 100;
        c1.MostrarAtributos();
        c1.Sacar(50);
        c1.MostrarAtributos();

        Conta c2 = new Conta();
        c2.MostrarAtributos();

    }
}