using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/*
 Associé a : PLAYER\player\Camera Offset\Right Hand\RightBaseController\Right Hand Model  &  PLAYER\player\Camera Offset\Left Hand\LeftBaseController\Left Hand Model
 */

public class Mains : MonoBehaviour
{
    public InputActionReference GripReference;
    public InputActionReference TriggerReference;


    Animator animator;
    private string animatorGripParam = "Grip";
    private string animatorTriggerParam = "Trigger";
    private float GripValue;
    private float TriggerValue;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    //control l'animation des main en fonction de la forrce d'appui sur les boutons
    void Update()
    {
        GripValue=GripReference.action.ReadValue<float>();
        TriggerValue=TriggerReference.action.ReadValue<float>();

        animator.SetFloat(animatorGripParam, GripValue);
        animator.SetFloat(animatorTriggerParam, TriggerValue);
    }

}
