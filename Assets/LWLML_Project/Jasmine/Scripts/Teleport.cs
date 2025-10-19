using UnityEngine;

public class Teleport : MonoBehaviour
{
    //game object of other teleport object 
    public GameObject otherTeleport;
    //transform attachment 
    public Transform attachPoint;
    
    //on trigger enter teleport the object
    private void OnTriggerEnter(Collider other)
    {
        TeleportObject(other.gameObject);
    }
    public void TeleportObject(GameObject obj)
    {
        if (otherTeleport != null && attachPoint != null)
        {
            //other teleport get that teleport script and attach point and attach the object to it
            Teleport otherTeleportScript = otherTeleport.GetComponent<Teleport>();
            if (otherTeleportScript != null)
            {
                obj.transform.position = otherTeleportScript.attachPoint.position;
                obj.transform.rotation = otherTeleportScript.attachPoint.rotation;
            }

            
        }
    }

}
