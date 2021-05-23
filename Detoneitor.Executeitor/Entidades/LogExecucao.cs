using System;
using System.Text;

namespace Detoneitor.Executeitor.Entidades
{
    class LogExecucao
    {
        #region Atributos

        private string _nomeLog = $@"\LOG_EXECUÇÂO_{DateTime.Now.ToString("dd-MM-yyyy")}.txt";
        private StringBuilder _mensagens = new StringBuilder();

        #endregion Atributos

        #region Propriedades

        public string NomeLog { get => _nomeLog; }

        #endregion Propriedades

        #region Métodos Públicos

        public void IniciarLog(DateTime dataHoraInicio)
        {
            AdicionarMensagem($"Iniciando execução em {dataHoraInicio.ToString("dd/MM/yyyy - HH:mm:ss")}");
        }

        public void AdicionarMensagem(string mensagem)
        {
            _mensagens.AppendLine($"\n - {mensagem}");
        }

        public void FinalizarLog(DateTime dataHoraFim)
        {
            AdicionarMensagem($"Finalizando execução em {dataHoraFim.ToString("dd/MM/yyyy - HH:mm:ss")}");
        }

        #endregion Métodos Públicos

        #region Métodos Sobrescritos

        public override string ToString()
        {
            return _mensagens.ToString();
        }

        #endregion Métodos Sobrescritos
    }
}