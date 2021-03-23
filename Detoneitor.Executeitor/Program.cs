using BibliotecaPublica.Classes.Gerenciadores;
using Detoneitor.Executeitor.Entidades;
using Detoneitor.Executeitor.Servicos;
using System;
using System.Configuration;
using System.IO;

namespace Detoneitor.Executeitor {
    class Program {
        private static string _sPastaRaiz;

        static void Main(string[] args)
        {
            try
            {
                _sPastaRaiz = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);

                GerenciadorConfiguracao configurador = new GerenciadorConfiguracao(_sPastaRaiz + @"\Planejeitor.exe");

                GerenciadorPastas gerenciador = new GerenciadorPastas(configurador.BuscarConfiguracao("CaminhoPasta"));

                Console.WriteLine("Pasta raíz: " + _sPastaRaiz);
                Console.WriteLine("Pasta alvo: " + gerenciador.PastaLimpeza);

                Console.WriteLine("\n - Iniciando limpeza...");

                Faxineira.LimparPasta(gerenciador.PastaLimpeza);

                Console.WriteLine("\n - Limpeza finalizada!");
            }
            catch (Exception erro)
            {
                Console.WriteLine(_sPastaRaiz + @"\Planejeitor.exe");
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
