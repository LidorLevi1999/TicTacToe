using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private static MenuManager Instance;
    internal int GameMethod; // 1 for PVP , 2 for PVC
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
    }

    public void OnGameMethodSelected(int method)
    {
        GameMethod = method;
        SceneManager.LoadScene(1);
    }
}
