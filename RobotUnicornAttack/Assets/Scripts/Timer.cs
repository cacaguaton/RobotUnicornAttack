using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text timerText;
    [SerializeField]
    private UnityEvent onSecondPassed;
    private int  currentSecons;
    public void StartTimer(int startSeconds)
    {
        currentSecons = startSeconds;
        SetTimer();
    }

    private void SetTimer()
    {
        onSecondPassed?.Invoke();
        currentSecons--;
        timerText.text = currentSecons.ToString();
        if (currentSecons > 0)
        {
            Invoke("SetTimer", 1f);
            SoundManager.instance.Play("Tick");
        }
    }

}
