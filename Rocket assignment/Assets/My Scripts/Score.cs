using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public static Score instance;
    public Text scoretext;

    public int score = 0;

    private void Awake()
    {
        instance = this;
    }

    public void AddPoint()
    {
        score++;
        scoretext.text = score.ToString() + " POINTS";
    }
}
