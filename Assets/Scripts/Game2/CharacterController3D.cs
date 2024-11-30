using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController3D : MonoBehaviour
{
    private Rigidbody RB;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    [Header("Raycast")]
    [SerializeField] private LayerMask layer; 
    private Vector3 movement;  

    private bool isJump ;

    private void Awake()
    {
        RB = GetComponent<Rigidbody>();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>(); 
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        isJump = context.performed;
    }

    private void FixedUpdate()
    {
        RB.velocity= new Vector3(movement.x * speed, RB.velocity.y, movement.y* speed);
        if (Physics.Raycast(transform.position, Vector2.down, 1.5f, layer))
        {
            if (isJump)
            {
                RB.AddForce(new Vector2(0, jumpForce), ForceMode.Impulse);
            }
        }
    }

}

