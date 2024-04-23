using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private AudioSource audioSource;
    public Slider healthSlider;
    public float maxHealth = 100f; 
    private float currentHealth; 

    public AudioClip hitSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        currentHealth = maxHealth;
        healthSlider.value = currentHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        //  Prevents players from having negative health
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);
        healthSlider.value = currentHealth;

        if (currentHealth <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        // Player Die
        // Play Animation
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            //  Reduces blood volume by 10 points
            TakeDamage(10f);
            audioSource.PlayOneShot(hitSound);
        }
    }
}