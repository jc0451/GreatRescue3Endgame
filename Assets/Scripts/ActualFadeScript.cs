using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class ActualFadeScript : MonoBehaviour
{
    public float fadeDuration = 0.5f;

    public float fadeDelay = 0f;

    public float fadeTo = 0f;

    public TextMeshProUGUI text;

    void Start()
    {
        // Fade with initial delay
        Invoke("fade", fadeDelay);
    }

    public void fade()
    {
        // Fade in/out

        while (1 ==1)
        {
            text.CrossFadeAlpha(fadeTo, fadeDuration, false);
            print("fading mfer");
        }

        
    }
}