using Unity.VisualScripting;
using UnityEngine;

public class CowAttack : S_CowComponent
{
    public bool canAttack = false;
    public bool inRange =false;

    public float attackCooldown;
    AudioSource sound;

    protected override void Start()
    {
        base.Start();

        attackCooldown = parent.Stats.attackSpeed;
        sound = GetComponentInParent<AudioSource>();

    }

    private void Update()
    {
        if(parent.target)
        {
            if (Vector2.Distance(transform.position, parent.target.transform.position) <= parent.Stats.attackRange && parent.target.tag != "Player")
            {
                inRange = true;

                if (canAttack && inRange)
                {
                    if(parent.Stats.attackRange <= 2)
                    {
                        Attack();
                    }
                    else
                    {
                        SkillUse();
                    }    
                }
                parent.movementComponent.canMove = false;

            }
            else

                parent.movementComponent.canMove = true;
                inRange = false;
        }

        if (!canAttack)
        {
            AttackReset();
        }
    }

    void Attack()
    {
        if (parent.target.gameObject.CompareTag("Player"))
        {
            return;
        }
        else

        canAttack = false;
        inRange = true;
        parent.target.GetComponent<S_Stats>().life = parent.target.GetComponent<S_Stats>().life - parent.Stats.dmg;
        parent.target.GetComponent<S_Stats>().LifeUpdate();

        sound.Play();
    }
    void SkillUse()
    {
        if (parent.target.gameObject.CompareTag("Player"))
        {
            return;
        }
        else

            canAttack = false;
        inRange = true;

        parent.skillComponent?.CastingSkill();

        sound.Play();
    }
    void AttackReset()
    {

        attackCooldown -= Time.deltaTime;

        if (attackCooldown <= 0)
        {
            attackCooldown = parent.Stats.attackSpeed;
            canAttack = true;
        }

    }
}
