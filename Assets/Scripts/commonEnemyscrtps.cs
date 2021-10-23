using UnityEngine;

public class commonEnemyscrtps : MonoBehaviour
{

    public delegate void minustime();
    public static event minustime minustimeInfo;


    private bool istrigger = false;
    private Animator animator;

    private void OnTriggerEnter2D(Collider2D other)

    
    {
        if (other.CompareTag("Player")){
            istrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {

        if (other.CompareTag("Player")){
            istrigger = false;
        }

        
    }

    
    private void OnMouseOver() {
        
        istrigger = true;
    }

    private void OnMouseExit() {

        istrigger = false;
        
    }

    private void OnEnable() {
        Enemy.rightEnemyInfo += HidecEnemy;
        touchEnemyScript.enemyTouchkillinfo += HidecEnemy;
    }

    private void OnDisable() {
        Enemy.rightEnemyInfo -= HidecEnemy;
        touchEnemyScript.enemyTouchkillinfo -= HidecEnemy;
        
    }

    private void Start() {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(istrigger){
            if (Input.GetMouseButtonDown(0))
            {
                
                if(gameObject.tag == "CommonEnemy"){
                    // Score.timer -= 5;
                    // minustimeInfo();

                }
                
            }
        }


    }


    void HidecEnemy(){
        // animator.SetBool("Die",true);
        Destroy(gameObject);
        

    }


    
}
