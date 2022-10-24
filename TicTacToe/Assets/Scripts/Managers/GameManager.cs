using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

[Serializable]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public GameObject MenuView;

    public GameObject GameView;

    private bool isPvP; 
    
    internal int DifficultyLevel;

    public List<GameObject> Buttons;

    public Sprite X;

    public Sprite C;

    public bool Player1IsX;

    private List<int> Map; // 0 - empty , 1 - X , 2 - C
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    public void OnGameMethodSelected(bool PvP)
    {
        isPvP = PvP;
        MenuView.SetActive(false);
        GameView.SetActive(true);
        Player1IsX = Random.Range(0, 2) == 0;
        Map = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    }

    public void OnButtonSelected(int index)
    {
        if (Map[index] == 0)
        {
            Map[index] = Player1IsX ? 1 : 2;
            Buttons[index].GetComponent<Image>().sprite = Player1IsX ? X : C;
            Buttons[index].GetComponent<Button>().interactable = false;
        }
        else
        {
            Debug.Log("This Button is already selected");
        }
    }
}
