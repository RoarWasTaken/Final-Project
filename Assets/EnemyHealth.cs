using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public float health;
    public float maxHealth;
    public GameObject healthBarUI;
    public Slider slider;
    public GameObject coin;
    public ParticleSystem blood;
    

    public void DeductHealth(float deductHealth)
    {
        health -= deductHealth;
    }


    private void Start()
    {
        health = maxHealth;
        slider.value = CalculateHealth();
    }

    private void Update()
    {
        slider.value = CalculateHealth();

        if(health < maxHealth)
        {
            healthBarUI.SetActive(true);
        }

        if(health <= 0)
        {
            Instantiate(blood, transform.position, Quaternion.identity);
            Destroy(gameObject);
          
            
            
            coin = Instantiate(coin, transform.position, rotation: Quaternion.EulerRotation(80f, y: 0, z: 0));
        }

        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }
    float CalculateHealth()
    {
        return health / maxHealth;
    }
}
