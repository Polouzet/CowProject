using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class S_MouseClickEvent : MonoBehaviour
{
    public GameObject target;
    public GameObject targetToAttack;
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            target.transform.position = mousePos;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ennemies")
        {
            targetToAttack = collision.gameObject;
        }
    }
}
