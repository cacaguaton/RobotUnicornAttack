using System.Collections;
using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour
{
    
    public void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
