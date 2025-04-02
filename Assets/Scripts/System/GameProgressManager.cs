using UnityEngine;

public class GameProgressManager : MonoBehaviour
{
    public static GameProgressManager Instance;
    public int currentLevel = 1;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AdvanceLevel()
    {
        currentLevel++;
        Debug.Log("Advanced to level: " + currentLevel);
    }

    public bool HasUnlocked(int levelRequired)
    {
        return currentLevel >= levelRequired;
    }
}
