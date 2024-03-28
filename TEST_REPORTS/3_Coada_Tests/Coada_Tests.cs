using GENERIC_COLLECTIONS;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace TEST_REPORTS
{
    public class Coada_Tests
    {
        private readonly ITestOutputHelper outputHelper;
        private Coada<string> coada;

        public Coada_Tests(ITestOutputHelper output)
        {
            this.outputHelper = output;
            this.coada = new Coada<string>();
        }

        [Fact]
        public void push_pop()
        {
            for (int i = 1; i <= 4; i++)
                this.coada.push($"{i}");
            Assert.True(this.coada.size() == 4);
            for (int i = 1; i <= 4; i++)
                Assert.True(this.coada.pop().Data == $"{i}");
            Assert.True(this.coada.isEmpty() == true);
        }

        [Fact]
        public void peek()
        {
            for (int i = 1; i <= 4; i++)
                this.coada.push($"{i}");
            Assert.True(this.coada.size() == 4);
            for (int i = 1; i <= 4; i++)
            {
                Assert.True(this.coada.peek().Data == $"{i}");
                Assert.True(this.coada.pop().Data == $"{i}");
            }
            Assert.True(this.coada.isEmpty() == true);
        }

        [Fact]
        public void exist()
        {
            for (int i = 1; i <= 4; i++)
                this.coada.push($"{i}");
            Assert.True(this.coada.size() == 4);
            for (int i = 1; i <= 4; i++)
                Assert.True(this.coada.exist($"{i}"));
            Assert.False(this.coada.exist("5"));
            for (int i = 1; i <= 4; i++)
                Assert.True(this.coada.pop().Data == $"{i}");
            Assert.True(this.coada.isEmpty() == true);
        }

        [Fact]
        public void size()
        {
            for (int i = 1; i <= 4; i++)
                this.coada.push($"{i}");
            Assert.True(this.coada.size() == 4);
            for (int i = 1; i <= 4; i++)
                Assert.True(this.coada.pop().Data == $"{i}");
            Assert.True(this.coada.size() == 0);
        }

        [Fact]
        public void golireLista()
        {
            for (int i = 1; i <= 4; i++)
                this.coada.push($"{i}");
            Assert.True(this.coada.size() == 4);
            this.coada.clear();
            Assert.True(this.coada.size() == 0);
        }

        [Fact]
        public void isEmpty()
        {
            for (int i = 1; i <= 4; i++)
                this.coada.push($"{i}");
            Assert.True(this.coada.isEmpty() == false);
            for (int i = 1; i <= 4; i++)
                Assert.True(this.coada.pop().Data == $"{i}");
            Assert.True(this.coada.isEmpty() == true);
        }

        [Fact]
        public void afisare()
        {
            for (int i = 1; i <= 4; i++)
                this.coada.push($"{i}");
            Assert.True(this.coada.size() == 4);
            this.outputHelper.WriteLine(this.coada.afisare());
            for (int i = 1; i <= 4; i++)
                Assert.True(this.coada.pop().Data == $"{i}");
            Assert.True(this.coada.isEmpty() == true);
            this.outputHelper.WriteLine(this.coada.afisare());
        }
    }
}
