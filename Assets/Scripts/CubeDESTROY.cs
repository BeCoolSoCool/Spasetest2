using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDESTROY : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}