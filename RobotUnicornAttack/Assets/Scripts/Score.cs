using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;


public class Score : MonoBehaviour
{
   private List<int> scores =new List<int>();
   private int _currentScore=0;
[SerializeField]
private UnityEvent<int> _onScoredChangue;
[SerializeField]
private UnityEvent<int> _onSetScored;
[SerializeField]
private UnityEvent<int> _onSetFinalScore;
[SerializeField]
private int _scoresNumber=3;

   public void SetScore(int score)
   {
    
    _currentScore=score;
    _onScoredChangue?.Invoke(_currentScore);


   }
   public void initialize()
   {
    
    _currentScore=0;
    scores.Clear();
   
   }

   public void PlayerLose()
   {
    scores.Add(_currentScore);
    _onSetScored?.Invoke(_currentScore);
    _currentScore=0;
    
   }
   public void SetFinalScore()
   {
     int finalScore=0   ;
        foreach(int score in scores)
        {
            finalScore+=score;
        }
        _onSetFinalScore?.Invoke(finalScore);
        scores.Clear();

   }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
