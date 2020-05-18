using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextLevelAdvanced : MonoBehaviour
{

    public int levelNumber;
    private int toNextLevelAdvanced;

    // Start is called before the first frame update
    void Start()
    {
        toNextLevelAdvanced = SceneManager.GetActiveScene().buildIndex + levelNumber;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(toNextLevelAdvanced);
    }
}
