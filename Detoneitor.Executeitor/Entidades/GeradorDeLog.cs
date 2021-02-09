using System;
using System.Security.AccessControl;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detoneitor.Executeitor.Entidades {
    class GeradorDeLog {
        private FileStream Log;
        public string Pasta { get; private set; }
        public string Nome { get; private set; }

        public GeradorDeLog(string pasta, string nome) {
            Pasta = pasta;
            Nome = nome;
            Log = File.OpenWrite(pasta + nome);
        }

        public void Escrever(string entrada) {
            using (StreamWriter escritor = new StreamWriter(Log)) {
                escritor.WriteLine(entrada);
                
                escritor.AutoFlush = true;
            }
        }
    }
}
