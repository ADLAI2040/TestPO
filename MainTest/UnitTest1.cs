using Main;
namespace MainTests;

public class UnitTest1
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// 1.1

    [Theory]
    [InlineData(new int[] { }, 0, 0, new int[] { })]
    [InlineData(new int[] { 0, 20, -16, 100, -800 }, 0, 4, new int[] { -800, -16, 0, 20, 100 })]
    [InlineData(new int[] { 2 }, 0, 0, new int[] { 2 })]
    [InlineData(new int[] { -4, -50, 0, -3, -500 }, 0, 4, new int[] { -500, -50, -4, -3, 0 })]
    [InlineData(new int[] { 64, 255, 64, 83, 1 }, 0, 4, new int[] { 1, 64, 64, 83, 255 })]
    public void Test_MergeSort(int[] array, int lowIndex, int highIndex, int[] correctArr)
    {
        Assert.Equal(correctArr, Class1.MergeSort(array, lowIndex, highIndex));
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// 1.2

    [Theory]
    [InlineData("qwerty", false)]
    [InlineData(" ", true)]
    [InlineData("", true)]
    [InlineData("qwertytrewq", true)]
    [InlineData("AfCfA", true)]
    public void Test_Palindrome(string str, bool correct)
    {
        Assert.Equal(correct, Class1.checkStrPalindrome(str));
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// 1.3

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(-100, -1)]
    [InlineData(10, 3628800)]
    [InlineData(15, -1)]
    public void Test_Factorial(int value, int correctvalue)
    {
        Assert.Equal(correctvalue, Class1.factorialOfNumber(value));
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// 1.4

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 0)]
    [InlineData(-100, 0)]
    [InlineData(10, 34)]
    [InlineData(15, 377)]
    public void Test_Fibonacci(int value, int correctPosition)
    {
        Assert.Equal(correctPosition, Class1.numFibonacciAtPosition(value));
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// 1.5

    [Theory]
    [InlineData("qwerty", "er", true)]
    [InlineData("qwerty", "ui", false)]
    [InlineData(" ", "qwe", false)]
    [InlineData("qwerty", "", false)]
    [InlineData("qwerty", " ", false)]
    public void Test_Find_In_String(string str, string word, bool correct)
    {
        Assert.Equal(correct, Class1.findWordInStr(str, word));
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// 1.6

    [Theory]
    [InlineData(1, false)]
    [InlineData(0, false)]
    [InlineData(-100, false)]
    [InlineData(4703, true)]
    [InlineData(151231234, false)]
    public void Test_Is_Simple(int value, bool correct)
    {
        Assert.Equal(correct, Class1.chkNumIsSimple(value));
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// 1.7

    [Theory]
    [InlineData("0", 0)]
    [InlineData("-1", -1)]
    [InlineData("-100", -1)]
    [InlineData("1023", 3201)]
    [InlineData("-5423000", -3245)]
    [InlineData("2147483648123123", 0)]
    public void Test_Revers_Number(string value, int correctvalue)
    {
        Assert.Equal(correctvalue, Class1.reverseNum(value));
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// 1.8
    [Theory]
    [InlineData(0, "N")]
    [InlineData(4583, "MMMMDLXXXIII")]
    [InlineData(-100, "Num is negative, please write positive num")]
    [InlineData(18, "XVIII")]
    [InlineData(2375, "MMCCCLXXV")]
    public void Test_Convert_To_Roman(int value, string correct)
    {
        Assert.Equal(correct, Class1.numToRoman(value));
    }

}