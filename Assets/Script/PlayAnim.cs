using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayAnim : MonoBehaviour
{
    public Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Play", false);
    }
    private void Update()
    {
        
    }
}
