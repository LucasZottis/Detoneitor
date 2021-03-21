using BibliotecaPublica.Classes.Estaticas;
using BibliotecaPublica.Classes.Gerenciadores;
using Detoneitor.Planejeitor.Janelas;
using System;
using System.Windows.Forms;

namespace Detoneitor.Planejeitor {
    static class Program {
        private static readonly string _sChaveDia = "Dia";
        private static readonly string _sChaveCaminhoPasta = "CaminhoPasta";

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormPlanejeitor planejeitor = new FormPlanejeitor();
            GerenciadorConfiguracao configurador = new GerenciadorConfiguracao();

            // Verifica se tem a configuração Dia.
            if (!configurador.VerificarConfiguracao(_sChaveDia))
                configurador.CriarConfiguracao(_sChaveDia, null);

            // Verifica se tem a configuração CaminhoPasta.
            if (!configurador.VerificarConfiguracao(_sChaveCaminhoPasta))
                configurador.CriarConfiguracao(_sChaveCaminhoPasta, null);

            // Passa as configurações para o formulário.
            planejeitor.Dia = configurador.BuscarConfiguracao(_sChaveDia);
            planejeitor.CaminhoPasta = configurador.BuscarConfiguracao(_sChaveCaminhoPasta);

            Application.Run(planejeitor);
        }
    }
}