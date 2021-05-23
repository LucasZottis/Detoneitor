using Detoneitor.Executeitor.Excecoes;
using System.IO;

namespace Detoneitor.Executeitor.Entidades
{
    class GerenciadorPastas
    {
        #region Propriedades e Atributos

        private readonly string _sPastaLogExcecao = @"\LogExcecao\";
        private readonly string _sPastaLogExecucao = @"\LogExecucao\";

        #endregion

        #region Propriedades

        public string PastaLimpeza { get; private set; }

        #endregion Propriedades

        #region Construtores

        public GerenciadorPastas(string caminhoPasta)
        {
            if (Directory.Exists(caminhoPasta))
            {
                PastaLimpeza = caminhoPasta;
            }
            else
            {
                throw new GerenciadorPastasException("Caminho da pasta de limpeza não existe");
            }
        }

        #endregion Construtores

        #region Métodos Públicos

        /// <summary>
        /// Cria o caminho para a pasta de log de exceção.
        /// </summary>
        /// <param name="pCaminhoRaiz"></param>
        /// <returns>
        /// Caminho da pasta LogExcecao.
        /// </returns>
        public string ObterPastaExcecao(string caminhoRaiz)
        {
            return caminhoRaiz + _sPastaLogExcecao;
        }

        /// <summary>
        /// Cria o caminho para a pasta de log de execução.
        /// </summary>
        /// <param name="pCaminhoRaiz"></param>
        /// <returns>
        /// Caminho da pasta LogExecucao.
        /// </returns>
        public string ObterPastaExecucao(string caminhoRaiz)
        {
            return caminhoRaiz + _sPastaLogExecucao;
        }

        /// <summary>
        /// Verifica se as pastas de logs existem, caso não existam serão criadas.
        /// </summary>
        /// <param name="pCaminhoRaiz"></param>
        public void VerificarPastas(string caminhoRaiz)
        {
            if (!Directory.Exists(caminhoRaiz + _sPastaLogExecucao))
            {
                Directory.CreateDirectory(caminhoRaiz + _sPastaLogExecucao);
            }

            if (!Directory.Exists(caminhoRaiz + _sPastaLogExcecao))
            {
                Directory.CreateDirectory(caminhoRaiz + _sPastaLogExcecao);
            }
        }

        #endregion Métodos Públicos
    }
}