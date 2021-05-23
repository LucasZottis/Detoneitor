using Detoneitor.Executeitor.Entidades;
using System.IO;

namespace Detoneitor.Executeitor.Servicos
{
    static class GeradorLog
    {
        public static void CriarArquivoLog(LogExcecao log, string caminho)
        {
            using (StreamWriter escritor = new StreamWriter(new FileStream(caminho + log.NomeLog, FileMode.Create)))
            {
                escritor.WriteLine(log.ToString());
            }
        }

        public static void CriarArquivoLog(LogExecucao log, string caminho)
        {
            using (StreamWriter escritor = new StreamWriter(caminho + log.NomeLog))
            {
                escritor.WriteLine(log.ToString());
            }
        }
    }
}