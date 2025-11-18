using UnityEngine;

public class UI_GameManagerButtons : MonoBehaviour
{
    public void AddScore()
    {
        GameManager.Instance.AddScore(10);
    }

    public void SaveGame()
    {
        GameManager.Instance.SaveProgress();
    }

    public void LoadGame()
    {
        GameManager.Instance.LoadProgress();
    }
}
