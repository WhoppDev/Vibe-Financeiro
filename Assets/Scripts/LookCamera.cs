using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LookCamera : MonoBehaviour
{
    [SerializeField] private float camSensitive;
    [SerializeField] private float minRotate;
    [SerializeField] private float maxRotate;

    private float xRotate;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float inputY = xRotate * camSensitive * Time.fixedDeltaTime;

        inputY = Mathf.Clamp(inputY, minRotate, maxRotate);

        transform.localRotation = Quaternion.Euler(-inputY, 0, 0);

    }

    public void moveCamera(InputAction.CallbackContext value)
    {
        xRotate = value.ReadValue<float>();
    }
}
