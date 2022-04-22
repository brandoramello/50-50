using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    private Vector3 ancienePos;
    private Vector3 ancienerot;
    Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        ancienePos = this.transform.position;
        ancienerot = this.transform.eulerAngles;
        RB = GetComponent<Rigidbody>();
    }

    public void resetatelier()
    {
        RB.isKinematic = true;
        this.transform.position = ancienePos;
        this.transform.eulerAngles = ancienerot;
        RB.isKinematic = false;
    }
}
