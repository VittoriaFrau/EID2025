using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material blueMaterial;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       this.gameObject.GetComponent<MeshRenderer>().material = blueMaterial;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
