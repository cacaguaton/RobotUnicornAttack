using UnityEngine;
using UnityEngine.Events;

public class PlataformsTrigger : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onPlatformTriggered;

    private void OggerEnter(Collider other)
    {
        if (other.CompareTag("DeadZone"))
        {
            Destroy(other.gameObject);
            onPlatformTriggered?.Invoke();
        }      
    }
}
