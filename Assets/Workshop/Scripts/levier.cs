using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levier : MonoBehaviour
{
    public GameObject Levier;
    private MeshRenderer meshRenderer;
    private float angle;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        angle = Levier.transform.localEulerAngles.z;
        if ( angle <=46 && angle >= 25) {            meshRenderer.material.color = new Color(0,255,0);        }
        else { meshRenderer.material.color = new Color(255, 0, 0);  }
    }
}
