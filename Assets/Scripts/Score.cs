using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Text hightscoreText;
    [SerializeField]
    private Text Timer;
    private int hightScore;
    public static int playerScore;
    public static int timer = 60;
    public static int timerLatency;

    void Start()
    {
        hightScore = PlayerPrefs.GetInt("HightSore");
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Kills:" + playerScore.ToString();

        if(playerScore >= hightScore){

            PlayerPrefs.SetInt("HightSore",playerScore);

        }
        hightscoreText.text = "Hight Score:" + hightScore.ToString();

        if(timerLatency >= 25){

            timer -= 1;
            timerLatency = 0;
            

        }

        timerLatency += 1;
        
        Timer.text = "Time:" + timer.ToString();


        if(timer < 1){
            SceneManager.LoadScene("Game Over");

            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }
}
