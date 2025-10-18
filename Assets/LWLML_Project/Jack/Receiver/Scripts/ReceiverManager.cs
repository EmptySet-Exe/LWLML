using System;
using UnityEngine;

public class ReceiverManager : MonoBehaviour
{
    // This will aggragate receivers
    ReceiverScript[] recievers;
    public static event Action taskCompletion;
    [SerializeField] int MAX_TASK_COUNT = 3;
    int count = 0;


    void Start()
    {
        // Aggregate all the Receivers
        recievers = GetComponentsInChildren<ReceiverScript>();
    }

    void Update()
    {
        count = 0; // Reset Count

        foreach (ReceiverScript receiver in recievers)
            if (receiver.completeFlag)
                count++;

        Debug.Log("Count is " + count);

        // Win State
        if (count >= MAX_TASK_COUNT)
            taskCompletion?.Invoke();
    }
}
