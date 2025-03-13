using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManager : MonoBehaviour
{
    
    public void LoadScene(string sceneName)
    {
       
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
