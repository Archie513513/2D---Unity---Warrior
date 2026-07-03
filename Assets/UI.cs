using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI killCountText;
    [SerializeField] private GameObject gameOverUI;


    private int killCount;
    public static UI instance;


    private void Awake()
    {
        instance = this;
        Time.timeScale = 1;
    }


    private void Update()
    {
        timerText.text = Time.time.ToString("F2") + "s";



    }

    public void EnablegameOverUI()
    {
        Time.timeScale = .5f;
        gameOverUI.SetActive(true);
    }


    public void RestartLevel()
    { 
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(sceneIndex);


    }


    public void AddKillCount()
    {
        killCount++;
        killCountText.text = killCount.ToString();
    }
}


