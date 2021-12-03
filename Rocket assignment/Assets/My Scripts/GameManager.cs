using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject mainCanvas;
    public GameObject GameOverCanvas;
    private Health healthPlayer;

    public enum GameStates
    {
        Playing,
        Finished
    }

    public GameStates gameState = GameStates.Playing;

    // Start is called before the first frame update
    void Start()
    {
        healthPlayer = Player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameStates.Playing:
                if (!healthPlayer.isAlive)
                {
                    gameState = GameStates.Finished;
                    mainCanvas.SetActive(false);
                    GameOverCanvas.SetActive(true);
                }
                break;
        }
    }
}
