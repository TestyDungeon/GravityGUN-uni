using UnityEngine.UI;
using UnityEngine;

public class HealthBarUI : MonoBehaviour
{
    private PlayerHealth playerHealth;
    [SerializeField] private Image fill;

    void Awake()
    {
        if (playerHealth == null)
            playerHealth = FindAnyObjectByType<PlayerHealth>();

    }

    void OnEnable()
    {
        if (playerHealth != null)
        {
            playerHealth.OnHealthChanged += OnHealthChanged;
            Debug.Log("SUBBED");
        }
    }

    void OnDisable()
    {
        if (playerHealth != null)
            playerHealth.OnHealthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(float currentHealth, float maxHealth)
    {
        fill.fillAmount = currentHealth / maxHealth;
        Debug.Log("Health Changed");
    }
}
