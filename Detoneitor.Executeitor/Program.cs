using Detoneitor.Executeitor.Entidades;
using Detoneitor.Executeitor.Servicos;
using System;
using System.Configuration;
using System.IO;

namespace Detoneitor.Executeitor {
    class Program {
        private static string _pastaRaiz;

        static void Main(string[] args) {
            _pastaRaiz = Environment.CurrentDirectory;
#if (DEBUG)
            _pastaRaiz = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
#endif
            GerenciadorDePastas gerenciador = new GerenciadorDePastas(ConfigurationManager.OpenExeConfiguration(_pastaRaiz + @"\Planejeitor.exe").AppSettings.Settings["CaminhoPasta"].Value);

            gerenciador.VerificarPastas(_pastaRaiz);

            //GeradorDeLog logExcecao = new GeradorDeLog(gerenciador.ObterPastaExcecao(_pastaRaiz), @"\LogExcecao_" + DateTime.Today.ToString("dd.MM.yyyy") + ".txt");
            //GeradorDeLog logExecucao = new GeradorDeLog(gerenciador.ObterPastaExecucao(_pastaRaiz), @"\LogExecucao_" + DateTime.Today.ToString("dd.MM.yyyy") + ".txt");

            try {
                Console.WriteLine(" - Iniciando limpeza...");
                //logExecucao.Escrever(" - Iniciando limpeza...");

                LimpadorDePasta.LimparPasta(gerenciador.PastaLimpeza);

                Console.WriteLine(" - Limpeza finalizada!");
                //logExecucao.Escrever(" - Limpeza finalizada!");

                //logExecucao.Escrever("---------------------------------------------");
            } catch (Exception erro) {
                //logExcecao.Escrever(erro.Message);
                //logExcecao.Escrever(erro.StackTrace);
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
            }
        }
    }
}
