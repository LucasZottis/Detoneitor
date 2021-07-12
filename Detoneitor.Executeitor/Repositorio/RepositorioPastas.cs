using Detoneitor.Executeitor.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detoneitor.Executeitor.Repositorio
{
    class RepositorioPastas
    {
        #region Atributos

        private List<Pasta> _listaInterna = null;

        #endregion Atributos

        #region Propriedades

        public IList<Pasta> Pastas
        {
            get
            {
                if (_listaInterna == null)
                {
                    _listaInterna = new List<Pasta>();
                }

                return _listaInterna;
            }

            private set { }
        }

        public int Contagem
        {
            get
            {
                if (_listaInterna == null)
                {
                    _listaInterna = new List<Pasta>();
                }

                return _listaInterna.Count;
            }
        }

        #endregion Propriedades

        #region Construtores



        #endregion Construtores

        #region Métodos Públicos

        public void AdicionarPasta(Pasta pasta)
        {
            _listaInterna.Add(pasta);
        }

        public void RemoverPasta(Pasta pasta)
        {
            _listaInterna.Remove(pasta);
        }

        #endregion Métodos Públicos
    }
}