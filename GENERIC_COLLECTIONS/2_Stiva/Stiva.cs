using System;
using System.Collections.Generic;
using System.Text;

namespace GENERIC_COLLECTIONS
{
    public class Stiva<T> where T : IComparable<T>
    {
        private Lista<T> lista;

        public Stiva()
        {
            this.lista = new Lista<T>();
        }

        public void push(T data)
        {
            this.lista.adaugareSfarsit(data);
        }

        public Nod<T> pop()
        {
            if (this.isEmpty() == false)
            {
                Nod<T> nod = this.lista.obtine(this.lista.dimensiune() - 1);
                this.lista.stergerePozitie(this.lista.dimensiune() - 1);
                return nod;
            }
            throw new Exception();
        }

        public Nod<T> peek() => this.lista.obtine(this.lista.dimensiune() - 1);

        public bool exist(T data) => this.lista.exista(data);

        public int size() => this.lista.dimensiune();

        public void clear() => this.lista.golireLista();

        public bool isEmpty() => this.lista.listaGoala();

        public string afisare() => this.lista.afisare();

        public Lista<T> Lista
        {
            get => this.lista;
            set => this.lista = value;
        }
    }
}
