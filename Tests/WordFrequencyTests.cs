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

    [Fact]
    public void CountRepeats__a_Iwouldlikeahotdog__1()
    {
      //Arrange/Act
      int repeatNumber = RepeatCounter.CountRepeats("a","I would like a hot dog.");
      int expected = 1;
      //Assert
      Assert.Equal(expected, repeatNumber);
    }

    [Fact]
    public void CountRepeats__a_Iamahotdog__1()
    {
      //Arrange/Act
      int repeatNumber = RepeatCounter.CountRepeats("a","I am a hot dog.");
      int expected = 1;
      //Assert
      Assert.Equal(expected, repeatNumber);
    }
    //////Extra Test Not in Specs: Will it find words on the ends?/Will it find multiple words?////
    [Fact]
    public void CountRepeats__a_ahotdogama__2()
    {
      //Arrange/Act
      int repeatNumber = RepeatCounter.CountRepeats("a","a hot dog am a");
      int expected = 2;
      //Assert
      Assert.Equal(expected, repeatNumber);
    }

    [Fact]
    public void CountRepeats__am_Iamaprogrammer__1()
    {
      //Arrange/Act
      int repeatNumber = RepeatCounter.CountRepeats("am","I am a programmer.");
      int expected = 1;
      //Assert
      Assert.Equal(expected, repeatNumber);
    }
    //////Extra Test Not in Specs: Will it work for search terms longer than searched string////
    [Fact]
    public void CountRepeats__programmer_I__0()
    {
      //Arrange/Act
      int repeatNumber = RepeatCounter.CountRepeats("programmer","I");
      int expected = 0;
      //Assert
      Assert.Equal(expected, repeatNumber);
    }

    [Fact]
    public void CountRepeats__am_thisiswhatIamCOLONaprogrammer__1()
    {
      //Arrange/Act
      int repeatNumber = RepeatCounter.CountRepeats("am","This is what I am: a programmer.");
      int expected = 1;
      //Assert
      Assert.Equal(expected, repeatNumber);
    }

    [Fact]
    public void CountRepeats__am_AmIaprogrammer__1()
    {
      //Arrange/Act
      int repeatNumber = RepeatCounter.CountRepeats("am","Am I a programmer?");
      int expected = 1;
      //Assert
      Assert.Equal(expected, repeatNumber);
    }

    [Fact]
    public void CountRepeats__thatAPOSTROPHEs_thatAPOSTROPHEswhatIam__1()
    {
      //Arrange/Act
      int repeatNumber = RepeatCounter.CountRepeats("that's","That's what I am.");
      int expected = 1;
      //Assert
      Assert.Equal(expected, repeatNumber);
    }

    [Fact]
    public void CountRepeats__amwhat_IamwhatIam__1()
    {
      //Arrange/Act
      int repeatNumber = RepeatCounter.CountRepeats("am what","I am what I am.");
      int expected = 1;
      //Assert
      Assert.Equal(expected, repeatNumber);
    }
  }
}
