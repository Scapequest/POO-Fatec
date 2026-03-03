using ArrayConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Conta[] vetConta = new Conta[3];
        for (int i = 0; i < vetConta.Length; i++){
            vetConta[i] = new Conta();
            Console.Write("Digite o número da conta: ");
            vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o títular da conta: ");
            vetConta[i].titular = Console.ReadLine();
            Console.Write("Digite o saldo da conta: ");
            vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < vetConta.Length; i++)
            vetConta[i].MostrarAtributos();
    }
}