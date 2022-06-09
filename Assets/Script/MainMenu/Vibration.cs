using UnityEngine;
using UnityEngine.UI;

public class Vibration : MonoBehaviour
{
    public static bool VibrationMode;
    int VibrationModeInt;
    public Sprite VibrationOnImage;
    public Sprite VibrationOffImage;
    void Start()
    {
        LoadGame();
        if(VibrationModeInt == 1)
        {
            GetComponent<Image>().sprite = VibrationOnImage;
            VibrationMode = true;
        }
        if(VibrationModeInt == 0)
        {
            GetComponent<Image>().sprite = VibrationOffImage;
            VibrationMode = false;
        }
    }
    public void VibrationSwitch()
    {
        if(Sound.SoundMode == true)
        {
            AudioSource SoundBtn = GetComponent<AudioSource>();
            SoundBtn.Play();
        }
        VibrationMode = !VibrationMode;
        if(VibrationMode == true)
        {
            GetComponent<Image>().sprite = VibrationOnImage;
            VibrationModeInt = 1;
        }
        if(VibrationMode == false)
        {
            GetComponent<Image>().sprite = VibrationOffImage;
            VibrationModeInt = 0;
        }
        SaveGame();
    }
    void SaveGame()
    {
        string key = "VibrationMode";   
        PlayerPrefs.SetInt(key, this.VibrationModeInt);
        PlayerPrefs.Save();
        Debug.Log("Saving Successful");
    }
    void LoadGame()
    {
        string key = "VibrationMode";
        if (PlayerPrefs.HasKey(key)) 
        {
            this.VibrationModeInt = PlayerPrefs.GetInt(key);
        }
    }
}
