using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
 
    public int currentHealth = 50;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;

 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Health" && currentHealth == 40)
        {
            heart5.SetActive(true);
            currentHealth = currentHealth + 10;
        }

        if (collision.gameObject.tag == "Health" && currentHealth == 30)
        {
            heart4.SetActive(true);
            currentHealth = currentHealth + 10;
        }

        if (collision.gameObject.tag == "Health" && currentHealth == 20)
        {
            heart3.SetActive(true);
            currentHealth = currentHealth + 10;
        }

        if (collision.gameObject.tag == "Health" && currentHealth == 10)
        {
            heart2.SetActive(true);
            currentHealth = currentHealth + 10;
        }

        if (collision.gameObject.tag == "Health" && currentHealth == 0)
        {
            heart1.SetActive(true);
            currentHealth = currentHealth + 10;
        }

        if (collision.gameObject.tag == "Enemy")
        {
            currentHealth = currentHealth - 10;
        }

        if (currentHealth == 40)
        {
            heart5.SetActive(false);
        }

        if (currentHealth == 30)
        {
            heart4.SetActive(false);
        }

        if (currentHealth == 20)
        {
            heart3.SetActive(false);
        }

        if (currentHealth == 10)
        {
            heart2.SetActive(false);
        }

        if (currentHealth == 0)
        {
            heart1.SetActive(false);
            FindObjectOfType<GameManager>().gameOver();

        }
    }

}
