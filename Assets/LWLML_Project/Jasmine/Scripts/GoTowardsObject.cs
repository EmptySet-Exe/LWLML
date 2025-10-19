using UnityEngine;
using System.Collections;

public class GoTowardsObject : MonoBehaviour
{
    //public reference to target object
    public Transform targetObject;
    //public speed float
    public float speed = 5f;
    //minimum distance to consider "reached"
    public float stopDistance = 0.01f;
    
    private bool isMoving = false;
    
    public void MoveTowardsTarget()
    {
        if (targetObject != null && !isMoving)
        {
            StartCoroutine(MoveTowardsTargetCoroutine());
        }
        else if (targetObject == null)
        {
            Debug.LogWarning("Target object is null!");
        }
        else if (isMoving)
        {
            Debug.Log("Already moving towards target!");
        }
    }
    
    private IEnumerator MoveTowardsTargetCoroutine()
    {
        isMoving = true;
        Debug.Log($"Starting movement towards target: {targetObject.name}");
        Debug.Log($"Initial position: {transform.position}");
        Debug.Log($"Target position: {targetObject.position}");
        
        while (targetObject != null && Vector3.Distance(transform.position, targetObject.position) > stopDistance)
        {
            Vector3 newPosition = Vector3.MoveTowards(transform.position, targetObject.position, speed * Time.deltaTime);
            transform.position = newPosition;
            
            yield return null; // Wait for next frame
        }
        
        Debug.Log($"Movement completed! Final position: {transform.position}");
        Debug.Log($"Final distance to target: {Vector3.Distance(transform.position, targetObject.position)}");
        isMoving = false;
    }
    
}
