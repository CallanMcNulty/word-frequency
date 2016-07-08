namespace WordFrequency
{
  public static class RepeatCounter
  {
    public static int CountRepeats(string searchTerm, string searchedString)
    {
      if(searchTerm==searchedString)
      {
        return 1;
      }
      return 0;
    }
  }
}
