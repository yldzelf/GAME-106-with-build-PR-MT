using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public GameObject theText;
    public GameObject thePanel;

    public void ClearText()
    {
        theText.GetComponent<InputField>().text = "";
    }

}
