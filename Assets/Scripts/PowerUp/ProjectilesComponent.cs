using UnityEngine;

public class ProjectilesComponent : MonoBehaviour
{
   public ProjectilesBase projectilesParent;
    protected virtual void Start()
    {
        projectilesParent = GetComponent<ProjectilesBase>();
    }

}
