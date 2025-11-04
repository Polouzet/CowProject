using UnityEngine;

public class S_Stats : S_CowComponent
{
    public float life;
    public float dmg;
    public float speed;
    public float attackRange;
    public float attackSpeed;
    public float tauntValue;
    public GameObject deathparticleprefab;

    public void LifeUpdate()
    {

        var particle = Instantiate<GameObject>(deathparticleprefab, transform.position, Quaternion.identity);

        particle.GetComponent<ParticleSystem>().Play();

        if (life <= 0f)
        {
            parent.death?.Invoke(parent);
            Destroy(gameObject);
        }

    }
}
