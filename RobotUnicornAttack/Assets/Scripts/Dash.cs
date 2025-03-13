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
        private bool _canDash=true;
        private bool _dashEnabled=true;
    public bool IsDashing {get=>_isdashing;}
    public void SetDashEnabled(bool enabled)
    {
        _dashEnabled=enabled;
    }
    public void DashActions()
    {
        if(!_isdashing&&_canDash&&_dashEnabled)
        {
            _canDash=false;
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
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
