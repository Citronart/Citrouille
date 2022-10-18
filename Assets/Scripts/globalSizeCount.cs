using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class globalSizeCount : MonoBehaviour
{
    public static int neckLength;
    public GameObject neckDisplay;
    public int InternalLength;
    void Update()
    {
        InternalLength = neckLength;
        neckDisplay.GetComponent<Text>().text = "Length: " + InternalLength;
    }
}
