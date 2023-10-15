using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int MaxHP = 3;
    public int CurrentHP;
    public int score = 0;
    public bool StillAlive = true;
    public LifeIcon LifeIcon;
    public Text timerText;
    //public Text HPText;
    public Text ScoreText;
    private string enemyTag = "enemy";
    [SerializeField] private float TimeManager = 60;



    void OnCollisionEnter(Collision collision) // Health Manager
    {
        Debug.Log("衝突したよ");
        if (StillAlive == true) 
        {
            if(collision.gameObject.CompareTag(enemyTag))
            {
                CurrentHP--;
            }
        }
    }

    void Start()
    {
        CurrentHP = MaxHP;
        LifeIcon.SetLifeGauge(CurrentHP);

    }
    // Update is called once per frame
    void Update()
    {
        if (CurrentHP <= 0)
        {
            StillAlive = false;
            Debug.Log("Dead");
            //SceneManager.LoadScene(ResultScene);
        }

        if (TimeManager <= 0)
        {
            Debug.Log("Finish");
            //SceneManager.LoadScene(ResultScene);
        }

        if (TimeManager >= 0)
        {
            TimeManager -= Time.deltaTime;
        }

        
        
        timerText.text = TimeManager.ToString("00");
        //HPText.text = CurrentHP.ToString();  //HPをアイコンで表示するならこの行を削除
        ScoreText.text = score.ToString();

    }
}
