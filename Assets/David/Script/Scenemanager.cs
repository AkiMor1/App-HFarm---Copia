using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour
{
    public void SceneChange(string Scena)
    {
        SceneManager.LoadScene(Scena);
    }
}
