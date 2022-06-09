using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMM : MonoBehaviour
{
    public void ExitBtn()
    {
        if(Sound.SoundMode == true)
        {
            AudioSource SoundBtn = GetComponent<AudioSource>();
            SoundBtn.Play();
        }        
        Application.Quit();
    }
}
