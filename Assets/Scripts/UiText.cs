using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UiText : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Oue());
    }

    void Update()
    {
        gameObject.GetComponent<Image>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    IEnumerator Oue()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);

    }
}
