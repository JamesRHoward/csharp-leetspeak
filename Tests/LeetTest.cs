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
    public void Leet_ForAnyLetterE_ChangeToThree()
    {
      Leet testLeet = new Leet();
      Assert.Equal("Alf hunt fat cat. Alf 3at. Mmm.", testLeet.T0L33t("Alf hunt fat cat. Alf eat. Mmm."));
    }
    [Fact]
    public void Leet_ForAnyLetterO_ChangeToZero()
    {
      Leet testLeet = new Leet();
      Assert.Equal("Alf hunt fat p00dl3. Alf 3at. Mmm.", testLeet.T0L33t("Alf hunt fat poodle. Alf eat. Mmm."));
    }
    [Fact]
    public void Leet_ForAnyCapitalI_ChangeToOne()
    {
      Leet testLeet = new Leet();
      Assert.Equal("Alf hunt fat p00dl3. Alf 3at. Mmm. Th3n 1 at3 Alf. 1t was d3lici0us.", testLeet.T0L33t("Alf hunt fat poodle. Alf eat. Mmm. Then I ate Alf. It was delicious."));
    }
  }
}
