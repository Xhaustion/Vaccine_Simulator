using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieScript : MonoBehaviour
{
    public GameObject SavedCiv;
    public Transform transform;
    public float Health;
    public float MaxHealth;
    public Slider slider; 
    public GameObject HealthBarUI;
    public GameObject blood;
    [SerializeField] private AudioSource dieSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("AddHealth", 2);
    }

   void AddHealth()
    {
        Health = MaxHealth;
        slider.value = CalculateHealth();
    }
    void Update()
    {
        slider.value = CalculateHealth();
        if (Health < MaxHealth)
        {
            HealthBarUI.SetActive(true);
        }
        if (Health <= 0)
        {
            DestoryZombie();
        }
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag.Equals("Shot"))
        {

           Health = Health-33;
            Destroy(col.gameObject);

        }
        
    }
    void SpawnCiv()
    {
        Vector2 position = transform.position;
        GameObject civ = Instantiate(SavedCiv, position, Quaternion.identity);
        civ.SetActive(true);
    }
    float CalculateHealth()
    {
        return Health / MaxHealth;
    }
    void DestoryZombie()
    {
        Debug.Log ("Destoryed");
        dieSoundEffect.Play();
        Instantiate(blood, transform.position, Quaternion.identity);
        Destroy(gameObject);
        ScoreScript.scoreValue += 01f;
        SpawnCiv();
    }
}
