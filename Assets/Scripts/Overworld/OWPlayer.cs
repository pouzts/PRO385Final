using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 0f;

    CharacterController controller;
    Vector3 movement = Vector3.zero;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        controller.Move(movement * speed * Time.deltaTime);
    }

    void OnMove(InputValue inputValue)
    { 
        movement = inputValue.Get<Vector3>();
    }
}
