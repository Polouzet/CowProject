using UnityEngine;

public class S_CowComponent : MonoBehaviour
{
    protected S_CowBase parent;
    
    void Start()
    {
        parent = GetComponentInParent<S_CowBase>();
    }
}
