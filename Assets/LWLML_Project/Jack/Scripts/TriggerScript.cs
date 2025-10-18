using UnityEngine;
using UnityEngine.Events;

public class TriggerScript : MonoBehaviour
{
    public UnityEvent<GameManager.GAMESTATES> trigger; // Subscribes Methods via Inspector (except this is static, so no)

    public void OnCollisionEnter(Collision collision)
    {
        trigger?.Invoke(GameManager.GAMESTATES.WIN);   // Sends the signal
    }
}