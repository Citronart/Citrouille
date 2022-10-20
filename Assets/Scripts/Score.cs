using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Mouvement mvt;
    
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.transform.tag == "Fruit")
        {
            mvt.AddScore();
            
        }
    }
}
