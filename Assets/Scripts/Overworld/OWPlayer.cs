using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class OWPlayer : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] float speed = 5f;
    [SerializeField] float turnSmoothTime = 0.1f;

    CharacterController controller;
    Vector3 direction = Vector3.zero;
    float turnSmoothVelocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir * speed * Time.deltaTime);
        }
    }

    void OnMove(InputValue inputValue)
    { 
        direction = inputValue.Get<Vector3>();
    }
}
