using UnityEngine;
using UnityEngine.Events;



public class InputManager : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onPressedKey;
    [SerializeField]
private UnityEvent _onReleasedKey;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #if UNITY_EDITOR||UNITY_STANDALONE
        
        if(Input.GetKeyDown(KeyCode.Space))
         {
            _onPressedKey?.Invoke();
         }
         if(Input.GetKeyUp( KeyCode.Space ))
         {
            _onReleasedKey?.Invoke();
         }


         
        #endif
    }
}
