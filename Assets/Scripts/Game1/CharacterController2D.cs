using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent (typeof(Rigidbody2D))]
public class CharacterController2D : MonoBehaviour
{
    private Rigidbody2D RB2D;
    [SerializeField] private float velocity;
    private Vector2 movement;

    private void Awake()
    {
        RB2D = GetComponent<Rigidbody2D>();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        movement=context.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        RB2D.velocity=new Vector2(movement.x*velocity,movement.y*velocity);
    }
}
