using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController Instance;

    public float scrollSpeed = -1.5f;
    public bool isGameOver = false;
    private int score = 0;

    public Text scoreText;
    public GameObject gameOverText;

    // Use this for initialization
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {	
    	// Scene affichant le texte "T'as Perdu"
        if(isGameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void Score()
    {
    	// Calcul du score
        if(isGameOver) { return; }

        score++;
        scoreText.text = "Votre score : " + score;
    }

    public void Die()
    {	
    	// Fonction mourrir
        gameOverText.SetActive(true);
        isGameOver = true;
    }
}
