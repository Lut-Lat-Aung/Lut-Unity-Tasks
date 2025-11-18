using Unity.VisualScripting;

public class ShieldPowerUp : IPowerUp
{
    private float shieldAmount;

    public ShieldPowerUp(float shieldAmount)
    {
        this.shieldAmount = shieldAmount;
    }

    public void Apply(PlayerPowerup player)
    {
        player.Shield += shieldAmount;
    }

    public void Remove(PlayerPowerup player)
    {
        player.Shield -= shieldAmount;
    }
}
