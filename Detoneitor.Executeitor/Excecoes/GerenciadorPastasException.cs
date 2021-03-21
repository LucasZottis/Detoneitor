using System;
using System.Runtime.Serialization;

namespace Detoneitor.Executeitor.Excecoes {
    class GerenciadorPastasException : Exception {
        public GerenciadorPastasException() { }

        public GerenciadorPastasException(string message) : base(message) { }

        public GerenciadorPastasException(string message, Exception innerException) : base(message, innerException) { }

        protected GerenciadorPastasException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
