using UnityEngine;
using System.Collections;

private Renderer myR;
private Vector3 myTP;

public interface myNumber = 99;

public delegate void ClickEv(int number);
public event ClickEv onClick; 


public class ClickButton : MonoBehaviour
{
    public Material lMat;
    public Material nMat;

    private Renderer myR;

    // Start is called before the first frame update
    private void Awake()
    {
        myR = GetComponent<Renderer>();
        myR.enabled = true;
        myTP=transform.position
    }

        // Update is called once per frame
        private void Update()
        {

        }
    private void OnMouseDown()
    {
        ClickedColor();
        transfom.position = new Vector3(myTP.x, -.2f, myTP.z);
            onClick.Invoke(myNumber);
    }
    private void OnMouseUp()
    {
        UnClickedColor();
        transfom.position = new Vector3(myTP.x,myTP.y, myTP.z)

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