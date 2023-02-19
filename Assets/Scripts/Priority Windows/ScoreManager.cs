using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private CanvasHandler canvasHandler;
    [SerializeField] private TextMeshProUGUI scoreText;
    private void Awake()
    {
        canvasHandler = GameObject.FindGameObjectWithTag("Canvas").GetComponent<CanvasHandler>();
    }

    private void Update()
    {
        //scoreText.text = "Score: " + canvasHandler.currentScore.ToString("0");
    }

}
