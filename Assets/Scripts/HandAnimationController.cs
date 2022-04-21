using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandAnimationController : MonoBehaviour
{
    ActionBasedController controller;

    public HandAnimate handAnimate;

    private void Start()
    {
        controller = GetComponent<ActionBasedController>();
    }

    private void Update()
    {
        handAnimate.SetGrip(controller.selectAction.action.ReadValue<float>());
        handAnimate.SetTrigger(controller.activateAction.action.ReadValue<float>());
    }
}
