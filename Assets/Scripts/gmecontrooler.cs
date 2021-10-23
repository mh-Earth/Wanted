using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class gmecontrooler : MonoBehaviour
{   
    [SerializeField]
    private TextMeshProUGUI hightScoreText;


    public void reload(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void reloadGameplay(){
        Score.playerScore = 0;
        Score.timer = 60;
        enemyShawner.enemyNumber = 20;
        SceneManager.LoadScene("Main Game");


    }
    public void Gameplay(){

        enemyShawner.enemyNumber = 20;
        Score.timer = 60;
        Score.playerScore = 0;
        SceneManager.LoadScene("Main Game");


    }
    public void GameOver(){
        
        // Cursor.visible = true;
        SceneManager.LoadScene("Game Over");
    }



    public void Home(){
        // Cursor.visible = true;

        SceneManager.LoadScene("Home");


    }

    public void Exit(){

        // SceneManager.LoadScene("Home");
        Application.Quit();


    }
    public void HightScore(){

        SceneManager.LoadScene("Hight Score");
        // Application.Quit();


    }

    public void Help(){

        SceneManager.LoadScene("Help");
        // Application.Quit();


    }

    public void resetHightScore(){

        PlayerPrefs.SetInt("HightSore",0);
        hightScoreText.text = "Hight Score:0";

        // SceneManager.LoadScene("Help");

        // Application.Quit();


    }




}
