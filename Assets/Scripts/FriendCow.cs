using UnityEngine;

public class FriendCow : S_CowBase
{
    S_MovementCow movementComponent;
    S_CowAttack attackComponenent;
    public S_CowCapture captureComponent;

    public override void Start()
    {
        base.Start();

        movementComponent = GetComponent<S_MovementCow>();
        captureComponent = GetComponent<S_CowCapture>();

    }

    public override void Update()
    {
        base.Update();
    }
}
