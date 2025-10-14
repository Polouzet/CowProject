using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class S_MouseClickEvent : MonoBehaviour
{
    public GameObject clickTarget;
    void Update()
    {
        
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            clickTarget.transform.position = mousePos;

        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ennemies")
        {
            foreach (var cow in S_CowBase.Cows)
            {
                if (cow is FriendCow friendCow && friendCow.captureComponent.captured)
                {
                    friendCow.target = collision.gameObject;
                }
                else
                    continue;
            }
        }
    }
}
