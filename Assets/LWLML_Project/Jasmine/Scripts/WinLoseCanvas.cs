using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
//reload scene after 

public class WinLoseCanvas : MonoBehaviour
{


    //public ref for float delay time before reloading scene
    public float delayBeforeReload = 3f;
    //public method to call ienumerator for reloading scene
    public void ReloadSceneWithDelay()
    {
        StartCoroutine(ReloadSceneAfterDelay(delayBeforeReload));
    }




    //reload scene after delay
    private IEnumerator ReloadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
