using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform player;

    public int currentHealth;
    private int maxHealth = 100;
    private Animator Anim;
    public HP_Bar hp_Bar;
    public Heath_Pickup heath_Pickup;
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        hp_Bar.SetMaxHealth(maxHealth);
        Anim = gameObject.GetComponent<Animator>();
    }

    public void TakeDamage(int amount)
    {
        if (Anim.GetBool("IsBlocking") == false)
        {
            currentHealth -= amount;
            hp_Bar.Sethealth(currentHealth);
            if (currentHealth <= 0)
                Die();

        }

    }

    private void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Portal" && this.count == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void Heal()
    {

        if (currentHealth < 75)
        {
            currentHealth += 25;
        }
        else
        {
            currentHealth = maxHealth;
        }
        hp_Bar.Sethealth(currentHealth);
    }
}
