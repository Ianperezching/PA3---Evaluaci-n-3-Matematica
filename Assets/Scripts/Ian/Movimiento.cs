using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb; 

    private Vector2 movementInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        
        Vector2 force = movementInput * speed;
        rb.AddForce(force);
    }
}
