using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    static MiniGameManager miniGameManager;
    public static MiniGameManager Instance { get { return miniGameManager; } }

    private int currentScore = 0;

    UIManager uiManager;

    public string MainScene = "MainScene";

    private bool isGameStarted = false;
    public bool IsGameStarted => isGameStarted;
   

    public UIManager UIManager { get { return uiManager; } }
    private void Awake()
    {
        miniGameManager = this;
        uiManager = FindObjectOfType<UIManager>();
    }

    public void StartGame()
    {
        isGameStarted = true;
        uiManager.UpdateScore(0);
        uiManager.HideButtons();

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if(player !=null)
        {
            player.GetComponentInChildren<Player>().Activate();
        }
    }
    public void GameOver()
    {
        uiManager.SetRestart();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //public void ExitToMainScene()
    //{
    //    SceneManager.LoadScene(MainScene);
    //}

    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
        Debug.Log("Score : " + currentScore);
    }

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        uiManager.OnClickExitButton();
    //    }
    //}
}
