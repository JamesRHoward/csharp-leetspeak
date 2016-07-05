using System.Collections.Generic;

namespace Leet.Objects

{
  public class Leet
  {
    public string T0L33t(string phraseToConvert)
    {
      if ((!phraseToConvert.toLower().contains('e')) || (!phraseToConvert.toLower().contains('E')) || (!phraseToConvert.toLower().contains('s')) || (!phraseToConvert.toLower().contains('I')) || (!phraseToConvert.toLower().contains('O')) || (!phraseToConvert.toLower().contains('o')))
      {
        return phraseToConvert;
      } else
      {
        return "Rock Lobster!";
      }
    }
  }
}
