using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAluno
{
    public class Aluno
    {
        public long ra;
        public string nome;
        public double p1;
        public double p2;
        public double media;

        public void MostrarAtributos()
        {
            System.Console.WriteLine($"\nRA: {ra}\t\tNome: {nome}\nNota P1: {p1}\tNota P2: {p2}\n\tMédia: {media}");
        }
        public void CalcularMedia()
        {
            media = (p1 + p2) / 2;
        }
    }
}