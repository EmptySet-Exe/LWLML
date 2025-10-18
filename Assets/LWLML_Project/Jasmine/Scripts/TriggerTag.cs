using UnityEngine;
using UnityEngine.Events;

public class TriggerTag : MonoBehaviour
{

[SerializeField] private string tagName; // Tag to detect
    [SerializeField] UnityEvent trigger; // Subscribes Methods via Inspector

    public void OnCollisionEnter(Collision collision)
    {
        //debug log
        Debug.Log("Collision detected with object: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag(tagName))
        {
            trigger.Invoke();   // Sends the signal
        }
       
    }

    public void TestMethod()
    {
        Debug.Log("Trigger");
    }
}