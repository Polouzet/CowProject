using UnityEngine;

public class S_CowCapture : S_CowComponent
{
    public bool captured = false;
    public bool canCapture = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && captured == false)
        {
            gameObject.GetComponent<FriendCow>().captureComponent.captured = true;
            parent.baseTarget = collision.gameObject;
            parent.NewTarget();

            PlayerStats player = collision.gameObject.GetComponent<PlayerStats>();
            player.myCows.Add(parent);
        }
    }
}
