using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
private float xposition, yposition, zposition;
private float xRange = 5f;
private float yRange = 4f;
 private float zRange = 5f;

void Update()
    {
if (Input.GetKeyDown(KeyCode.Return))
    {
xposition = Random.Range(-xRange, xRange);
yposition = Random.Range(-yRange, yRange);
zposition = Random.Range(-zRange, zRange);
transform.position = new Vector3(xposition, yposition, zposition);
    }
  }
}
