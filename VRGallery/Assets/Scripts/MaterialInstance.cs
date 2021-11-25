using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialInstance : MonoBehaviour
{
    private GameObject go;
    private Material material;
    public Texture texture;

    // Start is called before the first frame update
    void Start()
    {
        go = this.gameObject;
        Material[] materials = go.GetComponent<MeshRenderer>().materials;
        foreach (Material item in materials)
        {

           if(item.name.ToString().ToLower().StartsWith("picture"))
            {
                material = item;
                
            }

        }

        material.mainTexture = texture;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
