namespace Patterns.Strategy.Warriors;

public abstract class Warrior : IWarrior
{
    private readonly IWeapon weapon;

    protected Warrior(IWeapon weapon)
    {
        this.weapon = weapon;
    }

    public string Fight() => weapon.UseWeapon();
}