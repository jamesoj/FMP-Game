using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Demon : MonoBehaviour, IEnemy
{
    private Animator Anim;
    public LayerMask aggroLayerMask;
    public float currentHealth;
    public float maxHealth;

    private Player player;
    private NavMeshAgent navAgent;
    private Collider[] withinAggroColliders;

    void Start()
    {
        Anim = GetComponent<Animator>();
        navAgent = GetComponent<NavMeshAgent>();
        currentHealth = maxHealth;
    }

    void FixedUpdate()
    {
        withinAggroColliders = Physics.OverlapSphere(transform.position, 7, aggroLayerMask);
        if (withinAggroColliders.Length  > 0 && currentHealth > 0)
        {
            ChasePlayer(withinAggroColliders[0].GetComponent<Player>());
        }
        else
        {
            Anim.SetBool("IsWalking", false);
            Anim.SetBool("Base_Attack", false);
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
            Die();
    }

    void ChasePlayer(Player player)
    {
        navAgent.SetDestination(player.transform.position);
        this.player = player;
        Anim.SetBool("IsWalking", true);

        if (navAgent.remainingDistance <= navAgent.stoppingDistance)
        {
            
            if (!IsInvoking("Base_Attack"))

                Anim.SetBool("IsWalking", false);
                Anim.SetBool("Base_Attack", true);
            
        
        }
        else
        {
            Anim.SetBool("Base_Attack", false);
        }
    }

    void Die()
    {

        Anim.SetBool("IsDead", true);
        //Destroy(gameObject);
    }
}
