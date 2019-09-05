using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public GameObject astroid;
    public Vector3 randomPos;
    public float waitStarting;
    public float waitCreating;
    public float waitLoop;
    int score = 0;
    public Text text;
    public Text endGameText;
    public Text restartText;

    
    bool gameEndControl = false;
    bool restartControl = false;


	void Start ()
    {
        text.text = "score = " + score;
        StartCoroutine(create());
	}
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && restartControl)
        {
            SceneManager.LoadScene("level1");
            

        }
    }
    IEnumerator create()
    {
        yield return new WaitForSeconds(waitStarting);
        while (true)
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(astroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(waitCreating);
                
            }
            if (gameEndControl )
            {
                restartText.text= "Yeniden Başlamak için 'R' tuşuna basınız...";
                restartControl = true;
                break;
            }
            yield return new WaitForSeconds(waitLoop);
            
        }
        
        

    }
    public void increaseScore(int incomingScore)
    {
        score += incomingScore;
        text.text = "score = " + score;

    }
     public void gameOver()
    {
        endGameText.text = "Oyun Bitti";
        gameEndControl = true;
    }
	
	
	
}
