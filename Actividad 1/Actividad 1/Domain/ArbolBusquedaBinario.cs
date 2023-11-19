using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1.Domain
{
    public class ArbolBusquedaBinario
    {
        private NodoArbol raiz;

        public void Insertar(Libro libro)
        {
            if (raiz == null)
            {
                raiz = new NodoArbol() { Libro = libro };
            }
            else
            {
                Insertar(raiz, libro);
            }
        }
        public void Insertar(NodoArbol nodo, Libro libro)
        {
            if (libro.ISBN.CompareTo(nodo.Libro.ISBN) < 0)
            {
                if (nodo.Izquierdo == null)
                {
                    nodo.Izquierdo = new NodoArbol() { Libro = libro };
                }
                else
                {
                    Insertar(nodo.Izquierdo, libro);
                }
            }
            else
            {
                if (nodo.Derecho == null)
                {
                    nodo.Derecho = new NodoArbol() { Libro = libro };
                }
                else
                {
                    Insertar(nodo.Derecho, libro);
                }
            }
        }

        public void Eliminar(string isbn)
        {
            if (raiz == null)
            {
                return;
            }
            else
            {
                Eliminar(raiz, isbn);
            }
        }
        public NodoArbol Eliminar(NodoArbol nodo, string isbn)
        {
            if (nodo == null)
            {
                return null;
            }
            else if (isbn.CompareTo(nodo.Libro.ISBN) < 0)
            {
                nodo.Izquierdo = Eliminar(nodo.Izquierdo, isbn);
            }
            else if (isbn.CompareTo(nodo.Libro.ISBN) > 0)
            {
                nodo.Derecho = Eliminar(nodo.Derecho, isbn);
            }
            else
            {
                if (nodo.Izquierdo == null)
                {
                    return nodo.Derecho;
                }
                else if (nodo.Derecho == null)
                {
                    return nodo.Izquierdo;
                }
                NodoArbol secesor = ObtenerSucesor(nodo.Derecho);
                nodo.Libro = secesor.Libro;
                nodo.Derecho = Eliminar(nodo.Derecho, secesor.Libro.ISBN);
            }

            return nodo;
        }
        public NodoArbol ObtenerSucesor(NodoArbol nodo)
        {
            NodoArbol current = nodo;
            while (current.Izquierdo != null)
            {
                current = current.Izquierdo;
            }
            return current;
        }

        public Libro buscar(string isbn)
        {
            if (raiz == null)
            {
                return null;
            }
            else
            {
                return buscar(raiz, isbn);
            }
        }

        public Libro buscar(NodoArbol nodo, string isbn)
        {
            if (nodo.Libro.ISBN == isbn)
            {
                return nodo.Libro;
            }
            else if (isbn.CompareTo(nodo.Libro.ISBN) < 0)
            {
                if (nodo.Izquierdo == null)
                {
                    return null;
                }
                else
                {
                    return buscar(nodo.Izquierdo, isbn);
                }
            }
            else
            {
                if (nodo.Derecho == null)
                {
                    return null;
                }
                else
                {
                    return buscar(nodo.Derecho, isbn);
                }
            }
        } 

        public List<Libro> InOrden()
        {
            List<Libro> libros = new List<Libro>();
            InOrden(raiz, libros);
            return libros;
        }
        public void InOrden(NodoArbol nodo, List<Libro> libros)
        {
            if (nodo == null)
            {
                return;
            }
            else
            {
                InOrden(nodo.Izquierdo, libros);
                libros.Add(nodo.Libro);
                InOrden(nodo.Derecho, libros);
            }
        }

        public string Listar()
        {
            List<Libro> catalogo = InOrden();
            StringBuilder sb = new StringBuilder();
            foreach (var libro in catalogo)
            {
                sb.AppendLine(libro.ToString());
            }
            return sb.ToString();
        }

        public string ListarInOrder()
        {
            List<Libro> catalogo = InOrden();
            StringBuilder sb = new StringBuilder();
            foreach (var libro in catalogo)
            {
                sb.AppendLine(libro.ToString());
            }
            return sb.ToString();
        }

    }
}
