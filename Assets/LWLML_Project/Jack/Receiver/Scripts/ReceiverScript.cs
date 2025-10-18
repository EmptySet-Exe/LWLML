using Unity.VisualScripting;
using UnityEngine;

public class ReceiverScript : MonoBehaviour
{
    [SerializeField] string receiverTarget = "BLANK";
    [SerializeField] public bool completeFlag { get; private set; } = false;


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == receiverTarget)
        {
            Debug.Log(receiverTarget + " Match!");
            completeFlag = true;
        }
    }
}
