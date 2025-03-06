using UnityEngine;

public class PlataformsMovements : MonoBehaviour
{
 [SerializeField]
    private float initialSpeed=2f;
    [SerializeField]
    private float _speedincrease=0.1f;
    private bool _canMove=true;
    public bool CanMove{set => _canMove=value;}

    private Vector3 startingPosition;
    private float speed;
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
        transform.position+=Vector3.left*speed*Time.deltaTime;
 
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
