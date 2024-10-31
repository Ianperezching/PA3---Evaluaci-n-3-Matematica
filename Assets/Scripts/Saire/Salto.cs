using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Rigidbody2D))]
public class Salto : MonoBehaviour
{
    private Rigidbody2D Rb2d;
    private bool jump;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private float forjump;
    private void Awake()
    {
        Rb2d = GetComponent<Rigidbody2D>();
    }
    public void Jump(InputAction.CallbackContext context)
    {
        Debug.Log(context.phase);
        jump = context.performed;
    }
    private void FixedUpdate()
    {
        if (Physics2D.Raycast(transform.position, Vector3.down, 1.03f, layerMask))
        {
            if (jump)
            {
                Rb2d.AddForce(new Vector3(0, forjump, 0), ForceMode2D.Impulse);
            }
        }
    }
}
