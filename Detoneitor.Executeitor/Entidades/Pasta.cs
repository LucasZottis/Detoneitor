using BibliotecaPublica.Classes.Gerenciadores;
using BibliotecaPublica.Classes.Verificadores;
using System.IO;
using System.Text;

namespace Detoneitor.Executeitor.Entidades
{
    class Pasta
    {
        #region Atributos

        private StringBuilder _mensagemValidacao = new StringBuilder();
        private GerenciadorConfiguracao _gerenciador = new GerenciadorConfiguracao();

        #endregion Atributos

        #region Propriedades

        public int Codigo { get; private set; }

        public string NomePasta { get; private set; }

        public string Caminho { get; private set; }

        #endregion Propriedades

        #region Construtores

        public Pasta(int codigo, string nomePasta, string caminho)
        {
            if (codigo < 1)
            {
                _mensagemValidacao.AppendLine(" - Código inválido.");
            }

            if (caminho.TemConteudo() && Directory.Exists(caminho))
            {
                _mensagemValidacao.AppendLine(" - Pasta informada não existe.");
            }

            if (nomePasta.TemConteudo())
            {
                _mensagemValidacao.AppendLine(" - Não foi informado o nome da pasta.");
            }

            if (!_mensagemValidacao.TemConteudo())
            {
                Codigo = codigo;
                NomePasta = nomePasta;
                Caminho = caminho;
            }
        }

        #endregion Construtores

        #region Métodos Públicos

        public string Validar()
        {
            return _mensagemValidacao.ToString();
        }

        #endregion Métodos Públicos

        #region Métodos Sobrescritos

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Pasta))
            {
                return false;
            }

            Pasta pastaInformada = obj as Pasta;

            return this.Codigo.Igual(pastaInformada.Codigo);
        }

        #endregion Métodos Sobrescritos
    }
}
