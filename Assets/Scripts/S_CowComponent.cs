using UnityEngine;

public class S_CowComponent : MonoBehaviour
{
    protected S_CowBase parent;
    
   protected virtual void Start()
    {
        parent = GetComponentInParent<S_CowBase>();
    }
}
