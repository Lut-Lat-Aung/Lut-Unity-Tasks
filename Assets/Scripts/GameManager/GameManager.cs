using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private IScoreSystem scoreSystem;
    private IAudioSystem audioSystem;
    private ISaveSystem saveSystem;

    private void Awake()
    {
        if (Instance == null) Instance = this;

        scoreSystem = new LocalScoreSystem();
        audioSystem = new UnityAudioSystem();
        saveSystem = new PlayerPrefsSaveSystem();
    }

    public void AddScore(int amount)
    {
        scoreSystem.AddScore(amount);
        audioSystem.PlaySound("ScoreUp");
    }

    public void SaveProgress()
    {
        saveSystem.Save("Score", scoreSystem.CurrentScore);
        Debug.Log("Progress Saved.");
    }

    public void LoadProgress()
    {
        int loadedScore = saveSystem.Load("Score");
        Debug.Log($"Progress Loaded: Score = {loadedScore}");
    }
}
