using ClasseAluno;
internal class Program
{
    private static void Main(string[] args)
    {
        Aluno a1 = new Aluno();
        System.Console.Write("Digite o RA do aluno: ");
        a1.ra = Convert.ToInt64(Console.ReadLine());
        System.Console.Write("Digite o nome do aluno: ");
        a1.nome = Console.ReadLine();
        System.Console.Write("Digite a nota da P1: ");
        a1.p1 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Digite a nota da P2: ");
        a1.p2 = Convert.ToInt32(Console.ReadLine());
        a1.CalcularMedia();

        Aluno a2 = new Aluno();
        System.Console.Write("Digite o RA do aluno: ");
        a2.ra = Convert.ToInt64(Console.ReadLine());
        System.Console.Write("Digite o nome do aluno: ");
        a2.nome = Console.ReadLine();
        System.Console.Write("Digite a nota da P1: ");
        a2.p1 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Digite a nota da P2: ");
        a2.p2 = Convert.ToInt32(Console.ReadLine());
        a2.CalcularMedia();
        a1.MostrarAtributos();
        a2.MostrarAtributos();
    }
}