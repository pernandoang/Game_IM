using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayerActive : MonoBehaviour
{
    public float Speed;
    [Header("Componen")]
    public GameObject[] panelGame;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Movement();
    }
    private void Movement()
    {
        float MvHorizontal = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float MvVertical = Input.GetAxis("Vertical") * Speed * Time.deltaTime;

        transform.Translate(MvHorizontal, MvVertical, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Game1")) panelGame[0].SetActive(true);
        if (collision.gameObject.CompareTag("Game2")) panelGame[1].SetActive(true);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Game1")) panelGame[0].SetActive(false);       
        if (collision.gameObject.CompareTag("Game2")) panelGame[1].SetActive(false);       
    }
}
