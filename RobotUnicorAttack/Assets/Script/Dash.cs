using UnityEngine;
using UnityEngine.Events;

public class Dash : MonoBehaviour
{
[SerializeField]
    private float _duration=0.5f;
    [SerializeField]
    private float InactiveDuration=2f;
    [SerializeField]
    private UnityEvent _onDash;
    [SerializeField]
    private UnityEvent _onStopDash;  
        private bool _isdashing;
        private bool _canDash;
    public bool IsDashing {get=>_isdashing;}
    public void DashActions()
    {
        if(!_isdashing)
        {
            _onDash?.Invoke();
            _isdashing=true;
            Invoke(nameof(StopDash),_duration);
        }
    }
    private void StopDash()
    {
        _onStopDash?.Invoke();
        _isdashing=false;
            Invoke(nameof(EnableDash),InactiveDuration);
 
    }
    private void EnableDash()
    {
        _canDash=true;
    }
 

}
