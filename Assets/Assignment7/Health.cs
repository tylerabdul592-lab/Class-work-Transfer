using UnityEngine;

public class Health : MonoBehaviour
{ public float currentHealth; 
  public float maxHealth; 
    
    public void TakeDamage (float damageAmount)

    { 
        currentHealth -= damageAmount; 

        if (currentHealth <= 0) 
        {
            Die (); 
        }
    }

    public virtual void Die()

    {
        Destroy (gameObject); 
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
