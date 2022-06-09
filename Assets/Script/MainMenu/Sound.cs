using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public static bool SoundMode;
    int SoundModeInt;
    public Sprite SoundOnImage;
    public Sprite SoundOffImage;
    void Start()
    {
        LoadGame();
        if(SoundModeInt == 1)
        {
            GetComponent<Image>().sprite = SoundOnImage;
            SoundMode = true;

            AudioSource AS = Camera.main.GetComponent<AudioSource>();
            AS.Play();
        }
        if(SoundModeInt == 0)
        {
            GetComponent<Image>().sprite = SoundOffImage;
            SoundMode = false;

            AudioSource AS = Camera.main.GetComponent<AudioSource>();
            AS.Pause();
        }
    }
    public void SoundSwitch()
    {
        if(SoundMode == true)
        {
            AudioSource SoundBtn = GetComponent<AudioSource>();
            SoundBtn.Play();            
        }
        SoundMode = !SoundMode;;
        if(SoundMode == true)
        {
            GetComponent<Image>().sprite = SoundOnImage;
            SoundModeInt = 1;

            AudioSource AS = Camera.main.GetComponent<AudioSource>();
            AS.Play();
        }
        if(SoundMode == false)
        {
            GetComponent<Image>().sprite = SoundOffImage;
            SoundModeInt = 0;

            AudioSource AS = Camera.main.GetComponent<AudioSource>();
            AS.Pause();
        }
        SaveGame();
    }
    void SaveGame()
    {
        string key = "SoundMode";   
        PlayerPrefs.SetInt(key, this.SoundModeInt);
        PlayerPrefs.Save();
        Debug.Log("Saving Successful");
    }
    void LoadGame()
    {
        string key = "SoundMode";
        if (PlayerPrefs.HasKey(key)) 
        {
            this.SoundModeInt = PlayerPrefs.GetInt(key);
        }
    }
}
