using System.Collections;
using UnityEngine;

public class S_EnnemiesAttack : MonoBehaviour
{
    S_Stats stats;
    bool canAttack = false;
    bool attackEnd = true;
    S_Stats targetStats;
    AudioSource sound;
    void Start()
    {
        stats = GetComponentInParent<S_Stats>();
        sound = GetComponentInParent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            canAttack = true;
            targetStats = collision.gameObject.GetComponent<S_Stats>();
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
        attackEnd = false;
        StartCoroutine(AttackTimer()); 
        AttackTimer();               
        }
  
    }

    IEnumerator AttackTimer()
    {
        targetStats.life = targetStats.life - stats.dmg;
        targetStats.LifeUpdate();
        sound.Play();
        yield return new WaitForSeconds(stats.attackSpeed);
        Attack();
        attackEnd = true;
    }
}
