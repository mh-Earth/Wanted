using UnityEngine;

public class touchEnemyScript : MonoBehaviour
{
    private Animator animator;

    private bool idFirst = true;
    public delegate void enemyTouchkill();
    public static event enemyTouchkill enemyTouchkillinfo;
    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }


    private void OnMouseOver()
    {

        // Debug.Log(gameObject.tag);
        if (gameObject.tag == "Enemy")
        {
            if (Input.GetMouseButtonDown(0))
            {

                animator.SetBool("Die", true);
                Destroy(gameObject, 0.4f);
                if (enemyShawner.enemyNumber < 320)
                {
                    enemyShawner.enemyNumber += 20;

                }
                Score.playerScore += 1;
                Score.timer += 5;
                if (enemyTouchkillinfo != null)
                {
                    enemyTouchkillinfo();
                    // #######################

                }



            }
        }

    }
}