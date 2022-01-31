using Patterns.Strategy.Warriors;

namespace Patterns.Strategy.Warriors_anti;

public class King : IWarrior
{
    public string Fight() => "Stab";
}