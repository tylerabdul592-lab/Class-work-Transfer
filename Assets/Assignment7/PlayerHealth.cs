using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.InputSystem;

public class PlayerHealth : Health

{
   public void Heal (float healthAmount)

   {
        currentHealth += healthAmount; 
        currentHealth = Mathf.Min(currentHealth, maxHealth);
        Debug.Log("Healed! Current Health: " + currentHealth); 
   }


   public override void Die ()

    {
        Debug.Log("Died! Reloading scene...");
        //reloads the currently active scene 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Set initial values for testing
        maxHealth = 100f;
        currentHealth = 50f; // Start at half health so we can test healing
    }

  void Update()
    {
        // Make sure a keyboard is connected before checking input
       if (Keyboard.current != null)
        {
            // Press Up Arrow to heal
            if (Keyboard.current.upArrowKey.wasPressedThisFrame)
            {
                Heal(20f);
            }

            // Press Down Arrow to take damage
            if (Keyboard.current.downArrowKey.wasPressedThisFrame)
            {
                TakeDamage(60f);
            }
        }
    }
} 