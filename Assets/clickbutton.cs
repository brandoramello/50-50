using System.Collections;

using UnityEngine;

public class button : MonoBehaviour
{
    public Material lMat;
    public Material nMat;

    private Renderer myR;

    // Start is called before the first frame update
    private void Awake()
    {
        myR = GetComponent<Renderer>();
        myR.enabled = true;
    }

    // Update is called once per frame
    private void Update()
    {

    }
    private void OnMouseDown()
    {
        ClickedColor();
    }
    private void OnMouseUp()
    {
        UnClickedColor();
    }
    public void ClickedColor()
    {
        myR.sharedMaterial = nMat;
    }
    public void UnClickedColor()
    {
        myR.sharedMaterial = lMat;
    }
}