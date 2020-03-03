using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YearCount : MonoBehaviour
{
    public Button fastForwardButton;
    public Text yearText;
    public float yearFloat = 1800;
    public float year;
    public bool hasBeenClicked = false;

    void Start(){
        Button btn = fastForwardButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void Update()
    {
        if(hasBeenClicked)
        {
            UpdateYearFastForwardUI();
        } else {
            UpdateYearUI();
        }
        
    }

    public void TaskOnClick()
    {
        hasBeenClicked = !hasBeenClicked;
    }

    public void UpdateYearUI()
    {
        yearFloat += Time.deltaTime * 1/2; //one year = 2 seconds
        year = Mathf.RoundToInt(yearFloat);
        yearText.text = "" + year;
    }

    public void UpdateYearFastForwardUI()
    {
        yearFloat += Time.deltaTime * 1/2 * 5; //5 year = 2 seconds
        year = Mathf.RoundToInt(yearFloat);
        yearText.text = "" + year;
    }
    
}
