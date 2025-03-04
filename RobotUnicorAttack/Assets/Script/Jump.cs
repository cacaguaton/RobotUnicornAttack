using System.Runtime.InteropServices;
using UnityEngine;

public class Jump : MonoBehaviour
{
 [SerializeField]
    private float _jumpForce=10f;
    [SerializeField]
    private float _maxJumpTime=0.3f;
    [SerializeField]
    private float _jumpBoost=0.5f;
    [SerializeField]
    private int _jumps;
 
    private Rigidbody rb;
 
    private bool _isGrounded;
 
    private bool _isjumping;
    private float _jumpTimeCounter;
 
    private bool _buttonPressed;
 
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }
 
    public void StartJump()
    {
        _buttonPressed=true;
        if (_isGrounded)
        {
            _buttonPressed = true;
            if(_isGrounded || _jumps >0)
            {

            _jumps--;
            _isjumping=true;
            _jumpTimeCounter=_maxJumpTime;
            rb.linearVelocity=Vector3.up*_jumpForce;
            _isGrounded=false;

            }
 
        }
    }
    public void EndJump()
    {
        _buttonPressed=false;
    }
    private void FixedUpdate()
    {
        HandleJump();
    }
    private void HandleJump()
    {
        if(_buttonPressed && _isjumping)
        {
            if(_jumpTimeCounter>0)
            {
              rb.linearVelocity=Vector3.up*(_jumpForce+_jumpBoost);
              _jumpTimeCounter-=Time.fixedDeltaTime;
 
            }
            else
            {
                _isjumping=false;
            }
        }
 
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded=true;
        }
    }
 
 
 

}

