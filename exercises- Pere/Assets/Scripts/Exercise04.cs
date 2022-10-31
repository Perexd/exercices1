using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise04 : MonoBehaviour
 {
 public GameObject sphere;
 public void ChangeObjectScale(float value)
 {
 sphere.transform.localScale = new Vector3(value, value, value);
 }
}