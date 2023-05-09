using System;
using System.Runtime.ConstrainedExecution;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Os erros são tratados como exceptions. Exceptions são exceções, algo que não deveria acontecer.

            var array = new int[3];

            try //tenta
            {
                //for (var index = 0; index < 10; index++)
                //{
                //    Console.WriteLine(array[index]);
                //}

                //Teste do disparo de erro
                Cadastrar("");

            }
            //tratar os erros sempre do mais específico para o genérico
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice da lista");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar texto");
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Data_Log);
                Console.WriteLine("Exceção customizada para data");
            }
            catch (Exception ex)
            { //caso dê erro
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Algo deu errado!");
            }
            //o finally é mostrado independente do erro acontecer ou não
            finally
            {
                Console.WriteLine("Fim da execução");
            }
            Console.ReadKey();
        }

        //Disparar os erros

        static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                // throw new Exception("O texto não pode ser nulo ou vazio!");
                throw new MinhaException(DateTime.Now);
        }
        public class MinhaException : Exception
        {

            public MinhaException(DateTime date)
            {
                Data_Log = date;
            }
            public DateTime Data_Log { get; set; }
        }
    }
}
