public class DamageBoost : IPowerUp
{
    private float amount;

    public DamageBoost(float amount)
    {
        this.amount = amount;
    }

    public void Apply(PlayerPowerup player)
    {
        player.damage += amount;
    }

    public void Remove(PlayerPowerup player)
    {
        player.damage -= amount;
    }
}
