using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestExamples.Test
{
    public class MathematicsTest
    {


        [Fact]
        public void SubtractTest()
        {
            #region Arrange 
            int number1 = 10;
            int number2 = 20;
            int expected = 10;

            var containsValues = new[] { 3, 5, 7, 10 };
            var doesNotContainsValues = new[] { 2, 4, 6 };

            var emptyCollection = new List<object>();
            var notEmptyCollection = new List<object>() { 32, 13, 1453 };

            Mathematics mathematics = new Mathematics();
            #endregion

            #region Act 
            int? result = mathematics.Subtract(number1, number2);
            #endregion

            #region Assert 

            #region Equal
            //Assert.Equal(expected, result);
            #endregion

            #region Contains
            //Assert.Contains<int>(containsValues, value => value == result);
            //Assert.DoesNotContain<int>(doesNotContainsValues, value => value == result);
            #endregion

            #region True/False
            //Assert.True(result < 10);
            //Assert.False(result >= 10);
            #endregion

            #region Match/DoesNotMatch 
            Assert.Matches("sa{2}t", "saat");
            Assert.DoesNotMatch("sa{2}t", "muiddin");
            #endregion

            #region StartsWith/EndsWith
            //Assert.StartsWith("U", "UnitTest"); 
            //Assert.EndsWith("t", "UnitTest");
            #endregion

            #region Empty/NotEmpty 
            //Assert.Empty(emptyCollection);
            //Assert.NotEmpty(notEmptyCollection);
            #endregion

            //if array is empty ,test throw false
            #region Single
            //Assert.Single(emptyCollection);
            #endregion

            #region IsType/IsNotType
            //Assert.IsType<int>(result);
            //Assert.IsNotType<string>(result);
            #endregion

            #region IsAssignableFrom
            //Assert.IsAssignableFrom<object>(result);
            //or
            //var collection = new List<object>();
            //Assert.IsAssignableFrom<IEnumerable<object>>(result);
            #endregion

            #region Null/NotNull	
            //Assert.Null(result);
            Assert.NotNull(result);
            #endregion

            #endregion
        }

        //This data must be static
        public static IEnumerable<object[]> sumDatas => new List<object[]>
        {
            new object[]{ 3, 5, 8 },
            new object[]{ 11, 5, 16 },
            new object[]{ 23, 2, 25 },
            new object[]{ 33, 44, 87 }
        };

        [Theory]
        //[InlineData(3, 5, 8)] //can be used
        [MemberData(nameof(sumDatas))]
        public void SumTest(int num1, int num2, int expected)
        {
            #region Arrange
            Mathematics mathematics = new Mathematics();
            #endregion
            #region Act
            int result = mathematics.Sum(num1, num2);
            #endregion

            #region Assert
            Assert.Equal(expected, result);
            #endregion
        }

        public class Datas
        {
            public static IEnumerable<object[]> sumDatas => new List<object[]>
            {
                new object[]{ 3, 5, 8 },
                new object[]{ 11, 5, 16 },
                new object[]{ 23, 2, 25 },
                new object[]{ 33, 44, 87 }
            };
        }

        [Theory]
        [MemberData(nameof(Datas.sumDatas), MemberType = typeof(Datas))]
        public void SumTest2(int number1, int number2, int expected)
        {
            #region Arrange
            Mathematics mathematics = new Mathematics();
            #endregion
            #region Act
            int result = mathematics.Sum(number1, number2);
            #endregion
            #region Assert
            Assert.Equal(expected, result);
            #endregion
        }

        //This Case, return one result for all parameters. 
        [Theory]
        [MemberData(nameof(Datas.sumDatas), MemberType = typeof(Datas), DisableDiscoveryEnumeration = true)]
        public void SumTest3(int number1, int number2, int expected)
        {
            #region Arrange
            Mathematics mathematics = new Mathematics();
            #endregion
            #region Act
            int result = mathematics.Sum(number1, number2);
            #endregion
            #region Assert
            Assert.Equal(expected, result);
            #endregion
        }
    }
}
