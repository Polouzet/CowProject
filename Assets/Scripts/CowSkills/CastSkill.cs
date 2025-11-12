using UnityEngine;
using UnityEngine.Rendering;

public class CastSkill : S_CowComponent
{
    public GameObject fireCowProj;
    public void CastingSkill()
    {
        if (gameObject.tag == "FireCow")
        {
            fireCowProj.GetComponent<FireBall>().target = parent.target;
            Instantiate(fireCowProj,new Vector2(parent.gameObject.transform.position.x,parent.gameObject.transform.position.y),Quaternion.identity);

        }
    }
}
