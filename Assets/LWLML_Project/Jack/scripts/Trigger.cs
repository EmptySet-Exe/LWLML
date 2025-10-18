using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{

    [SerializeField] UnityEvent trigger; // Subscribes Methods via Inspector

    public void OnCollisionEnter(Collision collision)
    {
        trigger.Invoke();   // Sends the signal
    }

    public void TestMethod()
    {
        Debug.Log("Trigger");
    }
}