using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = "Conrado";
            string name2 = "Pedrita";

            int idade = 15;
            int idade2 = 19;

            int cafes2 = 5;
            int cafes = 187;
            int soma = 187 + 5;

            int faltam = 13;
            int faltam2 = 195;

            bool falso = false;
            bool verdadeiro = true;

            Console.WriteLine(" Aula 03 - Atividade com variáveis \n \n \n \n \n");

            Console.WriteLine("Olá! \n Bem vindo ao sistema de usuários do Conradito");
            Console.WriteLine(" Abaixo estão as informações dos usuários cadastrados" +
                "no nosso sistema \n \n \n");

            Console.WriteLine("----- Lista de usuários:");
            Console.WriteLine ($" 1 - Nome: {name}, idade {idade}: {falso}");
            Console.WriteLine($" 2 - Nome: {name2}, idade {idade2}: {verdadeiro} \n \n \n");

            Console.WriteLine("----- Quantidade de cafés");
            Console.WriteLine($" O cliente {name} já tomou {cafes} cafés!");
            Console.WriteLine($" O cliente {name2} já tomou {cafes2} cafés!");
            Console.WriteLine(" \n \n \n");

            Console.WriteLine(" ----- Soma de cafés tomados");
            Console.WriteLine($" Juntos, os clientes {name} e {name2} tomaram {soma} cafés!");
            Console.WriteLine(" \n \n \n");

            Console.WriteLine(" Quantos cafés faltam para chegar aos 200?");
            Console.WriteLine($" Faltam {faltam} para {name}");
            Console.WriteLine($" Faltam {faltam2} para {name2}");
            Console.WriteLine(" \n \n \n");

            Console.WriteLine("----- Fim do sistema de consultas \n - Obrigado e volte sempre!");



        }
    }
}
