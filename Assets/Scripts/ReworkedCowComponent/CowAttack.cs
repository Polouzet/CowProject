using Unity.VisualScripting;
using UnityEngine;

public class CowAttack : S_CowComponent
{
    public bool canAttack = false;

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

        if (parent.target != null)
        {
            if (parent.target)
            {
                if (canAttack)
                {
                    Attack();
                }
            }
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

        parent.target.GetComponent<S_Stats>().life = parent.target.GetComponent<S_Stats>().life - parent.Stats.dmg;
        parent.target.GetComponent<S_Stats>().LifeUpdate();

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
