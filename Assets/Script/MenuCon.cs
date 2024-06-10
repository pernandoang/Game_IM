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

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }
    public void ClikPlay()
    {
        sound.Play();
        SceneManager.LoadScene(scene[1].name);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Apk has quit");
    }
    
}
