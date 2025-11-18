public class SpeedBoost : IPowerUp
{
    private float amount;

    public SpeedBoost(float amount)
    {
        this.amount = amount;
    }

    public void Apply(PlayerPowerup player)
    {
        player.speed += amount;
    }

    public void Remove(PlayerPowerup player)
    {
        player.speed -= amount;
    }
}
