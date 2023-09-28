using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SceneManagement;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public GameObject startButton;
    public GameObject player;
    public TMP_Text gameOverCountdown;
    public float countTimer = 5f;

    // Start is called before the first frame update
    void Start()
    {
        startButton.SetActive(true);
        gameOverCountdown.gameObject.SetActive(false);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gameOverCountdown.text = "Restarting in  " + countTimer;
        if (countTimer < 0)
        {
            RestartGame();
        }
    }

    public void StartGame()
    {
        startButton.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        EditorSceneManager.LoadScene(0);
    }
}
