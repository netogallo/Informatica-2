using System;
using System.Linq;
using Xunit;

namespace BinTreeTests
{
    public class BinTreeTests
    {
        [Fact]
        public void TestSuma()
        {
            IBinIntTree sut = new BinaryIntTree(
                5,
                new BinaryIntTree(4),
                new BinaryIntTree(
                    9,
                    new BinaryTree<int>(8),
                    null
                )
            );

            Assert.Equal(26, sut.Sumar());
        }

        [Fact]
        public void TestMin()
        {
            IBinIntTree sut = new BinaryIntTree(
                5
                , new BinaryTree<int>(1)
                , new BinaryIntTree(33));

            int min = sut.Menor();

            Assert.Equal(1, min);
        }

            [Fact]
        public void TestToArray()
        {
            IBinTree<int> sut = new BinaryIntTree(
                5
                , new BinaryTree<int>(1)
                , new BinaryIntTree(33));

            int[] actual = sut.ToArray();
            int[] expected = new int[]{33,5,1};

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestConcat()
        {
            int[] valores = new int[]{1,2,3};
            int[] valores2 = new int[]{4,5};

            int[] valores3 = valores.Concat(valores2).ToArray();

            Assert.Equal(valores3, new int[]{1,2,3,4,5});
        }

        [Fact]
        public void TestBinSearch()
        {
            string[] valores = new string[]{
                "valor",
                "casa",
                "test",
                "azul"};

            IBinTree<string> arbol = new BinaryTree<string>(
                "mama",
                StringUtils.Comparar);

            foreach(string valor in valores)
            {
                arbol.Insert(valor);
            }

            Assert.Equal(
                "casa",
                arbol.BinarySearch("casa"));
        }

        [Fact]
        public void TestInsert()
        {
            string[] valores = new string[]{
                "valor",
                "casa",
                "test",
                "azul"};

            IBinTree<string> arbol = new BinaryTree<string>("mama", StringUtils.Comparar);

            foreach(string valor in valores)
            {
                arbol.Insert(valor);
            }

            string[] resultado = arbol.ToArray();

            for(int i = 0; i < resultado.Length - 1; i++)
            {
                Assert.True(
                    StringUtils.Comparar(resultado[i], resultado[i+1])
                );
            }
        }
    }

    
}
