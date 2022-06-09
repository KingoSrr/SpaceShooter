using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonationAlerts : MonoBehaviour
{
    public void DonationAlertsOpen()
    {
        if(Sound.SoundMode == true)
        {
            AudioSource SoundBtn = GetComponent<AudioSource>();
            SoundBtn.Play();
        }
        Application.OpenURL("https://www.donationalerts.com/r/kingosr");
    }
}
