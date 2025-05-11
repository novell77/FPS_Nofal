
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public Text healthText;
    public GameObject gameOverPanel;
    public GameObject winPanel;

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    public void UpdateHealth(int health)
    {
        healthText.text = "Health: " + health;
    }

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void ShowWin()
    {
        winPanel.SetActive(true);
    }
}
