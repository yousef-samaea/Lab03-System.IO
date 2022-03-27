using System;
using Xunit;
using ProblemDomain;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            String[] arr1 = { "1", "2", "3"};
            String[] arr2 = { "1", "2", "3", "4" };
            String[] arr3 = { "1", "2" };
            String[] arr4 = { "-1", "-2", "-3" };
            Assert.Equal(6, Program.Multiplied2(arr1));
            Assert.Equal(6, Program.Multiplied2(arr2));
            Assert.Equal(0, Program.Multiplied2(arr3));
            Assert.Equal(-6, Program.Multiplied2(arr4));
        }

        [Fact]
        public void Test2()
        {
            int[] arr1 = { 9, 9, 9, 9, 9 };
            int[] arr2 = { 1, 2, 3, 4, 5 };
            int[] arr3 = { 1, 2, 3 };
            Assert.Equal(9, Program.calAverage(arr1));
            Assert.Equal(15, Program.calAverage(arr2));
            Assert.Equal(2, Program.calAverage(arr3));
        }
        [Fact]
        public void Test4()
        {
            Assert.Equal(77, Program.appears(new int[] { 77, 77, 55, 7, 85, 2, 77, 9 }));
            Assert.Equal(5, Program.appears(new int[] { 12, 44, 5, 3, 74, 5, }));
            Assert.Equal(22, Program.appears(new int[] { 125, 4, 98, 5, 22, 24, 22, 22, 19, 16 }));

        }

        [Fact]
        public void Test5()
        {
            Assert.Equal(-5, Program.MaxNumber(new int[] { -5, -7, -12, -15, -19 }));
            Assert.Equal(-66, Program.MaxNumber(new int[] { 4, 8, 9, 13, 66 }));
            Assert.Equal(5, Program.MaxNumber(new int[] { 5, 5, 5, 5, 5 }));
        }

        [Fact]
        public void Test9()
        {
            string x = "yousef";
            string y = "yousef samara";
            string[] arr1 = { "yousef:6," };
            string[] arr2 = { "yousef:6,", "samara:6,"};
            Assert.Equal(arr1, Program.WordsCauntar(x));
            Assert.Equal(arr2, Program.WordsCauntar(y));
        }



    }
}
