﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScript : MonoBehaviour
{
    public void backToMenu()
    {
        SceneManager.LoadScene("MainMenù");
        Time.timeScale = 1f;
    }
}
