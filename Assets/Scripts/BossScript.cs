using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public int bossHealth = 50;

    public Transform[] spots;
    public float speed;
    public Transform[] holes;
    public GameObject projectile;
    public GameObject player;
    Vector3 playerPos;

    public Sprite[] sprites;

    public GameObject boss;
    public GameObject defeatedBoss;
    public GameObject finalHitAnimation;
    public GameObject bossTalk;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine("Boss");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Health

        if (collision.gameObject.tag == "Player")
        {
            bossHealth = bossHealth - 10;
        }

        // Death

        if (bossHealth == 0)
        {
            finalHitAnimation.SetActive(true);
            boss.SetActive(false);
            defeatedBoss.SetActive(true);
        }

    }

    IEnumerator Boss()
    {
        int x = 1;

        while (x == 1)
        {

            // First attack

            yield return new WaitForSeconds(1f);

            int i = 0;

            while (i < 10)
            {
                GameObject bullet = (GameObject)Instantiate(projectile, holes[Random.Range(0, 3)].position, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = Vector2.left * 50;
                i++;
                yield return new WaitForSeconds(.7f);
            }

            // Second attack

            yield return new WaitForSeconds(1f);

            int a = 0;

            while (a < 10)
            {
                GameObject bullet = (GameObject)Instantiate(projectile, holes[Random.Range(0, 3)].position, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * 50;
                a++;
                yield return new WaitForSeconds(.7f);
            }

            int j = 0;

            while (j < 10)
            {
                GameObject bullet = (GameObject)Instantiate(projectile, holes[Random.Range(0, 3)].position, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * 50;
                j++;
                yield return new WaitForSeconds(.7f);
            }
        }
    }
   
}
