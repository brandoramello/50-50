using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/*
 Associé a : DEPLACEMENT\detection lance & BALISE\seauBalise\player detecter
 */

public class Detection_player : MonoBehaviour
{
    public UnityEvent onDetected;
    public UnityEvent onnotDetected;


    //detecte si le jouer entre dans le collider
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Player")
        {
            onDetected.Invoke();
        }
    }


    //detecte si le jouer sort du collider
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.gameObject.tag == "Player")
        {
            onnotDetected.Invoke();
        }
    }
}
