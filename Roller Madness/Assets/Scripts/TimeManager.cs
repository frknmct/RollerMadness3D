using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public bool gameFinished = false;
    [SerializeField] private float levelFinishTime = 5f;
    public bool gameOver = false;
    [SerializeField] private Text timeText;

    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject losePanel;

    [SerializeField] private List<GameObject> destroyAfterGame = new List<GameObject>();
    void Start()
    {
        
    }

    
    void Update()
    {
        if (gameFinished == false && gameOver == false)
        {
            UpdateTheTimer();
        }
        
        
        if (Time.timeSinceLevelLoad >= levelFinishTime && gameOver == false)
        {
            gameFinished = true;
            winPanel.gameObject.SetActive(true);
            losePanel.gameObject.SetActive(false);
            UpdateObjectList("Objects");
            UpdateObjectList("Enemy");
            foreach (GameObject allobjects in destroyAfterGame)
            {
                Destroy(allobjects);
            }
        }

        if (gameOver == true)
        {
            losePanel.gameObject.SetActive(true);
            winPanel.gameObject.SetActive(false);
            UpdateObjectList("Objects");
            UpdateObjectList("Enemy");
            foreach (GameObject allobjects in destroyAfterGame)
            {
                Destroy(allobjects);
            }
        }
    }

    private void UpdateObjectList(string tag)
    {
        destroyAfterGame.AddRange(GameObject.FindGameObjectsWithTag(tag));
    }
    private void UpdateTheTimer()
    {
        timeText.text = "Time: " + (int)Time.timeSinceLevelLoad;
    }
    
}
