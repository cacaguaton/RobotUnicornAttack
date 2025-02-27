using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onGameStart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       _onGameStart?.Invoke(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
