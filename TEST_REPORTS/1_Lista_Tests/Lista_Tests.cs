using GENERIC_COLLECTIONS;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace TEST_REPORTS
{
    public class Lista_Tests
    {
        private readonly ITestOutputHelper outputHelper;
        private ILista<string> lista;

        public Lista_Tests(ITestOutputHelper output)
        {
            this.outputHelper = output;
            lista = new Lista<string>();
        }

        [Fact]
        public void adaugareSfarsit_stergereData()
        {
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareSfarsit($"{i}");
            Assert.True(this.lista.dimensiune() == 4);
            this.outputHelper.WriteLine(this.lista.afisare());
            for (int i = 1; i <= 4; i++)
                Assert.Equal(this.lista.obtine(i - 1).Data, i.ToString());
            for (int i = 1; i <= 4; i++)
            {
                this.lista.stergereData(i.ToString());
                Assert.False(this.lista.exista(i.ToString()));
            }
            Assert.True(this.lista.listaGoala() == true);
        }

        [Fact]
        public void adaugareInceput_stergereData()
        {
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareInceput($"{i}");
            Assert.True(this.lista.dimensiune() == 4);
            this.outputHelper.WriteLine(this.lista.afisare());
            for (int i = 1; i <= 4; i++)
                Assert.Equal(this.lista.obtine(4-i).Data, i.ToString());
            for (int i = 1; i <= 4; i++)
            {
                this.lista.stergereData(i.ToString());
                Assert.False(this.lista.exista(i.ToString()));
            }
            Assert.True(this.lista.listaGoala() == true);
        }

        [Fact]
        public void adaugareSfarsit_stergerePozitie()
        {
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareSfarsit($"{i}");
            Assert.True(this.lista.dimensiune() == 4);
            this.outputHelper.WriteLine(this.lista.afisare());
            for (int i = 1; i <= 4; i++)
                Assert.Equal(this.lista.obtine(i - 1).Data, i.ToString());
            for (int i = 1; i <= 4; i++)
            {
                this.lista.stergerePozitie(0);
                Assert.False(this.lista.exista(i.ToString()));
            }
            Assert.True(this.lista.listaGoala() == true);
        }

        [Fact]
        public void adaugareInceput_stergerePozitie()
        {
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareInceput($"{i}");
            Assert.True(this.lista.dimensiune() == 4);
            this.outputHelper.WriteLine(this.lista.afisare());
            for (int i = 1; i <= 4; i++)
                Assert.Equal(this.lista.obtine(4-i).Data, i.ToString());
            for (int i = 4; i >= 1; i--)
            {
                this.lista.stergerePozitie(0);
                Assert.False(this.lista.exista(i.ToString()));
            }
            Assert.True(this.lista.listaGoala() == true);
        }

        [Fact]
        public void adaugarePozitie_stergere()
        {
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareSfarsit($"{i}");
            Assert.True(this.lista.dimensiune() == 4);
            for (int i = 1; i <= 4; i++){
                this.lista.adaugarePozitie("9", i - 1);
                Assert.True(this.lista.obtine(i - 1).Data == "9");
                this.lista.stergereData(this.lista.obtine(i - 1).Data);
                Assert.False(this.lista.obtine(i - 1).Data == "9");
                Assert.True(this.lista.obtine(i - 1).Data == $"{i}");
            }
            Assert.False(this.lista.listaGoala() == true);
            for (int i = 1; i <= 4; i++)
                this.lista.stergereData(this.lista.obtine(0).Data);
            Assert.True(this.lista.listaGoala() == true);
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareSfarsit($"{i}");
            this.lista.adaugarePozitie("9", this.lista.dimensiune());
            Assert.True(this.lista.obtine(this.lista.dimensiune() - 1).Data == "9");
            for (int i = 1; i <= 5; i++)
                this.lista.stergereData(this.lista.obtine(0).Data);
            Assert.True(this.lista.listaGoala() == true);
        }

        [Fact]
        public void modificareData()
        {
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareSfarsit($"{i}");
            Assert.True(this.lista.dimensiune() == 4);
            for (int i = 4; i >= 1; i--)
                this.lista.modificareData($"{i}", $"{i + 1}");
            for (int i = 1; i <= 4; i++)
                Assert.True(this.lista.obtine(i - 1).Data == $"{i + 1}");
            for (int i = 1; i <= 4; i++)
                this.lista.stergereData($"{i + 1}");
            Assert.True(this.lista.listaGoala() == true);
        }

        [Fact]
        public void modificarePozitie()
        {
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareSfarsit($"{i}");
            Assert.True(this.lista.dimensiune() == 4);
            for (int i = 1; i <= 4; i++)
                this.lista.modificarePozitie(i-1, $"{i+1}");
            for (int i = 1; i <= 4; i++)
                Assert.True(this.lista.obtine(i - 1).Data == $"{i + 1}");
            for (int i = 1; i <= 4; i++)
                this.lista.stergerePozitie(0);
            Assert.True(this.lista.listaGoala() == true);
        }

        [Fact]
        public void obtine()
        {
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareSfarsit($"{i}");
            Assert.True(this.lista.dimensiune() == 4);
            for (int i = 1; i <= 4; i++)
                Assert.True(this.lista.obtine(i - 1).Data == $"{i}");
            for (int i = 1; i <= 4; i++)
                Assert.False(this.lista.obtine(i - 1).Data == $"{4-i+1}");
            for (int i = 1; i <= 4; i++)
                this.lista.stergereData($"{i}");
            Assert.True(this.lista.listaGoala() == true);
        }

        [Fact]
        public void exista()
        {
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareSfarsit($"{i}");
            Assert.True(this.lista.dimensiune() == 4);
            for (int i = 1; i <= 4; i++)
                Assert.True(this.lista.exista($"{i}") == true);
            Assert.True(this.lista.exista("5") == false);
            for (int i = 1; i <= 4; i++)
                this.lista.stergereData($"{i}");
            Assert.True(this.lista.listaGoala() == true);
        }

        [Fact]
        public void listaGoala()
        {
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareSfarsit($"{i}");
            Assert.True(this.lista.listaGoala() == false);
            for (int i = 1; i <= 4; i++)
                this.lista.stergereData($"{i}");
            Assert.True(this.lista.listaGoala() == true);
        }

        [Fact]
        public void dimensiune()
        {
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareSfarsit($"{i}");
            Assert.True(this.lista.dimensiune() == 4);
            for (int i = 1; i <= 4; i++)
                this.lista.stergereData($"{i}");
            Assert.True(this.lista.dimensiune() == 0);
        }

        [Fact]
        public void golireLista()
        {
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareSfarsit($"{i}");
            Assert.True(this.lista.dimensiune() == 4);
            this.lista.golireLista();
            Assert.True(this.lista.dimensiune() == 0);
        }

        [Fact]
        public void pozitieData()
        {
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareSfarsit($"{i}");
            Assert.True(this.lista.dimensiune() == 4);
            for (int i = 1; i <= 4; i++)
                Assert.True(this.lista.pozitieData($"{i}") == i - 1);
            for (int i = 1; i <= 4; i++)
                this.lista.stergereData($"{i}");
            Assert.True(this.lista.listaGoala() == true);
        }

        [Fact]
        public void sortare()
        {
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareSfarsit($"{i}");
            Assert.True(this.lista.dimensiune() == 4);
            this.lista.sortare(new ComparerTest(), -1);
            for (int i = 1; i <= 4; i++)
                Assert.True(this.lista.obtine(i - 1).Data == $"{5 - i}");
            for (int i = 1; i <= 4; i++)
                this.lista.stergereData($"{i}");
            Assert.True(this.lista.listaGoala() == true);
            for (int i = 4; i >= 1; i--)
                this.lista.adaugareSfarsit($"{i}");
            Assert.True(this.lista.dimensiune() == 4);
            this.lista.sortare(new ComparerTest(), 1);
            for (int i = 1; i <= 4; i++)
                Assert.True(this.lista.obtine(i - 1).Data == $"{i}");
            for (int i = 1; i <= 4; i++)
                this.lista.stergereData($"{i}");
            Assert.True(this.lista.listaGoala() == true);
        }

        [Fact]
        public void afisare()
        {
            for (int i = 1; i <= 4; i++)
                this.lista.adaugareSfarsit($"{i}");
            Assert.True(this.lista.dimensiune() == 4);
            this.outputHelper.WriteLine(this.lista.afisare());
            for (int i = 1; i <= 4; i++)
                this.lista.stergereData($"{i}");
            Assert.True(this.lista.listaGoala() == true);
        }
    }
}
