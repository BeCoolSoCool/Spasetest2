using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Transform cubein;
    public Transform cube334in;
    public int cube;
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            cubein.position += new Vector3(0f, 0f, 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            cubein.position -= new Vector3(0f, 0f, 0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            cubein.position -= new Vector3(0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            cubein.position += new Vector3(0.1f, 0f, 0f);
        }
    }

}
// Update is called once per frame
