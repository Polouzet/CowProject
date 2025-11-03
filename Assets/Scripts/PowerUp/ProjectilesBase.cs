using UnityEngine;

public class ProjectilesBase : MonoBehaviour
{
 public ProjectilesStats projectilesStatsComponent;
 public ParticleSystem particle;
 

    public virtual void Awake()
    {
        projectilesStatsComponent = GetComponent<ProjectilesStats>();
        particle = GetComponent<ParticleSystem>();
    }
    public virtual void Update()
    {

    }

}
