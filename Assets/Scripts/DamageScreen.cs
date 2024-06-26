using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageScreen : MonoBehaviour
{
    public Image DamageImage;
    // Start is called before the first frame update
    public void StartEffect()
    {
        StartCoroutine(ShowEffect());

    }

    // Update is called once per frame
    public IEnumerator ShowEffect()
    {
        DamageImage.enabled = true;
        for (float t = 1; t > 0f; t -= Time.deltaTime)
        {
            DamageImage.color = new Color(1, 0, 0, t);
            yield return null;
        }
        DamageImage.enabled = false;
    }
}
