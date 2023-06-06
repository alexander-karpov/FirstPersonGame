using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("IsWalking");
        isRunningHash = Animator.StringToHash("IsRunning");
    }

    // Update is called once per frame
    void Update()
    {
        var forwardPressed = Input.GetKey("w");
        var runPressed = Input.GetKey("left shift");

        animator.SetBool(isWalkingHash, forwardPressed);
        animator.SetBool(isRunningHash, runPressed);
    }
}
