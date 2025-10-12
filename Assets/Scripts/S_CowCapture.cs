using UnityEngine;

public class S_CowCapture : MonoBehaviour
{
    public bool captured = false;
    public bool canCapture = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && captured == false)
        {
            canCapture = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
            canCapture = false;        
    }
}
