using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTypeLoader : MonoBehaviour
{

    //public GameObject GameSelectorPanel;

    //public Button FPSButton;
    //public Button StrategyButton;

    public GameObject FPSPlayer;
    public GameObject StratPlayer;

    public GameObject StratCamera;
    public GameObject FPSCamera;

    public GameObject FpsController;

    // Start is called before the first frame update
    void Start()
    {
        //FPSButton.onClick.AddListener(FPSClicked);
        //StrategyButton.onClick.AddListener(StratClicked);
        
    }

    void FPSClicked()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
        FPSPlayer.SetActive(true);
        FPSCamera.SetActive(true);
        //GameSelectorPanel.SetActive(false);
    }

    void StratClicked()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the Strat button!");
        //GameSelectorPanel.SetActive(false);
        StratPlayer.SetActive(true);
        StratCamera.SetActive(true);
        Cursor.lockState = CursorLockMode.None;

    }

    // Update is called once per frame
    void Update()
    {
        //fps
        if (Input.GetKeyDown("9"))
        {
            //Output this to console when Button1 or Button3 is clicked
            Debug.Log("You have clicked the button!");
            FPSPlayer.SetActive(true);
            FPSCamera.SetActive(true);
            StratPlayer.SetActive(false);
            StratCamera.SetActive(false);
            FpsController.SetActive(true);
            //GameSelectorPanel.SetActive(false);
        }
        if (Input.GetKeyDown("0"))
        //strat
        {
            //Output this to console when Button1 or Button3 is clicked
            Debug.Log("You have clicked the Strat button!");
            //GameSelectorPanel.SetActive(false);
            StratPlayer.SetActive(true);
            StratCamera.SetActive(true);
            FPSPlayer.SetActive(false);
            FPSCamera.SetActive(false);
            FpsController.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            ;
        }
    }
}
