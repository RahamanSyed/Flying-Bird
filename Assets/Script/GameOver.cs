using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{   public Text scoreText;
    public Text highScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   private void OnEnable() 
   {
        int score = ScoreCounter.score;
        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore",score);
            highScoreText.text = score.ToString();
        }    
        else
        {
            highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
        scoreText.text = score.ToString();
   }
   public void Retry()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
   public void Menu()
   {
        SceneManager.LoadScene(0);
   }
   public void Pause()
   {
        Time.timeScale = 0;
   }
    public void Resume()
   {
        Time.timeScale = 1;
   }
}
