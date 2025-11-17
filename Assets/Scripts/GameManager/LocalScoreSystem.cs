using UnityEngine;
public class LocalScoreSystem : IScoreSystem
{
    private int score = 0;

    public int CurrentScore => score;

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log($"Score added. New score = {score}");
    }

    public void ResetScore()
    {
        score = 0;
        Debug.Log("Score reset.");
    }
}
