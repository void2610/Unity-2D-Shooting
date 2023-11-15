using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject scoreText;
    private Text scoreTextComponent;
    private int score = 0;

    public int GetScore()
    {
        return score;
    }

    public void AddScore(int score)
    {
        this.score += score;
    }

    public static GameManager instance = null;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        scoreTextComponent = scoreText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTextComponent.text = "Score: " + score;
    }
}
