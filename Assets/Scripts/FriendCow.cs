using UnityEngine;

public class FriendCow : S_CowBase
{
    S_CowMove movementComponent;
    S_CowAttack attackComponenent;
    S_CowCapture captureComponent;

    public override void Start()
    {
        base.Start();

        movementComponent = GetComponent<S_CowMove>();
        captureComponent = GetComponent<S_CowCapture>();
    }

    public override void Update()
    {
        base.Update();
    }
}
