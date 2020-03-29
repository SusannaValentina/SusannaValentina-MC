using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToOptions : MonoBehaviour
{
    public void backToMenu()
    {
        SceneManager.LoadScene("Options");
    }
}
