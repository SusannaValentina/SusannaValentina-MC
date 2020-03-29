using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectScript : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Start":
                SceneManager.LoadScene("Level1");
                break;
            case "Options":
                SceneManager.LoadScene("Options");
                break;
            case "Credits":
                SceneManager.LoadScene("Credits");
                break;
            case "Exit":
                SceneManager.LoadScene("Exit");
                break;
        }
    }
    
}
