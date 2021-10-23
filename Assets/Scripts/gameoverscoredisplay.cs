using UnityEngine;
using TMPro;
public class gameoverscoredisplay : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private TextMeshProUGUI text;

    private void Start() {
        // Cursor.visible = true;
        
        text.text = "Score:"+Score.playerScore.ToString();

    }

}
