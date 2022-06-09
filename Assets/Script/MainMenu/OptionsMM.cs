using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMM : MonoBehaviour
{
    public GameObject StartBtn;
    public GameObject OptionsBtn;
    public GameObject ExitBtn;
    public GameObject OptionsPanel;
    public void Options()
    {
        StartBtn.SetActive(false);
        OptionsBtn.SetActive(false);
        ExitBtn.SetActive(false);
        OptionsPanel.SetActive(true);
    }
}
