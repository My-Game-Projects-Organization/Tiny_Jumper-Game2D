using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameGUIManager : Singleton<GameGUIManager>
{
    public GameObject homeGui;
    public GameObject gameGui;
    //
    public Text scoreCoungtingText;
    public Image powerBarSlider;

    public Dialog achievementDialog;
    public Dialog healpDialog;
    public Dialog gameoverDialog;

    public bool upToFill = true;

    public override void Awake()
    {
        MakeSingleton(false);
    }

    public void ShowGui(bool isShow)
    {
        if (gameGui)
        {
            gameGui.SetActive(isShow);
        }

        if (homeGui)
        {
            homeGui.SetActive(!isShow);
        }

    }

    public void UpdateScoreCountingText(int score)
    {
        if (scoreCoungtingText)
        {
            scoreCoungtingText.text = score.ToString();
        }
    }

    public void UpdatePowerBar(float curVal, float totalVal)
    {
        if (powerBarSlider)
        {
            if (upToFill)
            {
                powerBarSlider.fillAmount = curVal / totalVal;
                Debug.Log(powerBarSlider.fillAmount);
                if (powerBarSlider.fillAmount >= 1)
                {
                    upToFill = false;
                }
            }
            else if (!upToFill)
            {
                powerBarSlider.fillAmount = curVal / totalVal;
                Debug.Log(powerBarSlider.fillAmount);
                if (powerBarSlider.fillAmount <= 0)
                {
                    upToFill = true;
                }
            }
            //powerBarSlider.fillAmount = curVal;
            //if (upToFill == true)
            //{
            //    //Reduce fill amount over 30 seconds
            //    powerBarSlider.fillAmount = curVal / totalVal;
            //    //powerBarSlider.fillAmount += curVal / 10f * Time.deltaTime;
            //}

        }

    }

    public void ShowAchievementDialog()
    {
        if (achievementDialog)
        {
            achievementDialog.Show(true);
        }
    }

    public void ShowHelpDialog()
    {
        if (healpDialog)
        {
            healpDialog.Show(true);
        }
    }

    public void ShowGameoverDialog()
    {
        if (gameoverDialog)
        {
            gameoverDialog.Show(true);
        }
    }


}
