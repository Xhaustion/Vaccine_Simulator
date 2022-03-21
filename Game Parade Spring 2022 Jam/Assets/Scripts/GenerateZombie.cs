using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateZombie : MonoBehaviour
{
    public GameObject[] Zombie;
    public int xPos;
    public int yPos;
    public int ZombieCount;
    int randomZombie;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ZombieDrop());
    }
        IEnumerator ZombieDrop()
        {
            while (ZombieCount < 203)
            {
                xPos = Random.Range(-29, 12);
                yPos = Random.Range(-16, 0);
                randomZombie = Random.Range (0, Zombie.Length);
                Instantiate(Zombie[(randomZombie)], new Vector2(xPos, yPos), Quaternion.identity);
                yield return new WaitForSeconds(.001f);
                ZombieCount += 1;
            }
        }
    

}
