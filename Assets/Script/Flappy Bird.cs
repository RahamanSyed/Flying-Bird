using UnityEngine;

public class FlappyBird : MonoBehaviour
{   public SoundManager SM;
    public bool isDead = false;
    private Collider2D collider;
    private Animator anime;
    public float Speed = 10;
    Rigidbody2D RB;
    public GameObject GameOverScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && isDead == false)
        {
            SM.Play_Flap();
            RB.linearVelocity = Vector2.up * Speed;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) 
        {
            SM.Play_Hit();
            isDead = true;
            anime.Play("Die");
            GetComponent<Collider2D>().enabled = false;
            RB.linearVelocity = Vector2.up * Speed;
            GameOverScreen.SetActive(true);
        }
}
