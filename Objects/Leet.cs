using System.Collections.Generic;

namespace LeetConverter.Objects

{
  public class Leet
  {
    public string T0L33t(string phraseToConvert)
    {
      string outputPhrase = phraseToConvert;
      outputPhrase = outputPhrase.Replace('e', '3').Replace('E', '3').Replace('o', '0').Replace('O', '0').Replace('I', '1');
      return outputPhrase;
    }
  }
}
