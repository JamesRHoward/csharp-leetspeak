using Xunit;
using Leet.Objects;
using System.Collections.Generic;

namespace Leet
{
  public class LeetTest
  {
    [Fact]
    public void Let_ForNonaffectedString_SelfUnchanged()
    {
      Leet testLeet = new Leet();
      Assert.Equal("Alf hunt fat cat. Mmm.", testLeet.T0L33t("Alf hunt fat cat. Mmm."));
    }
    }
  }
}
