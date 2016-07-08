namespace WordFrequency
{
  public static class RepeatCounter
  {
    public static int CountRepeats(string searchTerm, string searchedString)
    {
      int count = 0;
      for(int i=0; i<searchedString.Length; i++)
      {
        string chunk = searchedString.Substring(i,1);
        if(searchTerm==chunk)
        {
          count ++;
        }
      }
      return count;
    }
  }
}
