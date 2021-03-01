using Detoneitor.Executeitor.Entidades;
using Detoneitor.Executeitor.Servicos;
using System;
using System.Configuration;
using System.IO;

namespace Detoneitor.Executeitor {
    class Program {
        private static string _pastaRaiz;

        static void Main(string[] args) {

            try {
                _pastaRaiz = Environment.CurrentDirectory;
#if (DEBUG)
                _pastaRaiz = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
#endif
                GerenciadorDePastas gerenciador = new GerenciadorDePastas(ConfigurationManager.OpenExeConfiguration(_pastaRaiz + @"\Planejeitor.exe").AppSettings.Settings["CaminhoPasta"].Value);

                gerenciador.VerificarPastas(_pastaRaiz);

                Console.WriteLine(" - Iniciando limpeza...");

                LimpadorDePasta.LimparPasta(gerenciador.PastaLimpeza);

                Console.WriteLine(" - Limpeza finalizada!");
            } catch (Exception erro) {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
            }
        }
    }
}
