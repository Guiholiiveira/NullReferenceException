using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var utilitarios = new Utils();
            utilitarios.Getnull();
        }

        public class Utils
        {
            public void Getnull()
            {
                ObjetoX objetox = null;
                try
                {
                    var nome = objetox.Nome;
                }
                catch (Exception ex)
                {
                    if (ex.GetType() == typeof(NullReferenceException))
                    {
                        Console.WriteLine("Gerou uma Exception do tipo NullReferenceException.");
                    }
                }
            }
        }

        public class ObjetoX
        {
            public string Nome { get; set; }
        }
    }
}
