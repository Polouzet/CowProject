using UnityEngine;
using System.Collections;
public class S_CowAttack : S_CowComponent
{
    public bool canAttack = false;
    public bool attackRange = false;
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

        if (parent.baseTarget!= null)
        {
            if (parent.target)
            {
                if (attackRange && canAttack)
                {
                    Attack();
                }
            }
        }
        if(!canAttack)
        {
            AttackReset();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<S_CowBase>())
        {
            attackRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<S_CowBase>())
        {
            attackRange = false;
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
        TauntUp();

        parent.target.GetComponent<S_Stats>().life = parent.target.GetComponent<S_Stats>().life - parent.Stats.dmg;
        // parent.target.gameObject.GetComponent<Rigidbody2D>().AddForce(parent.gameObject.transform.up * parent.Stats.pushForce,ForceMode2D.Impulse) ;
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

    public void TauntUp()
    {
        parent.Stats.tauntValue = parent.Stats.tauntValue + Random.Range(1, 5);
        print(parent.Stats.tauntValue);
    }
}
