using UnityEngine;

public class Enemy : MonoBehaviour
{   

    private bool collaid = false;
    private float afterCollaitionaimSize = .7f;
    private float beforeCollaitionaimSize = .8f;
    // Start is called before the first frame update
    // [SerializeField]
    // private EnemyShawner = new enemyShawner();
    private Animator animator;
    public delegate void rightEnemy();
    public static event rightEnemy rightEnemyInfo;

    private void Start() {
        // sr = aim.GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        // animator.SetBool("Stands",true);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {   
            other.gameObject.transform.localScale = new Vector3(afterCollaitionaimSize,afterCollaitionaimSize,afterCollaitionaimSize);
            collaid = true;
            // sr.sprite = radaim;

        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        
        if(other.CompareTag("Player"))
        {   
            other.gameObject.transform.localScale = new Vector3(beforeCollaitionaimSize,beforeCollaitionaimSize,beforeCollaitionaimSize);
            Debug.Log("collaid");
            // sr.sprite = greenaim;
            collaid = false;
        }
    
    }


    private void aimCollaid(){
        if (collaid){
            if(Input.GetMouseButtonDown(0)){
                
                animator.SetBool("Die",true);
                Destroy(gameObject,0.4f);
                if(enemyShawner.enemyNumber < 320){
                    enemyShawner.enemyNumber += 20;

                }
                Score.playerScore += 1;
                Score.timer += 5;
                if(rightEnemyInfo != null){
                    rightEnemyInfo();
                    // #######################

                }

                // if(Input.GetKeyDown(KeyCode.S)){

                //     if(rightEnemyInfo != null){
                //         if(enemyShawner.enemyNumber < 320){
                //             enemyShawner.enemyNumber += 40;

                //         }
                //         rightEnemyInfo();

                //     }

                // }
                
                
            }            

        }

    }



        
    


    private void Update() {
        aimCollaid();
        // Debug.Log(enemyShawner.enemyNumber);
    }

}
