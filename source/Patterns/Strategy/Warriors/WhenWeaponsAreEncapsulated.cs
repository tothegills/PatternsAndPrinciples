using FluentAssertions;
using Xunit;

namespace Patterns.Strategy.Warriors;

public class WhenWeaponsAreEncapsulated
{
    [Fact]
    public void WarriorsCanUseWhateverWeaponTheyChoose()
    {
        var king = new King(new Knife());
        king.Fight().Should().Be("Stabby stab");
    }
}