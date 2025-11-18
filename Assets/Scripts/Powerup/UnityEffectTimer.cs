using UnityEngine;
using System.Collections;

public class UnityEffectTimer : MonoBehaviour, IEffectTimer
{
    public void StartTimer(float duration, System.Action onFinish)
    {
        StartCoroutine(Timer(duration, onFinish));
    }

    private IEnumerator Timer(float duration, System.Action onFinish)
    {
        yield return new WaitForSeconds(duration);
        onFinish?.Invoke();
    }
}
