using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise05 : MonoBehaviour
{
    public GameObject capsulePrefab;
    public Vector3[] aaaaaaa;

    void Update()
    {   
    if (Input.GetKeyDown(KeyCode.S))

    {         
    GameObject[] capsulesInGame = GameObject.FindGameObjectsWithTag("Capsule");
    foreach (GameObject obj in capsulesInGame)
    {
    Destroy(obj);
    }       

    foreach (Vector3 pos in aaaaaaa)
    {
    Instantiate(capsulePrefab, pos, capsulePrefab.transform.rotation);
    }
    
   }
  }
}
