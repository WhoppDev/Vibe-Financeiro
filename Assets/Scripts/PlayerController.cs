using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private Rigidbody rb;

    private Vector2 direction;
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = direction * playerSpeed;
    }

    public void PlayerMoviment(InputAction.CallbackContext value)
    {
        direction = value.ReadValue<Vector2>();
    }
}
