using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerActiverun : MonoBehaviour
{
    public TextMeshProUGUI poin;
    public Vector2 Force;
    public bool IsGround;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Jump();
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGround == true)
        {
            rb.AddForce(Force,ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground")) { IsGround = true; }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground")) { IsGround = false; }      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Poin"))
        {
            int Score = Convert.ToInt32(poin.text);
            Score += 1;
            poin.text = Score.ToString();
        }
    }
}
