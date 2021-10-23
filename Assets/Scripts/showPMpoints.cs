using UnityEngine;

public class showPMpoints : MonoBehaviour
{

    [SerializeField]
    private GameObject addImage;
    [SerializeField]
    private GameObject minusImage;
    [SerializeField]
    private GameObject addobjectPoint;

    private GameObject addMunisObject;
    // Start is called before the first frame update
    private void OnEnable() {
        Enemy.rightEnemyInfo += addTime;
        commonEnemyscrtps.minustimeInfo += minustime5;
    }

    private void OnDisable() {

        Enemy.rightEnemyInfo -= addTime;

        commonEnemyscrtps.minustimeInfo -= minustime5;
        
    }
    void Start()
    {
        
    }



    public void addTime(){
        // Vector3 imagePosition = Input.mousePosition;
        // imagePosition.y += 1;
        addMunisObject = Instantiate(addImage);
        addMunisObject.transform.localScale = new Vector3(1.5f,1.5f,0f);
        addMunisObject.transform.position = addobjectPoint.transform.position;
        Destroy(addMunisObject,1f);


    }

    public void minustime5(){
        addMunisObject = Instantiate(minusImage);
        addMunisObject.transform.localScale = new Vector3(1.5f,1.5f,0f);
        addMunisObject.transform.position = addobjectPoint.transform.position;
        Destroy(addMunisObject,1f);



    }
}
