using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpPanel : MonoBehaviour
{
    
    public GameObject globalEventPanel;
    public GameObject pauseButton;
    public Text yearText;
    public float yearFloat = 1800;
    public float year;

    public void Start(){
        globalEventPanel.SetActive(false);
    }

    public void FixedUpdate()
    {
        if(yearText.text == "" + 1802)  // global event in 1802
        {
            globalEventPanel.SetActive(true);
            pauseButton.SetActive(false);
            Time.timeScale = 0;
        }
    }

    public void ExitPopUp()
    {
        globalEventPanel.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1;
        //TODO: Doesnt exit pop-up because it is caught in Update() method continually and will never fully enter ExitPopUp()
    }
}
