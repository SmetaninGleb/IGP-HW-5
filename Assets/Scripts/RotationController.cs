using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField] private float _sensetivity = 100f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float rotation = Input.GetAxis("Mouse X") * _sensetivity * Time.deltaTime;
        Vector3 newRotation = transform.rotation.eulerAngles;
        newRotation += Vector3.up * rotation;
        transform.rotation = Quaternion.Euler(newRotation);
    }
}
