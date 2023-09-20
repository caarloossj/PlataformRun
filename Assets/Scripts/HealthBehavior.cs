using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthBehavior : MonoBehaviour
{
    [SerializeField]
    private float maxhealth;

    [SerializeField]
    private float health;

    public UnityEvent<float> OnChangeHealth;
    public UnityEvent<float> OnStartHealth;
    public UnityEvent OnDie;


    private void Start()
    {
        health = maxhealth;
        OnStartHealth.Invoke(health);
    }


    public float GetMaxHealth()
    {
        return maxhealth;
    }

    public float GetCurrenthealth()
    {
        return health;
    }

    public void Hurt(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            OnDie.Invoke();
            health = 0;
        }

        OnChangeHealth.Invoke(health);
    }

    public void Heal(int heal)
    {
        health += heal;
        if (health > maxhealth)
            health = maxhealth;
        OnChangeHealth.Invoke(health);
    }
}
