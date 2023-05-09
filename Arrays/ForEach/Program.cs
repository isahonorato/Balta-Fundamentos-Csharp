using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meuArray = new int[5] {1, 2, 3, 4, 5};
            meuArray[0] = 12;

            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { Id = 144, Name = "Isabella" };

            //Percorre todos os itens 
            //Para cada item no meu array, vou passar nessa interação
            foreach(var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Name);
            }

            Console.ReadKey();
    
        }

        public struct Funcionario
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
