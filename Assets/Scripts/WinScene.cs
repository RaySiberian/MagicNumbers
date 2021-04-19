using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScene : MonoBehaviour
{
    public Text finalText;
    private MagicNumbers MN;
    void Start()
    {
        MN = FindObjectOfType<MagicNumbers>();
        finalText.text = MN.actionsText.text;
    }
}
