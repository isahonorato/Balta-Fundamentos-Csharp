using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando um identificador único e gerando HASH com o guid
            var id = Guid.NewGuid();
            //Transformando em uma string
            id.ToString();
            //Gerando um guid com valor
            id = new Guid("testeeee");
            //Pegando somente os primeiros 8 caracteres
            id.ToString().Substring(0,8);

            Console.WriteLine(id);

            Console.ReadKey();
        }
    }
}
