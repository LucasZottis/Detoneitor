using Detoneitor.Planejeitor.Modelo.Repositorio;

namespace Detoneitor.Planejeitor.Modelo.Entidades {
    class Configuracao {
        public string Dia { get; private set; }
        public string CaminhoPasta { get; private set; }

        public Configuracao() {
            if (VerificarConfiguracoes() == false) {
                ConfiguracaoRepositorio.Inserir("Dia", null);
                ConfiguracaoRepositorio.Inserir("CaminhoPasta", null);
            }

            Dia = ObterDia();
            CaminhoPasta = ObterCaminhoPasta();
        }

        private bool VerificarConfiguracoes() {
            return ConfiguracaoRepositorio.VerificarConfiguracao("Dia") == true && ConfiguracaoRepositorio.VerificarConfiguracao("CaminhoPasta");
        }

        private string ObterDia() {
            return ConfiguracaoRepositorio.ObterConfiguracao("Dia");
        }
        private string ObterCaminhoPasta() {
            return ConfiguracaoRepositorio.ObterConfiguracao("CaminhoPasta");
        }

        public void AlterarDia(string valor) {
            ConfiguracaoRepositorio.Alterar("Dia", valor);
        }
        public void AlterarCaminhoPasta(string valor) {
            ConfiguracaoRepositorio.Alterar("CaminhoPasta", valor);
        }
    }
}
