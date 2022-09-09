using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OWCameraController : MonoBehaviour
{
    [SerializeField] Transform target;

    [SerializeField] Vector3 offset;
    [SerializeField] float zoom = 5f;
    [SerializeField] float pitch = 2f;

    private void LateUpdate()
    {
        transform.position = target.position + offset * zoom;
        transform.LookAt(target.position + Vector3.up * pitch);
    }
}