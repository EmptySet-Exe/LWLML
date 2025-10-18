using System;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    [SerializeField] public static event Action<GameManager.GAMESTATES> entered;
    [SerializeField] public bool isOpen { get; private set; } = false;


    private void OnEnable()
    {
        ReceiverManager.taskCompletion += Open;
    }

    private void OnDisable()
    {
        ReceiverManager.taskCompletion -= Open;
    }

    void Open()
    {
        Debug.Log("Opens the door");
        isOpen = true;
        gameObject.GetComponent<Renderer>().material.color = Color.white;
        entered?.Invoke(GameManager.GAMESTATES.WIN); // This is stubbed for actual player interacting with the door
    }
}