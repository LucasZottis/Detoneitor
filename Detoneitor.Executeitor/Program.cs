using BibliotecaPublica.Classes.Gerenciadores;
using Detoneitor.Executeitor.Entidades;
using Detoneitor.Executeitor.Servicos;
using System;
using System.Collections.Generic;
using System.IO;

namespace Detoneitor.Executeitor
{
    class Program
    {
        private static List<string> _pastas = new List<string>();

        private static GerenciadorConfiguracao _configurador = new GerenciadorConfiguracao(CriarCaminhoPlanejeitor());
        private static GerenciadorPastas _gerenciador = new GerenciadorPastas(_configurador.BuscarConfiguracao("CaminhoPasta"));
        private static LogExecucao _logExecucao = new LogExecucao();
        private static LogExcecao _logExcecao = null;

        static void Main()
        {
            try
            {
                _logExecucao.IniciarLog(DateTime.Now);

                _gerenciador.VerificarPastas(ObterCaminhoPastaRaiz());
                AdicionarPastasLista();

                ImprimirMensagens(" ****** Pastas ******", true);
                ImprimirPastas(_pastas);

                ImprimirMensagens(" ****** Limpeza ******", true);
                ExecutarLimpeza();

                _logExecucao.FinalizarLog(DateTime.Now);
            }
            catch (Exception erro)
            {
                _logExcecao = new LogExcecao(erro.Message, erro.StackTrace);
                Console.WriteLine(erro.Message + "\n" + erro.StackTrace);
            }
            finally
            {
                GeradorLog.CriarArquivoLog(_logExecucao, _gerenciador.ObterPastaExecucao(ObterCaminhoPastaRaiz()));

                if (_logExcecao != null)
                {
                    GeradorLog.CriarArquivoLog(_logExcecao, _gerenciador.ObterPastaExcecao(ObterCaminhoPastaRaiz()));
                }

                Console.ReadKey();
            }
        }

        private static void AdicionarPastasLista()
        {
            _pastas.Add(ObterCaminhoPastaRaiz());
            _pastas.Add(_gerenciador.PastaLimpeza);
        }

        private static string ObterCaminhoPastaRaiz()
        {
            return Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        }

        private static string CriarCaminhoPlanejeitor()
        {
            return ObterCaminhoPastaRaiz() + @"\Planejeitor.exe";
        }

        private static void ImprimirPastas(List<string> pastas)
        {
            foreach (string pasta in pastas)
            {
                ImprimirMensagens($"Pasta: {pasta}");
            }
        }

        private static void ImprimirMensagens(string mensagem, bool titulo = false)
        {
            Console.WriteLine(titulo ? "\n " + mensagem : "\n - " + mensagem);
            _logExecucao.AdicionarMensagem(mensagem);
        }

        private static void ExecutarLimpeza()
        {
            ImprimirMensagens("Iniciando limpeza...");

            Faxineira.LimparPasta(_gerenciador.PastaLimpeza);
            ImprimirMensagens($"Pasta: {Path.GetDirectoryName(_gerenciador.PastaLimpeza)} está limpa!");

            ImprimirMensagens("Limpeza finalizada!");

            Faxineira.LimparPasta(_gerenciador.PastaLimpeza);
        }
    }
}