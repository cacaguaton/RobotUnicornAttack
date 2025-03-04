using System.Collections.Generic;
using UnityEngine;

public class PlataformInstatiate : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> plataforms;
    [SerializeField]
    private Transform plataformsPosition;
    [SerializeField]
    private float distanceBetweenPlataforms = 2f;
    private float offsetPositionX = 0F;

    [SerializeField]
    private int _instantialPLataforms = 10;

    private float _OffsetPositionX=0f;

    private void Start()
    {
        _OffsetPositionX= 0;
        InstantiatePlataforms(_instantialPLataforms);
    }

    public void InstantiatePlataforms(int amount)
    {
        for (int  i = 0; i < amount; i++)
        {
            int randomIndex = Random.Range(0, plataforms.Count);
            if(offsetPositionX != 0)
            {
                offsetPositionX += plataforms[randomIndex].GetComponent<BoxCollider>().size.x * 0.5f;
            }
            GameObject plataform = Instantiate(plataforms[randomIndex], 
            new Vector3(offsetPositionX, plataformsPosition.position.y, plataformsPosition.position.z),
            Quaternion.identity);
            offsetPositionX += distanceBetweenPlataforms + plataform.GetComponent<BoxCollider>().size.x * 0.5f;
            plataform.transform.SetParent(transform);
        }
    } 
}
