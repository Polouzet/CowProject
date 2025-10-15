using UnityEngine;

public class FriendCow : S_CowBase
{
    public S_CowCapture captureComponent;

    public override void Awake()
    {
        base.Awake();


        captureComponent = GetComponent<S_CowCapture>();

    }

    public override void Update()
    {
        base.Update();
    }
}
