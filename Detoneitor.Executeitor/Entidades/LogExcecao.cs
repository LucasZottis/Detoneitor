using System;
using System.Text;

namespace Detoneitor.Executeitor.Entidades
{
    class LogExcecao
    {
        #region Atributos

        private string _nomeLog = $@"\LOG_EXCEÇÂO_{DateTime.Now.ToString("dd-MM-yyyy")}.txt";

        private StringBuilder _mensagem = new StringBuilder();

        #endregion Atributos

        #region Propriedades

        public string Mensagem { get; private set; }

        public string Rastreio { get; private set; }

        public string NomeLog { get => _nomeLog; }

        #endregion Propriedades

        #region Construtores

        public LogExcecao(string mensagem, string rastreio)
        {
            Mensagem = mensagem;
            Rastreio = rastreio;
        }

        #endregion Construtores

        #region Métodos Privados

        private string CriarMensagem()
        {
            _mensagem.AppendLine($"--- Ocorreu uma exceção em {DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss")} ---\n");
            _mensagem.AppendLine($" - Mensagem: {Mensagem}\n");
            _mensagem.AppendLine($" - Pilha de rastreio: {Rastreio}\n");
            _mensagem.AppendLine("-------------------------------------------------------------------------------------\n");

            return Mensagem.ToString();
        }

        #endregion Métodos Privados

        #region Métodos Sobrescritos

        public override string ToString()
        {
            return CriarMensagem();
        }

        #endregion Métodos Sobrescritos
    }
}