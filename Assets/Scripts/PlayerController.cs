using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputManager inputManager;

    [SerializeField] private float playerSpeed;
    [SerializeField] private float runSpeed;

    [SerializeField] private float jumpForce;

    [SerializeField] private Rigidbody rb;

    private Vector2 direction;

}
