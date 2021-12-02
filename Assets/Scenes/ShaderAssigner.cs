using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderAssigner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Create a material with transparent diffuse shader
        Material material = new Material(Shader.Find("Transparent/Diffuse"));
        material.color = Color.green;

        // assign the material to the renderer
        GetComponent<Renderer>().material = material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
