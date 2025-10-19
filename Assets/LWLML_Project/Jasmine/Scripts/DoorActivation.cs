
using UnityEngine;
using UnityEngine.Events;


public class DoorActivation : MonoBehaviour
{
    public AudioSource doorSound;
    public AudioClip openDoorClip;
    public bool isCorrectDoor;
    //two unity public events for winning and losing 
    public UnityEvent onWin;
    public UnityEvent onLose;
    public Animation animation;

    //public method for the door to play its animation
    //it also does a door check where if the bool on it is tru or false it will result in winning or losing
    public void ActivateDoor()
    {
        

        doorSound.PlayOneShot(openDoorClip);
        animation.Play();

        if (isCorrectDoor)
        {
            Debug.Log("You Win!");//ambiguous reference of debug log 

           

            onWin.Invoke();
        }
        else
        {
            Debug.Log("You Lose!");
            onLose.Invoke();
            // Add losing logic here
        }
        
    }

}
