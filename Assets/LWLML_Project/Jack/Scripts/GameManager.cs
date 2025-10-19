using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GAMESTATES
    {
        WIN,
        LOSE
    };


    [SerializeField] public static event Action<bool> isCleared;
    [SerializeField] private CubbyManager receivers;


    private void OnEnable()
    {
        DoorManager.entered += GameEnd;
    }

    private void OnDisable()
    {
        ExitScript.entered -= GameEnd;
    }


    private void GameEnd(GAMESTATES isWon)
    {
        // End Game Logic is written Here!
        switch(isWon)
        {
            case GAMESTATES.WIN:
                Debug.Log("Cleared the stage!");
                isCleared?.Invoke(true);
                break;
            case GAMESTATES.LOSE:
                Debug.Log("Failed the stage!");
                isCleared?.Invoke(false);
                break;
        }
    }
}