using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuvedPrefab : MonoBehaviour
{
    // Type in the name of the Scene you would like to load in the Inspector
    public string m_Scene;

    // Assign your GameObject you want to move Scene in the Inspector
    public GameObject m_MyGameObject;

    public void changeScena()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(m_Scene, LoadSceneMode.Additive);


        SceneManager.MoveGameObjectToScene(m_MyGameObject, SceneManager.GetSceneByName(m_Scene));
        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);
        m_MyGameObject.transform.position = new Vector3 (-6.6f, 11, 35);
    }
}
