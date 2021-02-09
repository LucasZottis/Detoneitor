using Detoneitor.Executeitor.Excecoes;
using System.IO;

namespace Detoneitor.Executeitor.Entidades {
    class GerenciadorDePastas {
        private readonly string _pastaLogExcecao = @"\LogExcecao\";
        private readonly string _pastaLogExecucao = @"\LogExecucao\";
        public string PastaLimpeza { get; private set; }

        public GerenciadorDePastas(string caminhoPasta) {
            if (Directory.Exists(caminhoPasta)) PastaLimpeza = caminhoPasta; else throw new GerenciadorDePastaException("Caminho da pasta de limpeza não existe");
        }

        public string ObterPastaExcecao(string caminhoRaiz) {
            return caminhoRaiz + _pastaLogExcecao;
        }
        public string ObterPastaExecucao(string caminhoRaiz) {
            return caminhoRaiz + _pastaLogExecucao;
        }
        public void VerificarPastas(string caminhoRaiz) {
            if (Directory.Exists(caminhoRaiz + _pastaLogExecucao) == false) Directory.CreateDirectory(caminhoRaiz + _pastaLogExecucao);
            if (Directory.Exists(caminhoRaiz + _pastaLogExcecao) == false) Directory.CreateDirectory(caminhoRaiz + _pastaLogExcecao);
        }
    }
}
