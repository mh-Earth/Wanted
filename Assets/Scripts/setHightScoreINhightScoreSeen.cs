using UnityEngine;
using TMPro;
public class setHightScoreINhightScoreSeen : MonoBehaviour
{       
    [SerializeField]

    private TextMeshProUGUI hightScoreText;
    private int hightScore;
    // Start is called before the first frame update
    void Start()
    {
        hightScore = PlayerPrefs.GetInt("HightSore");
        hightScoreText.text = "Hight Score:"+ hightScore;
    }

}
