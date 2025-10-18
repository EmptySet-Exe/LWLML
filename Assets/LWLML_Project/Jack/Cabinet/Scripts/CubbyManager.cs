using System;
using UnityEngine;

public class CubbyManager : MonoBehaviour
{
    // This will aggregate receivers
    CubbyScript[] recievers;
    public static event Action taskCompletion;
    [SerializeField] int MAX_TASK_COUNT = 3;
    int count = 0;


    void Start()
    {
        // Aggregate all the Receivers
        recievers = GetComponentsInChildren<CubbyScript>();
    }

    void Update()
    {
        count = 0; // Reset Count

        foreach (CubbyScript receiver in recievers)
            if (receiver.completeFlag)
                count++;

        Debug.Log("Count is " + count);

        // Complete Task State!
        if (count >= MAX_TASK_COUNT)
            taskCompletion?.Invoke();
    }
}
