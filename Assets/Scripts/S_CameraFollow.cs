using UnityEngine;

public class S_CameraFollow : MonoBehaviour
{
    public GameObject playerTarget;
    float followDistance = 0;
    float baseSpeed;
    public float speed;


    void Start()
    {
        baseSpeed = speed;
    }
    void Update()
    {
        if (Vector2.Distance(transform.position, playerTarget.transform.position) > followDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerTarget.transform.position, speed * Time.deltaTime);
            transform.position.z.Equals(-10f);
        }
    }
}
