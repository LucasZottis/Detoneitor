using System;
using System.Runtime.Serialization;

namespace Detoneitor.Executeitor.Excecoes {
    class GerenciadorDePastaException : Exception {
        public GerenciadorDePastaException() { }

        public GerenciadorDePastaException(string message) : base(message) { }

        public GerenciadorDePastaException(string message, Exception innerException) : base(message, innerException) { }

        protected GerenciadorDePastaException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
