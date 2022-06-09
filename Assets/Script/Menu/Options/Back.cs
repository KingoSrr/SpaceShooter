using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject OptionsPanel;
    public void BackBtn()
    {
        MenuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
    }
}
