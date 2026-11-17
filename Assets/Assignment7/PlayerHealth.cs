using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerHealth : Health

{
   public void Heal (float healthAmount)

   {
        currentHealth += healthAmount; 
        currentHealth = Mathf.Min(currentHealth, maxHealth);
   }


   public override void Die ()

    {
        //reloads the currently active scene 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
