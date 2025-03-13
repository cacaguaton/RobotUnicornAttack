using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;



public class ButtonController : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField]
    private UnityEvent _onPressedButton;
    [SerializeField]
    private UnityEvent _onReleasedButton;

    public void OnPointerDown(PointerEventData eventData)
    {
        _onPressedButton?.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
            _onReleasedButton?.Invoke();

    }
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
