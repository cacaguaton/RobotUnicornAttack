using UnityEngine;
using UnityEngine.Events;

public class PlayerCollision : MonoBehaviour
{

[SerializeField]
    private UnityEvent _onPlayerLose;
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
                Destroy(collision.gameObject);
            }
            else
            {
                _onPlayerLose?.Invoke();
            }
        }
    }
}
