using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class OWPlayer : MonoBehaviour
{
    [Header("Camera")]
    public new Transform camera;

    [Header("Player Settings")]
    [SerializeField] float speed = 5f;
    [SerializeField] float turnSmoothTime = 0.1f;

    [Header("Animator")]
    [SerializeField] Animator animator;
    
    CharacterController controller;
    Vector3 direction = Vector3.zero;
    float turnSmoothVelocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        animator.SetFloat("speed", direction.magnitude);

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
    }

    void OnMove(InputValue inputValue)
    { 
        direction = inputValue.Get<Vector3>();
    }
}
