using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int na, j;
            string consulta, rapesq;
            string[] nome = new string[30];
            string[] ra = new string[30];
            string[] materia = new string[30];
            string[] conc = new string[30];
            float[] nota_p1 = new float[30];
            float[] nota_p2 = new float[30];
            float[] ms = new float[30];
            Console.Write("\nDigite a quantidade de alunos: ");
            na = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= na; i++)
            {
                Console.Write("\nDigite o nome do aluno: ");
                nome[i] = Console.ReadLine();
                Console.Write("\nDigite o ra do aluno: ");
                ra[i] = Console.ReadLine();
                Console.Write("\nDigite a matéria do aluno: ");
                materia[i] = Console.ReadLine();
                Console.Write("\nDigite a nota p1 do aluno: ");
                nota_p1[i] = Convert.ToSingle(Console.ReadLine());
                Console.Write("\nDgite a nota p2 do aluno: ");
                nota_p2[i] = Convert.ToSingle(Console.ReadLine());
                ms[i] = (nota_p1[i] + nota_p2[i]) / 2;
                if (ms[i] >= 7.0f)
                    conc[i] = "Aprovado!";
                else
                    conc[i] = "Exame!";
            }
            Console.Write("\nNome:\tRA:\tMatéria:\tNotaP1:\tNotaP2:\tMédia:\tConclusão:");
            for (int i = 1; i <= na; i++)
            {
                Console.Write("\n{0}\t{1}\t{2}\t\t{3:f1}\t{4:f1}\t{5:f1}\t{6}", nome[i], ra[i], materia[i], nota_p1[i], nota_p2[i], ms[i], conc[i]);
            }
            Console.Write("\n********************************************************************");
            Console.Write("\nDeseja fazer a consulta de algum aluno?\nDigite \'s\' para sim e \'n\' para não:");
            consulta = Console.ReadLine();
            while (consulta.ToLower() == "s")
            {
                Console.Write("\nDigite o RA do aluno a ser pesquisado: ");
                rapesq = Console.ReadLine();
                j = 0;
                do
                {
                    j++;
                } while (rapesq != ra[j]);
                Console.Write("\nNome: {0}\tRA: {1}\tMatéria: {2}", nome[j], ra[j], materia[j]);
                Console.Write("\nNotaP1: {0:f1}\tNotaP2: {1:f1}\tMédia: {2:f1}\tConclusão: {3}", nota_p1[j], nota_p2[j], ms[j], conc[j]);
                Console.Write("\nDeseja continuar a pesquisa?\nDigite \'s\' para sim e \'n\' para não:");
                consulta = Console.ReadLine();
            }
        }
    }
}
