using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogDisappear : MonoBehaviour
{
    public Collider hand;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider == hand)
        {
            this.gameObject.SetActive(false);
        }
    }
}
