using UnityEngine;
using UnityEngine.UI;

public class ScoreUi : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;
   
   public void  SetScore(int score)
   {
    _scoreText.text=score.ToString();
   }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
