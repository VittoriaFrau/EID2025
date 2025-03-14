using System;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public GameObject redCylinder, blueCylinder, greenCylinder;
    private CylinderTrigger redCylinderTrigger, blueCylinderTrigger, greenCylinderTrigger;
    public ParticleSystem particleSystem;
    
    private void Start()
    {
        redCylinderTrigger = redCylinder.GetComponent<CylinderTrigger>();
        blueCylinderTrigger = blueCylinder.GetComponent<CylinderTrigger>();
        greenCylinderTrigger = greenCylinder.GetComponent<CylinderTrigger>();
    }

    private void Update()
    {
        if (redCylinderTrigger.isCorrect && blueCylinderTrigger.isCorrect
                                         && greenCylinderTrigger.isCorrect)
        {
            particleSystem.Play();
        }
    }
}
