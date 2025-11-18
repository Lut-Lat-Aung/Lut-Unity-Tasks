using UnityEngine;

public class PowerUpTest : MonoBehaviour
{
    private PowerUpManager powerUpManager;
    public PlayerPowerup player;
    public UnityEffectTimer timerService;
    public Weapon tempWeapon;

    void Start()
    {

        powerUpManager.ActivatePowerUp(new SpeedBoost(5f), 5f);
        powerUpManager.ActivatePowerUp(new DamageBoost(10f), 8f);
        powerUpManager.ActivatePowerUp(new ShieldPowerUp(50f), 10f);
        powerUpManager.ActivatePowerUp(new TemporaryWeapon(tempWeapon), 6f);
    }
}
