
using UnityEngine;
using System.Linq;

public class EnemyCow : S_CowBase
{
    public S_Detection detectionComponent;


    public override void Awake()
    {
        base.Awake();

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

                    target = highestTaunter.gameObject;

                }
                if(highestTaunter == null)
                {
                    NewTarget();
                }
            }
        }
    }
}