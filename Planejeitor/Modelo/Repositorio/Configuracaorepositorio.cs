using System.Configuration;

namespace Detoneitor.Planejeitor.Modelo.Repositorio {
    static class ConfiguracaoRepositorio {
        private static Configuration _arquivoConfiguracao = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public static void Inserir(string chave, string valor) {
            _arquivoConfiguracao.AppSettings.Settings.Add(chave, valor);
            _arquivoConfiguracao.Save();
        }
        
        public static void Alterar(string chave, string valor) {
            _arquivoConfiguracao.AppSettings.Settings[chave].Value = valor;
            _arquivoConfiguracao.Save();
        }
        
        public static string ObterConfiguracao(string chave) {
            return _arquivoConfiguracao.AppSettings.Settings[chave].Value;
        }
        
        public static bool VerificarConfiguracao(string chave) {
            return _arquivoConfiguracao.AppSettings.Settings[chave] != null;
        }

        public static bool VerificarConteudoConfiguracao(string chave) {
            return string.IsNullOrEmpty(_arquivoConfiguracao.AppSettings.Settings[chave].Value) == false;
        }
    }
}
