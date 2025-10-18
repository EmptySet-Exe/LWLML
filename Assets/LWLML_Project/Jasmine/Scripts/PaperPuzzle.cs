using UnityEngine;
using UnityEngine.Events;

public class PaperPuzzle : MonoBehaviour
{
    // References to paper pieces paper logic scripts

    public PaperLogic piece1Logic;
    public PaperLogic piece2Logic;
    public PaperLogic piece3Logic;
    public PaperLogic piece4Logic;
   

    //public event that checks if all    peices logic boolean iscorrectdrawing is true if they are then have a public unity event that is trigged called finishedStage2
    public UnityEvent finishedStage2;
    public void CheckPuzzleCompletion()
    {
        if (piece1Logic.isCorrectDrawing && piece2Logic.isCorrectDrawing && piece3Logic.isCorrectDrawing && piece4Logic.isCorrectDrawing)
        {
            Debug.Log("Puzzle completed!");
            finishedStage2.Invoke();
        }
        else
        {
            Debug.Log("Puzzle not yet completed.");
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
