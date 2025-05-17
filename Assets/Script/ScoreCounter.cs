using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{   public static int score;
    public Text scoreText;
    public SoundManager SM;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.CompareTag("counter"))
        {
            SM.Play_Point();
            score++;
            scoreText.text = score.ToString();
        }
    }
}
