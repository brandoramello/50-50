using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class cubetrigger : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    XRGrabInteractable interactable;
    public bool Tire;
    private float tempsTire;
    const float tempsMinTire = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
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
                meshRenderer.material.color = new Color(0, 255, 0);
            }
        }
        else
        {
            meshRenderer.material.color = new Color(255, 0, 0);
        }
    }




    private void TriggerReleased(DeactivateEventArgs args)
    {
        Tire = false;
        tempsTire = 0f;
    }

    private void TriggerPulled(ActivateEventArgs args)
    {
        Tire = true;
    }

    private void lacher(SelectExitEventArgs args)
    {
        Tire = false;
        tempsTire = 0f;
    }
}
