using System;
using Devmedia.Estudo.Sample.Library;

namespace Devmedia.Estudo.Sample
{
    public class Livro
    {
        string titulo;
        public string Titulo
        {
            get {return titulo;}
            set {titulo = value;}
        }

        string autor;
        public string Autor
        {
            get {return autor;}
            set {autor = value;}
        }

        int anoPublicacao;
        public string AnoPublicacao
        {
            get {return autor;}
            set {autor = value;}
        }

        Biblioteca _biblioteca;
        public Biblioteca Biblioteca1
        {
            get { return _biblioteca; }
            set { _biblioteca = value; }
        }


    }
}
