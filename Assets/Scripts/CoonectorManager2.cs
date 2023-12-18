using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CoonectorManager2 : MonoBehaviour //this is already a facade
{
    //general value
    public float current_HP;
    public float current_STA;
    public float current_max_STA;

    public float extra_stamina;

    public float UpgradeCost;

    public float AmountUpgrade_A = 1;
    public float AmountUpgraed_B = 2;

    public bool Stamina_Use;
    public bool ItPublish;
    public bool ItDecline;

    public UIController ui;

    //Visitor code
    public PowerUp HP_pw;
    public PowerUp Sta_pw;
    public PowerUp Time_pw;

    private VisitorController _visitorController;

    //Observer Code

    private ObserverController _observerController;

    //Facde code

    private FacadeController _facadeController;

    //Original 
    private StoryController _storyController;
    //window
    [SerializeField] private GameObject UpgradeUI;
    [SerializeField] private GameObject NewsUI; 
    //detail
    public TMP_Text UI_news_text;
    public TMP_Text UI_Story;
    public TMP_Text UI_Story_headline;

    //bool check for news and upgrade UI
    private bool UpgradeUI_on;
    private bool NewsUI_on;

    //sound
    public AudioClip clip;
    public AudioSource source;

    private void Awake()
    {
        _observerController = (ObserverController)FindObjectOfType(typeof(ObserverController)); //observer
        _visitorController = gameObject.AddComponent<VisitorController>(); //visitor
        _facadeController = GetComponent<FacadeController>();
        _storyController = GetComponent<StoryController>();
        

        UpgradeUI_on = false;
        NewsUI_on = false;

        //set up num
        //current_HP = 3;
        //current_STA = 5;
        //current_max_STA = 5;

        ItPublish = false;
        ItDecline = false;
        Stamina_Use = false;
        UpgradeCost = 4;

    }
    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            if (UpgradeUI_on && NewsUI_on == false)
            {
                UpgradeUIClose();
            }
            if (NewsUI_on)
            {
                NewsUIClose();
            }
            //do close All UI -> check by layer
        }
    }

    public void LoadMenuScene() //quit UI
    {
        SceneManager.LoadScene(0);
    }
    #region UI_Close_Open
    public void UpgradeUIOpen()
    {
        UpgradeUI_on = true;
        UpgradeUI.SetActive(true);
    }
    public void UpgradeUIClose()
    {
        UpgradeUI_on = false;
        UpgradeUI.SetActive(false);
    }
    public void NewsUI_Open() //appear after sleep +set up
    {
        NewsUI_on = true;
        NewsUI.SetActive(true);
    }
    public void NewsUIClose()
    {
        NewsUI_on = false;
        NewsUI.SetActive(false);
    }
    #endregion

    #region Visitor_Upgrade 
    public void UpgradeHP() //Upgrade List Button_UI
    {
        //Debug.Log("this is current hp" + current_HP);
        //Debug.Log("this is current stamina" + current_STA);
        //Debug.Log("this is upgrade cost" + UpgradeCost);
        if (current_STA >= UpgradeCost)
        {
            current_STA = current_STA -= UpgradeCost;
            current_HP += AmountUpgrade_A;
            ui.SetHealthUI();
            ui.SetStaminaUI();
            _visitorController.Accept(HP_pw);
            //Debug.Log("after this is current stamina" + current_STA);
            //Debug.Log("after this is current hp" + current_HP);
        }
        else
            return ;
    }
    public void UpgradeStamina()
    {
        //Debug.Log("this is current stamina" + current_STA);
        //Debug.Log("this is current max stamina" + current_max_STA);
        if (current_STA >= UpgradeCost)
        {
            current_STA = current_STA -= UpgradeCost;
            current_max_STA += AmountUpgraed_B;
            ui.SetStaminaUI();
            _visitorController.Accept(Sta_pw);
            //Debug.Log("after this is current stamina" + current_STA);
            //Debug.Log("after this is current max stamina" + current_max_STA);
        }
        else
            return;
    }
    public void UpgradeTimeDuration() //unuse
    {
        _visitorController.Accept(Time_pw);
    }
    #endregion

    public void SleepBtn()
    {
        //check for panalty
        if(Stamina_Use == false)
        {
            current_HP--;
        }

        //reset
        Stamina_Use = false;
        _observerController.SetUI();
        current_STA = current_max_STA + extra_stamina;
        _facadeController.UnlockedBtn();
        
    }

    public void UpdateStamina_Func()
    {
        current_STA -= 1;
        Stamina_Use = true;
        ui.SetStaminaUI();
    }

    public void CheckIfStamina()
    {
        if (current_STA <= 0)
        {
            _facadeController.LockedBtn();
        }
        else
        {
            _facadeController.UnlockedBtn();
        }
    }

    public void StoryRoll()
    {
        NewsUI_Open();
        _storyController.NewStory();
    }

    public void PublishBtn() //accept
    {
        ItPublish = true;
        UpdateStamina_Func();
        CheckIfStamina();
        StoryRoll();
    }
    public void DeclineBtn() //decline
    {
        ItDecline = true;
        UpdateStamina_Func();
        CheckIfStamina();
        StoryRoll();
    }
}
