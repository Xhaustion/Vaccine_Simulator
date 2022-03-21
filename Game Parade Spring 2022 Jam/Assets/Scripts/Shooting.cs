using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject shotPrefab;
    public float shotForce = 20f;
    [SerializeField] private AudioSource shootSoundEffect;

    private Shake shake;
    // Update is called once per frame
    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent <Shake>();
    }
    void Update()
    {
        if (!PauseMenu.isPaused)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }
    }
    void Shoot()
    {
        //shake.CamShake();
        //SoundMangerScript.PlaySound("Shoot");
        shootSoundEffect.Play();
        GameObject shot = Instantiate(shotPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = shot.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * shotForce, ForceMode2D.Impulse) ;
    }
}
