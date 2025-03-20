using System.Collections.Generic;

using UnityEngine;

public class PlatformInstantiate : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _platforms;
    [SerializeField]
    private float distanceBetweenPlatforms= 2f;
    [SerializeField]
    private int _InitialPlatforms=10;
    private float _OffSetPositionX=0f;
    public  void Start()
    {
        _OffSetPositionX=0;
        InstantiatePlatforms(_InitialPlatforms);
    }
    public void InstantiatePlatforms(int amount)
    {
        for(int i=0;i<amount;i++)
        {
            int randomIndex= Random.Range(0,_platforms.Count);
            if(i>=2)
            {
                if(_OffSetPositionX!=0)
            {
                _OffSetPositionX+=_platforms[randomIndex].GetComponent<BoxCollider>().size.x*0.5f;
            }
            GameObject platform = Instantiate(_platforms[randomIndex], Vector3.zero, Quaternion.identity);
            _OffSetPositionX += distanceBetweenPlatforms + platform.GetComponent<BoxCollider>().size.x * 0.5f;
            platform.transform.SetParent(transform);
            platform.transform.localPosition = new Vector3(_OffSetPositionX, 0,0);
            }
            else
            {
            
            if(_OffSetPositionX!=0)
            {
                _OffSetPositionX+=_platforms[randomIndex].GetComponent<BoxCollider>().size.x*0.5f;
            }
                GameObject platform = Instantiate(_platforms[0], Vector3.zero, Quaternion.identity);
            _OffSetPositionX += distanceBetweenPlatforms + platform.GetComponent<BoxCollider>().size.x * 0.5f;
            platform.transform.SetParent(transform);
            platform.transform.localPosition = new Vector3(_OffSetPositionX, 0,0);
            }            
        }

    }
    public void Restart()
    {
        foreach(Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        Start();
    }

}
