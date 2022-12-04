using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMN : MonoBehaviour
{
    [SerializeField] Button pause, restart;
    [SerializeField] GameObject panel;
    [SerializeField] Text score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AddEvent();
    }

    void AddEvent()
    {
        pause.onClick.AddListener(delegate
        {
            PauseGame();
        });
        restart.onClick.AddListener(delegate
        {
            RestartGame();
        });
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
    }    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }    
}
