using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System;

public class mainsDidacticiel : MonoBehaviour
{

    public InputActionReference touchTriggerReference;
    public InputActionReference touchButtonAReference;
    public InputActionReference touchButtonBReference;
    public InputActionReference touchJoystickReference;

    Animator AnimateurMainDidacticiel;





    // Start is called before the first frame update
    void Start()
    {
        AnimateurMainDidacticiel = this.GetComponent<Animator>();
    }

    private void unTouchTrigger(InputAction.CallbackContext obj)
    {
        throw new NotImplementedException();
    }

    void Update()
    {
        if (touchTriggerReference.action.ReadValue<float>() == 1) { AnimateurMainDidacticiel.SetBool("TouchTrigger", true);  }
        else { AnimateurMainDidacticiel.SetBool("TouchTrigger", false); }

        if (touchButtonBReference.action.ReadValue<float>() == 1) { AnimateurMainDidacticiel.SetInteger("TouchPouce", 2); }
        else if (touchButtonAReference.action.ReadValue<float>() == 1) { AnimateurMainDidacticiel.SetInteger("TouchPouce", 1); }
        else if (touchJoystickReference.action.ReadValue<float>() == 1) { AnimateurMainDidacticiel.SetInteger("TouchPouce", 3); }
        else { AnimateurMainDidacticiel.SetInteger("TouchPouce", 0); }

    }
}
