using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    public GameObject panelVictory;
    // Start is called before the first frame update
    void Start()
    {
        panelVictory.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            panelVictory.SetActive(true);
        }
    }
}
