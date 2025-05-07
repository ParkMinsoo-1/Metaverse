using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI restartText;

    public Button startButton;
    public Button exitButton;
    public string MainScene = "MainScene";

    public void Start()
    {
        restartText.gameObject.SetActive(false);

        if (startButton != null) 
        {
            startButton.onClick.AddListener(OnClickStartButton);
        }

        if(exitButton != null)
        {
            exitButton.onClick.AddListener(OnClickExitButton);
        }
    }

    public void OnClickStartButton()
    {
        MiniGameManager.Instance.StartGame();
    }

    public void OnClickExitButton()
    {
        SceneManager.LoadScene(MainScene);
    }

    public void SetRestart()
    {
        restartText.gameObject.SetActive(true);
        if (startButton != null)
            startButton.gameObject.SetActive(true);
        if (exitButton != null)
            exitButton.gameObject.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void HideButtons()
    {
        if (startButton != null)
            startButton.gameObject.SetActive(false);
        if (exitButton != null)
            exitButton.gameObject.SetActive(false);
    }

}
