using UnityEngine;

public class FireBall : ProjectilesComponent
{
    Rigidbody2D fireballRB;
    public GameObject target;

    protected override void Start()
    {
        fireballRB = GetComponent<Rigidbody2D>();
        base.Start();
    }
    private void Update()
    {
        fireballRB.transform.position = Vector2.MoveTowards(transform.position, target.transform.position, projectilesParent.projectilesStatsComponent.forceProjectionSpawn * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.GetComponent<S_CowBase>())
        {
            if (collision.gameObject == target)
            {
                projectilesParent.particle.Play();
                var target = collision.gameObject.GetComponent<S_Stats>();
                target.life = target.life - projectilesParent.projectilesStatsComponent.dmg;
                target.LifeUpdate();
                Destroy(gameObject);
            }
        }

    }

}
