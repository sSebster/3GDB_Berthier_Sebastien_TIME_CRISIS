using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MustReloadScript : MonoBehaviour
{


    public TextMeshProUGUI text;
    float duration = 0.5f;
    float currentTime = 0f;
    float swip = 1;

    void Update()
    {
        Clignote();
    }


    private void Clignote()
    {
        float alpha;

        alpha = Mathf.Lerp(1f, 0f, (currentTime / duration));

        text.color = new Color(text.color.r, text.color.g, text.color.b, alpha);
        currentTime += Time.deltaTime;

        if(currentTime > duration) 
        {
            currentTime = 0;
        }

    }
}
