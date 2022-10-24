using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    private static MenuManager Instance;
    public Slider DifficultyLevelSlider;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    public void SetDifficultyLevel()
    {
        GameManager.Instance.DifficultyLevel = (int)DifficultyLevelSlider.value;
        Debug.Log("Selected Difficulty level is - " + GameManager.Instance.DifficultyLevel);
    }
}
