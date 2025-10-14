

using System.Linq;

public class EnemyCow : S_CowBase
{
    S_MovementCow movementComponent;
    S_Detection detectionComponent;
    S_CowAttack attackComponenent;

    public override void Start()
    {
        base.Start();

        movementComponent = GetComponent<S_MovementCow>();
        detectionComponent = GetComponent<S_Detection>();
    }

    public override void Update()
    {
        base.Update();

        if (detectionComponent != null)
        {
            if (detectionComponent.vavaches.Count > 0)
            {
                var cows = detectionComponent.vavaches.OrderByDescending(cow => cow.Stats.tauntValue);

                var highestTaunter = cows.First();
                if (highestTaunter != null)
                {
                    baseTarget = highestTaunter.gameObject;
                    NewTarget();
                }
            }


        }

    }


}