using UnityEngine;

public class Exit : MonoBehaviour
{
    int count = 0;


    public void Criteria()
    {
        Debug.Log("Tasks Done: " + (++count));
    }
}