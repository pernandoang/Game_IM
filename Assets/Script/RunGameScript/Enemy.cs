using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject PrefabEnemy;
    public int Spawn;

    private void FixedUpdate()
    {
        var rndm = Random.Range(90, 100);
        Spawn += 1;
        if (Spawn >= rndm)
        {
            Spawn = 0;
            Instantiate(PrefabEnemy,this.transform.position,this.transform.rotation);
        }
    }
}
