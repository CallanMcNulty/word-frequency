using Xunit;

namespace WordFrequency
{
  public class WordFrequencyTests
  {
    [Fact]
    public void CountRepeats__a_I__0()
    {
      //Arrange/Act
      int repeatNumber = RepeatCounter.CountRepeats("a","I");
      int expected = 0;
      //Assert
      Assert.Equal(expected, repeatNumber);
    }

    [Fact]
    public void CountRepeats__I_I__1()
    {
      //Arrange/Act
      int repeatNumber = RepeatCounter.CountRepeats("I","I");
      int expected = 1;
      //Assert
      Assert.Equal(expected, repeatNumber);
    }
  }
}
