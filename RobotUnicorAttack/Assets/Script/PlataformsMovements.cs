using UnityEngine;

public class PlataformsMovements : MonoBehaviour
{
 [SerializeField]
    private float _Speed=2f;
    [SerializeField]
    private float _speedincrease=0.1f;
    private bool _canMove=true;
    public bool CanMove{set => _canMove=value;}
       void Start()
    {
       
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
        transform.position+=Vector3.left*_Speed*Time.deltaTime;
 
    }
    public void IncreaseSpeed()
    {
        _Speed+=_speedincrease;
    }
 
}
