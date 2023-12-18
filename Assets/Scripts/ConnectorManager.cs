using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConnectorManager : MonoBehaviour //use to connect UI together
{
    [SerializeField] private GameObject OptionUI;
    //Load Scene

    private bool OptionOn;

    private void Awake()
    {
        OptionOn = false;
    }
    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            CloseOption();
        }
    }


    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //Option UI
    public void OpenOption()
    {
        OptionUI.SetActive(true);
        OptionOn = true;
    }
    public void CloseOption()
    {
        if (OptionOn)
        {
            OptionUI.SetActive(false);
            OptionOn = false;
        }
    }
    //Exit Game
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
