using Xunit;

namespace WordFrequency
{
  public class WordFrequencyTests
  {
    [Fact]
    public void CountRepeats__a_I__0()
    {
      //Arrange/Act
      int expected = 0;
      int repeatNumber = RepeatCounter.CountRepeats("a","I");

      //Assert
      Assert.Equal(expected, repeatNumber);
    }
  }
}
