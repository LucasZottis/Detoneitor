using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detoneitor.Aplicativo {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            Environment.CurrentDirectory;

            Application.Run(new FormDetoneitor());
        }
    }
}
