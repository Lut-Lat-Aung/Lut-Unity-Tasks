using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    private PlayerPowerup player;
    private IEffectTimer timer;
    private List<IPowerUp> activePowerUps = new List<IPowerUp>();

    public void Init(PlayerPowerup player, IEffectTimer timerService)
    {
        this.player = player;
        this.timer = timerService;
    }

    public void ActivatePowerUp(IPowerUp powerUp, float duration)
    {
        powerUp.Apply(player);
        activePowerUps.Add(powerUp);

        timer.StartTimer(duration, () =>
        {
            powerUp.Remove(player);
            activePowerUps.Remove(powerUp);
        });
    }
}
