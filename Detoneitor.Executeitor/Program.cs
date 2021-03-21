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
                _sPastaRaiz = Environment.CurrentDirectory;
#if (DEBUG)
                _sPastaRaiz = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
#endif
                GerenciadorPastas gerenciador = new GerenciadorPastas(ConfigurationManager.OpenExeConfiguration(_sPastaRaiz + @"\Planejeitor.exe").AppSettings.Settings["CaminhoPasta"].Value);

                Console.WriteLine("Pasta raíz: " + _sPastaRaiz);
                Console.WriteLine("Caminho do .config: " + gerenciador.PastaLimpeza);

                Console.WriteLine("\n - Iniciando limpeza...");

                Faxineira.LimparPasta(gerenciador.PastaLimpeza);

                Console.WriteLine("\n - Limpeza finalizada!");
            }
            catch (Exception erro)
            {
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
