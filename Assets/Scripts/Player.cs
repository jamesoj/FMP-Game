using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform player;

    public int currentHealth;
    private int maxHealth = 100;
    bool portal = false;
    private Animator Anim;
    public HP_Bar hp_Bar;
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

    /*private void OnTriggerPickUp(Collider col)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.portal = true;
            Debug.Log("pressed");
        }
    }*/

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Item")
        {
            this.portal = true;
            Debug.Log("pressed");
            Destroy(col.gameObject);
        }

        if (col.tag == "Portal" && this.portal == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
