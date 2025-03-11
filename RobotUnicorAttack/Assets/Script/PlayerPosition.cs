using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    [SerializeField]
    private Transform startingPosition;

    public void SetPlayerPosition()
    {
        player.position = startingPosition.position;
    }
}
