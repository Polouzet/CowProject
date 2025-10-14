using UnityEngine;
using System.Collections;
public class S_CowAttack : S_CowComponent
{
    bool canAttack = false;
    bool attackEnd = true;
    AudioSource sound;
    GameObject target;
    protected override void Start()
    {
        base.Start();

        sound = GetComponentInParent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ennemies")
        {
            target = collision.gameObject;
            canAttack = true;
            if (attackEnd)
            {
            Attack();                
            }

        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        canAttack = false;
    }
     void Attack()
    {
        if (canAttack)
        {
            StartCoroutine(AttackTimer());
            TauntUp();
            AttackTimer();               
        }
    }

    IEnumerator AttackTimer()
    {
        target.GetComponent<S_Stats>().life = target.GetComponent<S_Stats>().life - parent.Stats.dmg;
        target.GetComponent<S_Stats>().LifeUpdate();

        sound.Play();

        yield return new WaitForSeconds(parent.Stats.attackSpeed);
        Attack();
    }

    public void TauntUp()
    {
        parent.Stats.tauntValue = parent.Stats.tauntValue + Random.Range(1, 5);
        print(parent.Stats.tauntValue);
    }
}
