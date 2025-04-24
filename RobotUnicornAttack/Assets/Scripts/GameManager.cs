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

    private UnityEvent onFinishGame;
    [SerializeField]
    private UnityEvent onLoseGame;

    [SerializeField]
    private UnityEvent onShowGameOverScreen;

    [SerializeField]
    private UnityEvent <int> onShowScreen;

    [SerializeField]

    private float _secondsToRestart=3f;
   

    private float secondsToShowGameOverScreen = 3f;

    [SerializeField]

private float _finishSecondsToRestart = 5f;

    public void Awake()
    {
        _secondsToRestart+= secondsToShowGameOverScreen;
        _finishSecondsToRestart+= secondsToShowGameOverScreen;
    }
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
        Invoke("Start", _secondsToRestart);
        Invoke("RestartGame", _finishSecondsToRestart);

    }

    private void ShowGameOverScreen()

    {
        onShowGameOverScreen?.Invoke();
        onShowScreen?.Invoke(3);
    }

    private void RestartGame()
    {
        _OnrespawnGame?.Invoke();
    }
    public void LoseGame()
    {
        onLoseGame?.Invoke();
        Invoke("ShowGameOverScreen", secondsToShowGameOverScreen);
    }
}
