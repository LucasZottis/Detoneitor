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

            detoneitor.PastaRaiz = Environment.CurrentDirectory;
            configurador = new GerenciadorConfiguracao(Environment.CurrentDirectory);

#if DEBUG
            detoneitor.PastaRaiz = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            configurador = new GerenciadorConfiguracao(Environment.GetCommandLineArgs()[0]);
#endif

            if (configurador.VerificarConfiguracao("CaminhoPasta"))
            {
                detoneitor.PastaAlvo = configurador.BuscarConfiguracao("CaminhoPasta");
            }

            Application.Run(detoneitor);
        }
    }
}
