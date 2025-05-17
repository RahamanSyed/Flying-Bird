using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{    public Text HighScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HighScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Hard()
    {
        SceneManager.LoadScene(2);
    }
    public void Exit()
    {
        Application.Quit();
    }
    
}
