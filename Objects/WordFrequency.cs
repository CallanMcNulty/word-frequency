using System;

namespace WordFrequency
{
  public static class RepeatCounter
  {
    private static char[] wordChars = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
    public static int CountRepeats(string searchTerm, string searchedString)
    {
      int count = 0;
      for(int i=0; i<searchedString.Length; i++)
      {
        string chunk = searchedString.Substring(i,1);
        char preChunk = i==0 ? ' ' : searchedString[i-1];
        char postChunk = i+chunk.Length>=searchedString.Length ? ' ' : searchedString[i+chunk.Length];
        bool chunkIsWord = Array.IndexOf(wordChars,preChunk)==-1 && Array.IndexOf(wordChars,postChunk)==-1;
        if(searchTerm==chunk && chunkIsWord)
        {
          count ++;
        }
      }
      return count;
    }
  }
}
