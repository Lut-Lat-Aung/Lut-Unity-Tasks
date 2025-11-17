using UnityEngine;

public class UnityAudioSystem : IAudioSystem
{
    public void PlaySound(string soundName)
    {
        Debug.Log($"Playing sound: {soundName}");
    }

    public void PlayMusic(string musicName)
    {
        Debug.Log($"Playing music: {musicName}");
    }

    public void StopMusic()
    {
        Debug.Log("Stopping music.");
    }
}
