using BibliotecaPublica.Classes.Gerenciadores;
using Detoneitor.Aplicativo.Janelas;
using System;
using System.IO;
using System.Windows.Forms;

namespace Detoneitor.Aplicativo {
    static class Program {
        public static readonly string Planejeitor = @"\Planejeitor.exe";
        public static readonly string Executeitor = @"\Executeitor.exe";

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormDetoneitor detoneitor = new FormDetoneitor();
            GerenciadorConfiguracao configurador;

            string sPastaRaiz = Environment.CurrentDirectory;
#if DEBUG
            sPastaRaiz = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
#endif

            detoneitor.PastaRaiz = sPastaRaiz;
            configurador = new GerenciadorConfiguracao(sPastaRaiz + Planejeitor);

            if (configurador.VerificarConfiguracao("CaminhoPasta"))
            {
                detoneitor.PastaAlvo = configurador.BuscarConfiguracao("CaminhoPasta");
            }

            Application.Run(detoneitor);
        }
    }
}
