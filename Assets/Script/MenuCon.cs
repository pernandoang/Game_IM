using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCon : MonoBehaviour
{
    public SceneAsset[] scene;
    private AudioSource sound;
 
    private void Awake()
    {
        sound = GetComponent<AudioSource>();
    }
    public void ClikPlay()
    {
        sound.Play();
        SceneManager.LoadScene(scene[1].name);
    }
    
}
