using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitRunGame : MonoBehaviour
{
    public SceneAsset scene;

    public void BackToHome()
    {
        SceneManager.LoadScene(scene.name);
    }
}
