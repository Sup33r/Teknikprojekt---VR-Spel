using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    
    // Värden för att kunna ansluta till inputsystemet
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public Animator handAnimator;

    void Update()
    {
        // Aktiverar inputsystemet
        pinchAnimationAction.action.Enable();
        gripAnimationAction.action.Enable();
        handAnimator.SetFloat("Trigger", pinchAnimationAction.action.ReadValue<float>());
        handAnimator.SetFloat("Grip", gripAnimationAction.action.ReadValue<float>());
    }
}