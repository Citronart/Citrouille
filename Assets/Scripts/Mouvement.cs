using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, rb.velocity.y);
        
    }
    public void AddScore()
    {
        PlayerManager.scorePoint += 1;
        if (PlayerManager.scorePoint % PlayerManager.numberToCheck == 0)
        {
            rb.position = new Vector2(rb.position.x, rb.position.y + 0.5f);       
        }
    }
    }

