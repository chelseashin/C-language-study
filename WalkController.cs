using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkController : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    void Update()
    {
        // Front
        if (Input.GetKey(KeyCode.W) == true) {
            animator.SetFloat("Walk", 1f, 0.1f, Time.deltaTime);
            }    
        // Back
        else if (Input.GetKey(KeyCode.S) == true) {
            }
        // Left
        else if (Input.GetKey(KeyCode.A) == true) {
            animator.SetFloat("Direction", -1f, 0.1f, Time.deltaTime);
            }
        // Right
        else if (Input.GetKey(KeyCode.D) == true) {
            animator.SetFloat("Direction", 1f, 0.1f, Time.deltaTime);
        }
        else {
            animator.SetFloat("Direction", 0f, 0.1f, Time.deltaTime);
            animator.SetFloat("Walk", 0f, 0.1f, Time.deltaTime);
            // animator.SetFloat() 함수 : 우리가 지정한 변수에 값 세팅
        }
    }
}
