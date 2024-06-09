using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float Speed = -5;
    private void Update()
    {
        transform.Translate(Speed * Time.deltaTime,0,0,Space.World);

        if (transform.position.x < -9)
        {
            Destroy(gameObject);
        }
    }
}
