using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsController : MonoBehaviour
{

    public Material baseMaterial;
    public Material selectionMaterial;

    MeshRenderer meshObject;

    // Start is called before the first frame update
    void Start()
    {
        meshObject = this.GetComponent<MeshRenderer>();
    }

    public void setMaterial()
    {
        meshObject.material = selectionMaterial;
    }

    public void resetMaterial()
    {
        meshObject.material = baseMaterial;
    }
}
