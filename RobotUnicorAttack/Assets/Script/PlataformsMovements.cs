using UnityEngine;
using UnityEngine.Events;

public class PlataformsMovements : MonoBehaviour
{
 [SerializeField]
    private float initialSpeed=2f;
    [SerializeField]
    private float _speedincrease=0.1f;
    [SerializeField]
    private UnityEvent<int>_onSocoreChangued;
    private bool _canMove=true;
    public bool CanMove{set => _canMove=value;}

    private Vector3 startingPosition;
    private float speed;

    public Vector3 moveDistance;


       void Start()
    {
       startingPosition = transform.position;
       speed = initialSpeed;
    }
 
    // Update is called once per frame
    void Update()
    {
        if(_canMove)
        {
            MovePlatforms();
        }
    }
    private void MovePlatforms()
    {
        Vector3 distanceToMove = Vector3.left * speed * Time.deltaTime;
        transform.position += distanceToMove;
         moveDistance += distanceToMove;
        _onSocoreChangued?.Invoke(Mathf.Abs((int)moveDistance.x));
 
    }
    public void IncreaseSpeed()
    {
        speed+=_speedincrease;
    }

    public void StopMovement()
    {
        CanMove= false;
    }
 
    public void StartMovement()
    {
        CanMove= true;
    }
    public void Restart()

    {
        transform.position = startingPosition;
        speed = initialSpeed;
        StartMovement();
    }
}
