using System;
using UnityEngine;

public class FloorChangingColor : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision other)
    {
        Material sphereMaterial = 
            other.gameObject.GetComponent<MeshRenderer>().material;
        this.gameObject.GetComponent<MeshRenderer>().material = sphereMaterial;
    }
}
