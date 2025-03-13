using UnityEngine;
using UnityEngine.Events;

public class MainMenuScreen : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onStartGame;
   public void ShowScreen(GameObject screen)
   {
    screen.SetActive(true);
   }
   public void HideScreen(GameObject screen)
   {
    screen.SetActive(false);
   }
    void Start()
    {
        _onStartGame?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
