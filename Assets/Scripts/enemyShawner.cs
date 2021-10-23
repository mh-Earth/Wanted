using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] enemyList;
    [SerializeField]
    private GameObject posterEnemy;
    private float randomX;
    private float randomY;

    private GameObject spawnerEnemy;
    [SerializeField]
    public static int enemyNumber = 20;


    private int randomEnemy;
    void Start()
    {
        selctEnamy();
        enemyShawnper(enemyNumber);
        // Debug.Log(enemyNumber);
        
    }

    private void OnEnable() {
        Enemy.rightEnemyInfo += addEnemise;
        touchEnemyScript.enemyTouchkillinfo += addEnemise;
    }

    private void OnDisable() {
        Enemy.rightEnemyInfo -= addEnemise;
        touchEnemyScript.enemyTouchkillinfo -= addEnemise;
        
    }


    public void enemyShawnper(int enemyNum)
    {
        
            for (int i = 0; i < enemyNum; i++)
            {

            randomX = Random.Range(-5.5f, 8f);
            randomY = Random.Range(-4.2f, 4.2f);
            int randomIndex = Random.Range(0,4);
            if (randomIndex != randomEnemy){
                spawnerEnemy = Instantiate(enemyList[randomIndex]);
                spawnerEnemy.transform.position = new Vector3(randomX,randomY,0f);
                spawnerEnemy.AddComponent<commonEnemyscrtps>();
                // spawnerEnemy.AddComponent<touchEnemyScript>();

                spawnerEnemy.tag = "CommonEnemy";


            }
                

            }
    }

    public void selctEnamy(){

        randomEnemy = Random.Range(0,4);
        spawnerEnemy = Instantiate(enemyList[randomEnemy]);
        spawnerEnemy.transform.position = posterEnemy.transform.position;
        spawnerEnemy.AddComponent<commonEnemyscrtps>();


        float randomX = Random.Range(-5.5f, 8.5f);
        float randomY = Random.Range(-4.2f, 4.2f);
            
        spawnerEnemy = Instantiate(enemyList[randomEnemy]);
        spawnerEnemy.transform.position = new Vector3(randomX,randomY,0f);
        spawnerEnemy.AddComponent<Enemy>();
        // spawnerEnemy.AddComponent<touchEnemyScript>();
        spawnerEnemy.GetComponent<SpriteRenderer>().sortingOrder = 5;
        spawnerEnemy.tag = "Enemy";
        // spawnerEnemy.AddComponent<Score>();
        // enemyList.R        


    }


    void addEnemise(){
        selctEnamy();
        enemyShawnper(enemyNumber);
        
    }

}
