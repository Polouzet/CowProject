using UnityEngine;

public class S_Stats : MonoBehaviour
{
    public float life;
    public float dmg;
    public float speed;
    public float attackRange;
    public float pushForce;
    public int tauntValue;
    public float attackSpeed;
    public void LifeUpdate()
    {
        if (life <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
