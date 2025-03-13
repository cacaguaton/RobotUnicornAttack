using System;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onGameStart;
    [SerializeField]
    private UnityEvent _OnrespawnGame;
    [SerializeField]
    private float _secondsToRestart=3f;
    [SerializeField]

private float _finishSecondsToRestart = 5f;
    void Start()
    {
        _onGameStart?.Invoke();
        
    }

    public void RespawnGame()
    {
        Invoke("RestartGame", _secondsToRestart);
    }

    public void FnishGame()
    {
        _OnrespawnGame?.Invoke();
        Invoke("StartGame", _secondsToRestart);
        Invoke("RestartGame", _finishSecondsToRestart);

    }

    private void RestartGame()
    {
        _OnrespawnGame?.Invoke();
    }
}
