using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class Lights : MonoBehaviour
{   
    [SerializeField]
    private GameObject globalLight;
    [SerializeField]
    private GameObject pointLight;
    void Update()

    {

        if(enemyShawner.enemyNumber > 400){
            Destroy(globalLight);
            pointLight.GetComponent<Light2D>().enabled = true;
        }
        
    }
}
