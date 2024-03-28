using GENERIC_COLLECTIONS;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace TEST_REPORTS
{
    public class Stiva_Tests
    {
        private readonly ITestOutputHelper outputHelper;
        private Stiva<string> stiva;

        public Stiva_Tests(ITestOutputHelper output)
        {
            this.outputHelper = output;
            this.stiva = new Stiva<string>();
        }

        [Fact]
        public void push_pop()
        {
            for (int i = 1; i <= 4; i++)
                this.stiva.push($"{i}");
            Assert.True(this.stiva.size() == 4);
            for (int i = 1; i <= 4; i++)
                Assert.True(this.stiva.pop().Data == $"{5 - i}");
            Assert.True(this.stiva.isEmpty() == true);
        }

        [Fact]
        public void peek()
        {
            for (int i = 1; i <= 4; i++)
                this.stiva.push($"{i}");
            Assert.True(this.stiva.size() == 4);
            for (int i = 1; i <= 4; i++)
            {
                Assert.True(this.stiva.peek().Data == $"{5 - i}");
                Assert.True(this.stiva.pop().Data == $"{5 - i}");
            }
            Assert.True(this.stiva.isEmpty() == true);
        }

        [Fact]
        public void exist()
        {
            for (int i = 1; i <= 4; i++)
                this.stiva.push($"{i}");
            Assert.True(this.stiva.size() == 4);
            for (int i = 1; i <= 4; i++)
                Assert.True(this.stiva.exist($"{i}"));
            Assert.False(this.stiva.exist("5"));
            for (int i = 1; i <= 4; i++)
                Assert.True(this.stiva.pop().Data == $"{5 - i}");
            Assert.True(this.stiva.isEmpty() == true);
        }

        [Fact]
        public void size()
        {
            for (int i = 1; i <= 4; i++)
                this.stiva.push($"{i}");
            Assert.True(this.stiva.size() == 4);
            for (int i = 1; i <= 4; i++)
                Assert.True(this.stiva.pop().Data == $"{5 - i}");
            Assert.True(this.stiva.size() == 0);
        }

        [Fact]
        public void isEmpty()
        {
            for (int i = 1; i <= 4; i++)
                this.stiva.push($"{i}");
            Assert.True(this.stiva.isEmpty() == false);
            for (int i = 1; i <= 4; i++)
                Assert.True(this.stiva.pop().Data == $"{5 - i}");
            Assert.True(this.stiva.isEmpty() == true);
        }

        [Fact]
        public void golireLista()
        {
            for (int i = 1; i <= 4; i++)
                this.stiva.push($"{i}");
            Assert.True(this.stiva.size() == 4);
            this.stiva.clear();
            Assert.True(this.stiva.size() == 0);
        }

        [Fact]
        public void afisare()
        {
            for (int i = 1; i <= 4; i++)
                this.stiva.push($"{i}");
            Assert.True(this.stiva.size() == 4);
            this.outputHelper.WriteLine(this.stiva.afisare());
            for (int i = 1; i <= 4; i++)
                Assert.True(this.stiva.pop().Data == $"{5 - i}");
            Assert.True(this.stiva.isEmpty() == true);
            this.outputHelper.WriteLine(this.stiva.afisare());
        }
    }
}
