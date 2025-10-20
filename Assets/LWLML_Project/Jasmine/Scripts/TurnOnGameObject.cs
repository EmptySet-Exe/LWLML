using UnityEngine;

public class TurnOnGameObject : MonoBehaviour
{
    //public method that turns this game object on 
    //public ref to the game object 
    public GameObject gameObjectRef;
    public void ActivateGameObject()
    {
        gameObjectRef.SetActive(true);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
