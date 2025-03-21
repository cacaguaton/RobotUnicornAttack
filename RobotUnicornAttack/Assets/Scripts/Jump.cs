using UnityEngine;
using UnityEngine.Events;

public class Jump : MonoBehaviour
{
    [SerializeField]
    private float _jumpForce=10f;
    [SerializeField]
    private float _maxJumpTime=0.3f;
    [SerializeField]
    private float _jumpBoost=0.5f;
    [SerializeField]
    private int _maxJumps=1;
    private int _jumps;

    private Rigidbody rb;

    private bool _isGrounded;

    private bool _isjumping;
    private float _jumpTimeCounter;

    private bool _buttonPressed;

    private bool _canJump=true;

    [SerializeField]
    private UnityEvent _animacion;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void RestartJumps()
    {
        _jumps=_maxJumps;
    }
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }
    public void SetCanJump(bool value)
    {
        _canJump=value;
        RestartJumps();
        _isGrounded = true;
    }

    public void StartJump()
    {
        if(!_canJump)
        {
         
            return;
            

        }
        _buttonPressed=true;
        if (_isGrounded|| _jumps>0)
        {
            _jumps--;
            _isjumping=true;
            _jumpTimeCounter=_maxJumpTime;
            rb.linearVelocity=Vector3.up*_jumpForce;
            _isGrounded=false;
            _animacion?.Invoke();

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
              _animacion?.Invoke();

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
            RestartJumps();
        }
    }


    
}
