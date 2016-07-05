using Xunit;
using LeetConverter.Objects;
using System.Collections.Generic;

namespace LeetConverter
{
  public class LeetTest
  {
    [Fact]
    public void Leet_ForNonaffectedString_SelfUnchanged()
    {
      Leet testLeet = new Leet();
      Assert.Equal("Alf hunt fat cat. Mmm.", testLeet.T0L33t("Alf hunt fat cat. Mmm."));
    }
    [Fact]
    public void Leet_ForAnyLetterE_ChangeTo3()
    {
      Leet testLeet = new Leet();
      Assert.Equal("Alf hunt fat cat. Alf 3at. Mmm.", testLeet.T0L33t("Alf hunt fat cat. Alf eat. Mmm."));
    }
  }
}
