using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    [SerializeField]
    private List<Text> Scorestext;
    [SerializeField]
    private Text _finalScoreTxt;
    private int _ScoreIndex;

    public void SetScore(int score)
    {
        Scorestext[_ScoreIndex].text=score.ToString();
        _ScoreIndex++;


    }
        public void SetFinalScore(int score)
        {
            _finalScoreTxt.text=score.ToString(); 
        }

        public void Restart()
        {
            _ScoreIndex=0;
            _finalScoreTxt.text="0";
            foreach(Text scoreText in Scorestext)
            {
                scoreText.text="0";
            }
        } 
  
    void Start()
    {
        
    }

    
}
