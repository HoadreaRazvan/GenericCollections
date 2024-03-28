using System;
using System.Collections.Generic;
using System.Text;

namespace GENERIC_COLLECTIONS
{
    public interface ILista<T>
    {
        void adaugareSfarsit(T data);
        void adaugareInceput(T data);
        void adaugarePozitie(T data, int index);

        void stergereData(T data);
        void stergerePozitie(int index);

        void modificareData(T dataInlocuit, T dataInlocuire);
        void modificarePozitie(int index, T dataInlocuire);

        Nod<T> obtine(int index);
        int pozitieData(T data);

        bool exista(T data);
        bool listaGoala();
        int dimensiune();
        void golireLista();

        void sortare(Comparer<T> comparator,int value);

        string afisare();  
    }
}
