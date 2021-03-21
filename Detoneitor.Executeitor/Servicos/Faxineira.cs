using System.IO;

namespace Detoneitor.Executeitor.Servicos {
    static class Faxineira {
        public static void LimparPasta(string caminho) {
            DirectoryInfo pastaRaiz = new DirectoryInfo(caminho);
            DirectoryInfo[] subPastas = pastaRaiz.GetDirectories();
            FileInfo[] arquivos = pastaRaiz.GetFiles();

            foreach (DirectoryInfo pasta in subPastas) {
                pasta.Delete(true);
            }

            foreach (FileInfo arquivo in arquivos) {
                arquivo.Delete();
            }
        }
    }
}
