using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class SpawnSpotManager : MonoBehaviour
{
    [SerializeField]
    ARRaycastManager raycastManager;
    List<ARRaycastHit> hitList = new List<ARRaycastHit>();
    [SerializeField]
    Camera arCam;
    int currentPrefab;
    List<GameObject> spawnedObjects = new List<GameObject>();
    bool isTouchingButton;
    GameObject selectedObject;
    [SerializeField]
    GameObject secondarySpawnPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void SpawnPatch(RaycastHit hit)
    //{
    //    if (hit.collider.gameObject.tag == "Spawnable")
    //    {
    //        if (selectedObject != null)
    //        {
    //            selectedObject.GetComponent<MeshRenderer>().material.color = Color.white;
    //        }

    //        selectedObject = hit.collider.gameObject;
    //        selectedObject.GetComponent<MeshRenderer>().material.color = Color.red;
    //    }
    //    else if (hit.collider.gameObject.tag == "SpawnSpot")
    //    {
    //        Instantiate(secondarySpawnPrefab, hit.transform);
    //    }
    //    else
    //    {
    //        if (selectedObject != null)
    //        {
    //            selectedObject.GetComponent<MeshRenderer>().material.color = Color.white;
    //            selectedObject = null;
    //        }
    //        currentPrefab++;
    //        if (currentPrefab > spawnablePrefabs.Length - 1)
    //        {
    //            currentPrefab = 0;
    //        }
    //        spawnedObjects.Add(Instantiate(spawnablePrefabs[currentPrefab], hitList[0].pose.position, hitList[0].pose.rotation));
    //    }
    //}
}
