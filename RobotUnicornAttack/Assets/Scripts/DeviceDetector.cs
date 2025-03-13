using UnityEngine;
using UnityEngine.Events;

public class DeviceDetector : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onDesktop;
    [SerializeField]
    private UnityEvent _onMobile;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(Application.isMobilePlatform)
        {
            _onMobile?.Invoke();
        }
        else
        {
            _onDesktop?.Invoke();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
