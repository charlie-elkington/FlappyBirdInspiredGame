using Unity.VisualScripting;
using UnityEngine;

public class BULLYScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float FlapStrength;
    public LogicScript logic;
    public bool BirdIsAlive = true;
    public AudioSource Sound, Bckgrnd;
    public AudioClip Jump, Death, BackgroundMusic;
    public float LowestY = -35, HighestX = 32;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Bckgrnd.clip = BackgroundMusic;
        Bckgrnd.loop = true;
        Bckgrnd.Play();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && BirdIsAlive == true)
        {
            myRigidbody.linearVelocity = Vector2.up * FlapStrength;
            Sound.clip = Jump;
            Sound.Play();
        }
        
        if ((transform.position.y > HighestX || transform.position.y < LowestY) && BirdIsAlive == true)
        {
            DeathScreen();
        }
        
    }

    private void DeathScreen()
    {
         logic.GameOver();
        BirdIsAlive = false;
        Sound.clip = Death;
        Sound.Play();
        Bckgrnd.Stop();
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (BirdIsAlive == true)
        {
            DeathScreen();
        }
       
    }
}
