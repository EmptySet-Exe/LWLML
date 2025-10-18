using System;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    Animator[] doorAnims;
    [SerializeField] public static event Action<GameManager.GAMESTATES> entered;
    [SerializeField] public bool isOpen { get; private set; } = false;

    void OnEnable()
    {
        // This should have all of the taskComplete Actions for each part of the stage
        CubbyManager.taskComplete += Open;
    }

    void OnDisable()
    {
        CubbyManager.taskComplete -= Open;
    }

    void Start()
    {
        doorAnims = GetComponentsInChildren<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
            entered?.Invoke(GameManager.GAMESTATES.WIN); // This is stubbed for actual player interacting with the door
    }


    void Open()
    {
        Debug.Log("Opens the door");
        foreach (Animator anim in doorAnims)
            anim.enabled = true;

        isOpen = true;
        // gameObject.GetComponent<Renderer>().material.color = Color.white; // Test for whitebox
    }
}
