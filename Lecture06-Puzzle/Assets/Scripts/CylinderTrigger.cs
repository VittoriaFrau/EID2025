using System;
using UnityEngine;

public class CylinderTrigger : MonoBehaviour
{
    public bool isCorrect;

    public string cylinderColor;
    /*private void OnCollisionEnter(Collision other)
    {
        // if the collision is with a cube of the same color
        //something happens
        Debug.Log(other.gameObject.name);
    }*/

    private void OnTriggerEnter(Collider other)
    {
        //if the trigger is with the cube of the same color
        if (other.gameObject.name.Contains(cylinderColor))
        {
            isCorrect = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Contains(cylinderColor))
        {
            isCorrect = false;
        }
    }
}
