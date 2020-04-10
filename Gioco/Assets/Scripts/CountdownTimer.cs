using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CountdownTimer : MonoBehaviour
{
    private float timer = 5f;
    private Text timerSeconds;
    public GameObject youWinPanel;

    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");
        if(timer <= 0)
        {
            youWinPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void BackMenu()
    {
        youWinPanel.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenù");
    }
}
