using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int PlayerScore;
    public Text ScoreText;
    public GameObject GameOverScreen;
    public AudioSource sfx;
    public AudioClip Point;

    [ContextMenu("increaseScore")]

    public void AddScore(int ScoreToAdd)
    {
        PlayerScore += ScoreToAdd;
        ScoreText.text = PlayerScore.ToString();
        sfx.clip = Point;
        sfx.Play();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
