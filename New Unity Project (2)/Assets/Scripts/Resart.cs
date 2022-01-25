using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resart : MonoBehaviour
{
    public void RestartGame(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
