using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject OptionsPanel;
    public void OptionsBtn()
    {
        MenuPanel.SetActive(false);
        OptionsPanel.SetActive(true);
    }
}
