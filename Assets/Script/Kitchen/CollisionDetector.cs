using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject[] prefab;
    private void Start()
    {
        for (int i = 0; i < prefab.Length; i++)
        {
            prefab[i].SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            prefab[0].SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            prefab[0].SetActive(false);
        }
    }
}
