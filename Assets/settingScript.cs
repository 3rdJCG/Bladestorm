using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingScript : MonoBehaviour
{
    [SerializeField] GameObject BannerOdd;
    [SerializeField] GameObject BannerEven;
    [SerializeField] GameObject SettingOverlay;
    [SerializeField] GameObject BannerGamecount;
    [SerializeField] GameObject BannerBackground;

    [SerializeField] Text Matchname;
    [SerializeField] Text TeamnameDEF;
    [SerializeField] Text TeamnameATK;
    [SerializeField] Text GamecountDEF;
    [SerializeField] Text GamecountATK;

    [SerializeField] InputField InputMatchname;
    [SerializeField] InputField InputDEF;
    [SerializeField] InputField InputATK;

    [SerializeField] Button ButtonClose;
    [SerializeField] Button ButtonShutdown;
    [SerializeField] Button ButtonChange;
    [SerializeField] Button ButtonTeamToggle;
    [SerializeField] Button ButtonGamecount;
    [SerializeField] Button ButtonGamecountDEFplus;
    [SerializeField] Button ButtonGamecountDEFminus;
    [SerializeField] Button ButtonGamecountATKplus;
    [SerializeField] Button ButtonGamecountATKminus;
    [SerializeField] Button ButtonBackground;

    public int gamecntDEF = 0;
    public int gamecntATK = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Screen.SetResolution(1920, 1080, true, 60);
        Application.targetFrameRate = 60;

        BannerOdd.SetActive(true);
        BannerEven.SetActive(false);
        BannerGamecount.SetActive(false);
        BannerBackground.SetActive(true);

        SettingOverlay.SetActive(true);

        ButtonClose.GetComponent<Button>().onClick.AddListener(settingToggle);
        ButtonShutdown.GetComponent<Button>().onClick.AddListener(shutdown);
        ButtonTeamToggle.GetComponent<Button>().onClick.AddListener(teamnameToggle);
        ButtonChange.GetComponent<Button>().onClick.AddListener(bannerToggle);
        ButtonGamecount.GetComponent<Button>().onClick.AddListener(gamecountToggle);
        ButtonBackground.GetComponent<Button>().onClick.AddListener(backgroundToggle);
        ButtonGamecountDEFplus.GetComponent<Button>().onClick.AddListener(gamecountDEFplus);
        ButtonGamecountDEFminus.GetComponent<Button>().onClick.AddListener(gamecountDEFminus);
        ButtonGamecountATKplus.GetComponent<Button>().onClick.AddListener(gamecountATKplus);
        ButtonGamecountATKminus.GetComponent<Button>().onClick.AddListener(gamecountATKminus);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F10))
        {
            settingToggle();
        }

        bannerRefresh();
    }

    void bannerRefresh()
    {
        Matchname.text = InputMatchname.text;
        TeamnameDEF.text = InputDEF.text;
        TeamnameATK.text = InputATK.text;
        
        GamecountDEF.text = Convert.ToString(gamecntDEF);
        GamecountATK.text = Convert.ToString(gamecntATK);
    }

    void shutdown()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
        UnityEngine.Application.Quit();
#endif
    }

    void settingToggle()
    {
        SettingOverlay.SetActive(!SettingOverlay.activeSelf);
    }

    void bannerToggle()
    {
        BannerOdd.SetActive(!BannerOdd.activeSelf);
        BannerEven.SetActive(!BannerEven.activeSelf);
    }

    void teamnameToggle()
    {
        Text textTmpDEF = TeamnameDEF.GetComponent<Text>();
        Text textTmpATK = TeamnameATK.GetComponent<Text>();

        int TmpGamecntDEF = gamecntDEF;
        int TmpGamecntATK = gamecntATK;

        InputDEF.text = textTmpATK.text.ToString();
        InputATK.text = textTmpDEF.text.ToString();

        gamecntDEF = TmpGamecntATK;
        gamecntATK = TmpGamecntDEF;
    }

    void gamecountToggle()
    {
        BannerGamecount.SetActive(!BannerGamecount.activeSelf);
    }

    void backgroundToggle()
    {
        BannerBackground.SetActive(!BannerBackground.activeSelf);
    }

    void gamecountDEFplus()
    {
        gamecntDEF++;
    }

    void gamecountDEFminus()
    {
        gamecntDEF--;
    }

    void gamecountATKplus()
    {
        gamecntATK++;
    }

    void gamecountATKminus()
    {
        gamecntATK--;
    }
}
