using Detoneitor.Executeitor.Excecoes;
using System.IO;

namespace Detoneitor.Executeitor.Entidades
{
    class GerenciadorDePastas
    {
        private readonly string _sPastaLogExcecao = @"\LogExcecao\";
        private readonly string _sPastaLogExecucao = @"\LogExecucao\";
        public string PastaLimpeza { get; private set; }

        public GerenciadorDePastas( string pCaminhoPasta )
        {
            if ( Directory.Exists( pCaminhoPasta ) ) PastaLimpeza = pCaminhoPasta; else throw new GerenciadorDePastaException( "Caminho da pasta de limpeza não existe" );
        }

        /// <summary>
        /// Cria o caminho para a pasta de log de exceção.
        /// </summary>
        /// <param name="pCaminhoRaiz"></param>
        /// <returns>
        /// Caminho da pasta LogExcecao.
        /// </returns>
        public string ObterPastaExcecao( string pCaminhoRaiz )
        {
            return pCaminhoRaiz + _sPastaLogExcecao;
        }

        /// <summary>
        /// Cria o caminho para a pasta de log de execução.
        /// </summary>
        /// <param name="pCaminhoRaiz"></param>
        /// <returns>
        /// Caminho da pasta LogExecucao.
        /// </returns>
        public string ObterPastaExecucao( string pCaminhoRaiz )
        {
            return pCaminhoRaiz + _sPastaLogExecucao;
        }

        /// <summary>
        /// Verifica se as pastas de logs existem, caso não existam serão criadas.
        /// </summary>
        /// <param name="pCaminhoRaiz"></param>
        public void VerificarPastas( string pCaminhoRaiz )
        {
            if ( Directory.Exists( pCaminhoRaiz + _sPastaLogExecucao ) == false ) Directory.CreateDirectory( pCaminhoRaiz + _sPastaLogExecucao );
            if ( Directory.Exists( pCaminhoRaiz + _sPastaLogExcecao ) == false ) Directory.CreateDirectory( pCaminhoRaiz + _sPastaLogExcecao );
        }
    }
}
