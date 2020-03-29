using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSound : MonoBehaviour
{
    public void goSound()
    {
        SceneManager.LoadScene("Sound");
    }
}
