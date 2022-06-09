using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMM : MonoBehaviour
{
    public GameObject StartBtn;
    public GameObject OptionsBtn;
    public GameObject ExitBtn;
    public GameObject OptionsPanel;
    public void OptionsClose()
    {
        StartBtn.SetActive(true);
        OptionsBtn.SetActive(true);
        ExitBtn.SetActive(true);
        OptionsPanel.SetActive(false);
    }
}
