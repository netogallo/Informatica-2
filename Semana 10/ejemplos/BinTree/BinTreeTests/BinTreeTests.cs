using System;
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
    }
}
