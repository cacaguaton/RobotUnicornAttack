using UnityEngine;
using UnityEngine.Video;

public class PlayerPosition : MonoBehaviour
{
    [SerializeField]
    private Transform _Player;
    [SerializeField]
    private Transform _StartingPosition;

    public void SetPlayerPosition()
    {
        _Player.position=_StartingPosition.position;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
