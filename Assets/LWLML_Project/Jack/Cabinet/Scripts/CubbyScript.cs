using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CubbyScript : MonoBehaviour
{
    [SerializeField] string receiverTarget = "BLANK";
    [SerializeField] public bool completeFlag { get; private set; } = false;
    private UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socketInteractor;

    void Awake()
    {
        socketInteractor = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>();
    }

    void OnEnable()
    {
        socketInteractor.selectEntered.AddListener(OnPlaced);
        socketInteractor.selectExited.AddListener(UnPlaced);
    }

    void OnDisable()
    {
        socketInteractor.selectEntered.RemoveListener(OnPlaced);
        socketInteractor.selectExited.RemoveListener(UnPlaced);
    }

    // void OnCollisionEnter(Collision collision)
    void OnPlaced(SelectEnterEventArgs args)
    {
        GameObject placedObject = args.interactableObject.transform.gameObject;

        if(placedObject.name == receiverTarget)
        {
            Debug.Log(receiverTarget + " Match!");
            completeFlag = true;
        }
    }

    void UnPlaced(SelectExitEventArgs args)
    {
        // Stubbed Code for removal logic
    }
}
