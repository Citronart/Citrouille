using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static int scorePoint;
    public static int numberToCheck = 1;
    public int MaxScore;
    public Text ScoreText;

    void Update(){
        ScoreText.text = "Longueur du cou :" + scorePoint + "m";    
    }


    
}
