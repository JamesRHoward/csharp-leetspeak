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
      Assert.Equal("Alf hunt fat p00dl3. Alf 3at. Mmm. Th3n 1 at3 Alf.", testLeet.T0L33t("Alf hunt fat poodle. Alf eat. Mmm. Then I ate Alf."));
    }
    [Fact]
    public void Leet_ForNonWordBeginningLetterS_ChangeToZ()
    {
      Leet testLeet = new Leet();
      Assert.Equal("s0 l00k... Zap! Th3 spac3 z00k33p3r taz3r3d th3 ali3n z3bra at th3 galactic z00 0n Plan3t Zarg0n. 1 w3pt.", testLeet.T0L33t("so look... Zap! The space zookeeper tasered the alien zebra at the galactic zoo on Planet Zargon. I wept."));
    }
  }
}
