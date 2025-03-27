using UnityEngine;
using UnityEngine.Events;

public class PlayerCollition : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onPlayerLose;

    [SerializeField]
    private UnityEvent<Transform> onObstacleDestroyed;
    [SerializeField]
    private UnityEvent<Transform> onCollisionDie;
    private Dash _dash;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _dash=GetComponent<Dash>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            if(_dash.IsDashing)
            {
                onObstacleDestroyed?.Invoke(transform);
                Destroy(collision.gameObject);
            }
            else
            {
                onCollisionDie?.Invoke(transform);
                _onPlayerLose?.Invoke();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeadZone"))
        {
            onCollisionDie?.Invoke(transform);
            _onPlayerLose?.Invoke();
        }   
    }
}
