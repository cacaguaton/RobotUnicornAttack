using System.Runtime.InteropServices;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    private float _jumpForce=1.0F;
    [SerializeField]
    private float _maxJumpTime=0.3f;
    
    [SerializeField]
    private float _jumpBoost=0.5f;
   
   private Rigidbody rb;

   private bool isGrounded;

   private bool isJumping;
   private float jumpTimeCounter;
   private bool buttonPressed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void StartJump()
    {
        buttonPressed = true;
        if(isGrounded)
        {
            isJumping = true;
            jumpTimeCounter = _maxJumpTime;
            rb.linearVelocity = Vector3.up * _jumpForce;
            isGrounded = false;

        }
    }

    public void EndJump()
    {
        buttonPressed = false;

    }

    private void FixedUpdate()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        if (buttonPressed && isJumping)
        {
            if (jumpTimeCounter > 0)
            {
                rb.linearVelocity = Vector3.up * (_jumpForce + _jumpBoost);
                jumpTimeCounter -= Time.fixedDeltaTime;
            }
            else
            {
                isJumping= false;
            }
        }
    }

    private void OCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true ;
        }
    }


}

