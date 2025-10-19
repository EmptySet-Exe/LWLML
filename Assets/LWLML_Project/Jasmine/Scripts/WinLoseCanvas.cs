using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
//reload scene after 

public class WinLoseCanvas : MonoBehaviour
{
    //public reference to an image color component 
    public Image backgroundImage;


    public void SetWinBackgroundColor()
    {
        //slowly increase the alpha of the background image to white
        StartCoroutine(FadeToColor(Color.white));
        //once corutine is done changing color, wait for 1 second and then have the scene reload
        StartCoroutine(ReloadSceneAfterDelay(1f));


    }

    public void SetLoseBackgroundColor()
    {
        //slowly increase the alpha of the background image to black
        StartCoroutine(FadeToColor(Color.black));
        //once corutine is done changing color, wait for 1 second and then have the scene reload
        StartCoroutine(ReloadSceneAfterDelay(1f));
    }

    private IEnumerator FadeToColor(Color targetColor)
    {
        float duration = 1f;
        float elapsed = 0f;
        Color initialColor = backgroundImage.color;

        while (elapsed < duration)
        {
            backgroundImage.color = Color.Lerp(initialColor, targetColor, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        backgroundImage.color = targetColor;
    }
    //reload scene after delay
    private IEnumerator ReloadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
