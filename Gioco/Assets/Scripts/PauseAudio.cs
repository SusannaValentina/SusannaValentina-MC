using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAudio : MonoBehaviour
{
    public bool musicOn = true;

    // Start is called before the first frame update
    void Start()
    {
        if (musicOn)
        {
            DontDestroyAudio.Instance.gameObject.GetComponent<AudioSource>().Play();

        }
        else
        {
            DontDestroyAudio.Instance.gameObject.GetComponent<AudioSource>().Pause();

        }
    }
}
