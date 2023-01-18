using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePrefab : MonoBehaviour
{
    public GameObject prefab;

    public void ONVendità(string nameScena)
    {
        Scene currentScene = SceneManager.GetActiveScene();

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nameScena, LoadSceneMode.Additive);
        while (!asyncLoad.isDone)
        {
            Debug.Log("incaricamento");
        }
        SceneManager.MoveGameObjectToScene(prefab, SceneManager.GetSceneByName(nameScena));
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(nameScena));

        SceneManager.UnloadSceneAsync(currentScene);
        //prefab.transform.parent = GameObject.Find()
    }
}
