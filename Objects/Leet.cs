using System.Collections.Generic;
using System.Text;

namespace LeetConverter.Objects

{
  public class Leet
  {
    public string T0L33t(string phraseToConvert)
    {
      string outputPhrase = phraseToConvert;
      outputPhrase = outputPhrase.Replace('e', '3').Replace('E', '3').Replace('o', '0').Replace('O', '0').Replace('I', '1');
      // outputPhrase = outputPhrase.Replace('z', '`').Replace('s', 'z').Replace(' z', 's').Replace('`', 'z');
      var foundIndexes = new List<int>();
      for (int i = outputPhrase.IndexOf('s'); i > -1; i = outputPhrase.IndexOf('s', i + 1))
      {
              foundIndexes.Add(i);
      }
      if (foundIndexes.Count != 0)
      {
        foreach (int index in foundIndexes)
        {
          StringBuilder sb = new StringBuilder(outputPhrase);
          if ( index != 0 && sb[index-1] != ' ')
          {
          sb[index] = 'z';
          }
          outputPhrase = sb.ToString();
        }
      }


      return outputPhrase;
    }
  }
}
