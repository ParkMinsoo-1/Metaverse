using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameTrigger : MonoBehaviour
{
    private bool isPlayerTrigger = false;
    public string MiniGameScene = "MiniGameScene";
    public string MainScene = "MainScene";

    public GameObject TextUI;

    void Update()
    {
        if(isPlayerTrigger && Input.GetKeyDown(KeyCode.F))
        {
               SceneManager.LoadScene(MiniGameScene);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerTrigger = true;
             
            if(TextUI != null)
            {
                TextUI.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerTrigger = false;

            if (TextUI != null)
            {
                TextUI.SetActive(false);
            }
        }
    }
}
