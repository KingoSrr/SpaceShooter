using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void ToMenuBtn()
    {
        if(Sound.SoundMode == true)
        {
            GameObject BtnClick = GameObject.FindGameObjectWithTag("BtnClick");
            AudioSource AS = BtnClick.GetComponent<AudioSource>();
            AS.Play();
        }
        SceneManager.LoadScene("MainMenu");
    }
}
