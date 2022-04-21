using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class pistolet : MonoBehaviour
{

    public ParticleSystem bulles;

    XRGrabInteractable interactable;
    public bool Tire;
    private float tempsTire;
    const float tempsMinTire = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        bulles.GetComponent<ParticleSystem>();
        interactable = GetComponent<XRGrabInteractable>();

        interactable.selectExited.AddListener(lacher);
        interactable.activated.AddListener(TriggerPulled);
        interactable.deactivated.AddListener(TriggerReleased);
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(Eau.isPlaying);
        if (Tire)
        {
            tempsTire += Time.deltaTime;

            if (tempsTire >= tempsMinTire)
            {

                if (!bulles.isPlaying)
                {
                    bulles.Play();
                }
            }
        }
    }




    private void TriggerReleased(DeactivateEventArgs args)
    {
        Tire = false;
        tempsTire = 0f;
        bulles.Stop();
    }

    private void TriggerPulled(ActivateEventArgs args)
    {
        Tire = true;
    }

    private void lacher(SelectExitEventArgs args)
    {
        Tire = false;
        tempsTire = 0f;
        bulles.Stop();
    }



}