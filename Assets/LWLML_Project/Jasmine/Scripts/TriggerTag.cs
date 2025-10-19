using UnityEngine;
using UnityEngine.Events;

public class TriggerTag : MonoBehaviour
{

[SerializeField] private string tagName; // Tag to detect
    [SerializeField] UnityEvent trigger; // Subscribes Methods via Inspector

    //on trigger enter with the specified tag, invoke the event
    public void OnTriggerEnter(Collider other)  
    {
        //debug log
        Debug.Log("Trigger detected with object: " + other.gameObject.name);
        if (other.gameObject.CompareTag(tagName))
        {
            trigger.Invoke();   // Sends the signal
        }
       
    }   
 

    public void TestMethod()
    {
        Debug.Log("Trigger");
    }
}