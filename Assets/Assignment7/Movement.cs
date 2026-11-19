using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 8f;

    void FixedUpdate()
    {
        // Make sure a keyboard is connected
        if (Keyboard.current != null)
        {
            // Right (D key) / Left (A key) movement
            if (Keyboard.current.dKey.isPressed)
            {
                rb.linearVelocityX = moveSpeed;
            }
            else if (Keyboard.current.aKey.isPressed)
            {
                rb.linearVelocityX = -moveSpeed;
            }
            else
            {
                rb.linearVelocityX = 0f;
            }

            // Up (W key) / Down (S key) movement
            if (Keyboard.current.wKey.isPressed)
            {
                rb.linearVelocityY = moveSpeed;
            }
            else if (Keyboard.current.sKey.isPressed)
            {
                rb.linearVelocityY = -moveSpeed;
            }
            else
            {
                rb.linearVelocityY = 0f;
            }
        }
    }
}