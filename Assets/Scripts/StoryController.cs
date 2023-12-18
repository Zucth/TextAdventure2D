using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoryController : MonoBehaviour
{
    //Decorator code

    private DecoratorController _decoratorController;
    private bool _isTraitDecorate;

    public TraitAttachment GoodKarmaAttach;
    public TraitAttachment BadKarmaAttach;
    public TraitAttachment NoKarmaAttach;

    //normal

    private CoonectorManager2 coonector;

    public string story_1; //marry and the frog
    public string story_2; //stop

    public string storyhead_1;
    public string storyhead_2; //stop

    public string story_1_news_good;
    public string story_1_news_bad;
    public string story_2_news_good; //stop
    public string story_2_news_bad; //stop

    private int R_num;

    private void Awake()
    {
        coonector = GetComponent<CoonectorManager2>();
        _decoratorController = (DecoratorController)FindObjectOfType(typeof(DecoratorController));
    }
    public void RollTheDice()
    {
        R_num = Random.Range(0, 100);
    }
    public void InsertNewStory()
    {
        //coonector.UI_Story.SetActive(true);
    }
    public void NewStory()
    {
        RollTheDice();
        if(R_num <= 50)
        {
            //story, head = 1
            coonector.UI_Story.text = story_1.ToString();
            coonector.UI_Story_headline.text = storyhead_1.ToString();

            if (coonector.ItPublish)
            {
                //do new 1_1
                coonector.UI_news_text.text = story_1_news_bad;
                _decoratorController.traitAttachment = BadKarmaAttach;
            }
            else if (coonector.ItDecline)
            {
                //do new 1_2
                coonector.UI_news_text.text = story_1_news_good;
                _decoratorController.traitAttachment = GoodKarmaAttach;
            }
            coonector.ItDecline = false;
            coonector.ItPublish = false;
            _decoratorController.Decorate();
        }
        else if (R_num >= 51)
        {
            //story, head = 2
            coonector.UI_Story.text = story_2.ToString();
            coonector.UI_Story_headline.text = storyhead_2.ToString();

            if (coonector.ItPublish)
            {
                //do new 2_1
                coonector.UI_news_text.text = story_2_news_good;
                _decoratorController.traitAttachment = GoodKarmaAttach;
            }
            else if (coonector.ItDecline)
            {
                //do new 2_2
                coonector.UI_news_text.text = story_2_news_bad;
                _decoratorController.traitAttachment = NoKarmaAttach;
            }
            coonector.ItDecline = false;
            coonector.ItPublish = false;
            _decoratorController.Decorate();
        }
        else
            return;
    }
}

