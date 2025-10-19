using System;
using UnityEngine;

public class CubbyManager : MonoBehaviour
{
    // This will aggregate receivers
    CubbyScript[] cubbies;
    public static event Action taskComplete;
    [SerializeField] int MAX_TASK_COUNT = 3;
    int count = 0;


    void Start()
    {
        // Aggregate all the Receivers
        cubbies = GetComponentsInChildren<CubbyScript>();
    }

    void Update()
    {
        count = 0; // Reset Count

        foreach (CubbyScript cubby in cubbies)
            if (cubby.completeFlag)
                count++;

        Debug.Log("Count is " + count);

        // Complete Task State!
        if (count >= MAX_TASK_COUNT)
            taskComplete?.Invoke();
    }
}
