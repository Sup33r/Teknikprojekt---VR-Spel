using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public Animator handAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pinchAnimationAction.action.Enable();
        gripAnimationAction.action.Enable();
        handAnimator.SetFloat("Pinch", pinchAnimationAction.action.ReadValue<float>());
        handAnimator.SetFloat("Grip", gripAnimationAction.action.ReadValue<float>());
    }
}
