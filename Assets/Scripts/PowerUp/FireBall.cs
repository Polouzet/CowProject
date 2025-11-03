using UnityEngine;

public class FireBall : ProjectilesComponent
{
    

    protected override void Start()
    {
        base.Start();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        projectilesParent.particle.Play();
        if (collision.gameObject.GetComponent<S_CowBase>())
        {
            var target = collision.gameObject.GetComponent<S_Stats>();
            target.life = target.life - projectilesParent.projectilesStatsComponent.dmg;
            target.LifeUpdate();
            Destroy(gameObject);
        }

    }

}
