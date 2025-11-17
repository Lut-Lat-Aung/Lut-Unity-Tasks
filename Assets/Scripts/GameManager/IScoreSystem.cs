public interface IScoreSystem
{
    int CurrentScore { get; }
    void AddScore(int amount);
    void ResetScore();
}
