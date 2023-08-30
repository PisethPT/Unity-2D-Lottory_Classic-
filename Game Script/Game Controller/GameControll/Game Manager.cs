using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public  int state, index;
    [SerializeField] private Image[] selectedOpt6;
    [SerializeField] private Sprite[] Balls;
    [SerializeField] private GameObject startBtn;
    private List<int> Ball = new List<int>();
    [SerializeField] private GameObject BallTrue;
    [SerializeField] private Image BallImage;
    [SerializeField] private Image[] BallsAfterShakeOpt6;
    [SerializeField] private Image[] BallsAfterShakeOpt3;
    [SerializeField] private Sprite BallAfterDefualt;
    private List<int> ballsValues = new List<int>();
    [SerializeField] private Image[] selectedOpt3;
    [SerializeField] private GameObject[] resultPanelOpt;
    [SerializeField] private GameObject[] selectionOpt;
    private int BallSelectStart;
    public int valueOfBallOpt;
    [SerializeField] private Animator Opt;
    private bool isOpt;
    [SerializeField] private Text[] optTxt;
    [SerializeField] private Button[] buttonsGroup;
    private int match;
    [SerializeField] private Text[] matchText6;
    [SerializeField] private Text[] matchText3;
    [SerializeField] private GameObject table, table6Match, table3Match;
    [SerializeField] private Transform HandleShake;
    [SerializeField] private float HandleShakeSpeed;
    private float SpeedSet;
    [SerializeField] private float Subtra;
    private bool IsPlay;
    [SerializeField] private GameObject feelingPanel, resultPanel;
    [SerializeField] public GameObject Roud, handle1, handle2, handle3;
    [SerializeField] private Button levelGame;
    [SerializeField] public List<BallsGroup> BallsGroups;
    // set position
    float yPos = 2f;
    float xPos = -5f;
    [SerializeField] GameObject hand, wait;
    [SerializeField] Animator handOnclick;
    [SerializeField] public int ptsNum;
    public int ValueText;
    [SerializeField] public int PTSValues;
    int v = 0;
    [SerializeField] Slider[] sd;
    public int level = 0;
    [SerializeField] GameObject[] slider;
    [SerializeField] Text[] ptsText;
    [SerializeField] Sprite[] background;
    [SerializeField] GameObject lab;
    [SerializeField] Image backgroundImage;

    // Start is called before the first frame update
    void Start()
    {
       // FindAnyObjectByType<SavingData>().SaveProgressScore();
        for (int i = 0; i < sd.Length; i++)
        {
            sd[i].enabled = false;
        }
        sd[level].value = PlayerPrefs.GetInt("Score");
        level = PlayerPrefs.GetInt("Level");
        PTSValues = PlayerPrefs.GetInt("Score");
        if (PTSValues < 5000)
        {
            backgroundImage.sprite = background[0];
            ValueText = PTSValues;
            ptsText[level].text = ValueText.ToString();
        }else if ((PTSValues​ - 10000) < 10000 && PTSValues > 5000)
        {
            backgroundImage.sprite = background[1];
            lab.SetActive(false);
            ValueText = PTSValues​ - 5000;
            level = 1;
            sd[0].value = 0;
            slider[0].SetActive(false);
            slider[level].SetActive(true);
            sd[level].minValue = 0;
            sd[level].maxValue = 10000;
            sd[level].value = ValueText;
            print("last sd:" + ValueText);
            //  ValueText = PlayerPrefs.GetInt("Value");
            ptsText[level].text = ValueText.ToString();

        }
        else if ((PTSValues​ - 500000) < 500000 && PTSValues > 10000)
        {
            backgroundImage.sprite = background[2];
            ValueText = PTSValues​ - 15000;
            level = 2;
            sd[1].value = 0;
            slider[1].SetActive(false);
            slider[level].SetActive(true);
            sd[level].minValue = 0;
            sd[level].maxValue = 500000;
            sd[level].value = ValueText;
            print("last sd:" + ValueText);
            //  ValueText = PlayerPrefs.GetInt("Value");
            ptsText[level].text = ValueText.ToString();

        }
        else if ((PTSValues​ - 100000000) < 100000000 && PTSValues > 500000)
        {
            backgroundImage.sprite = background[3];
            lab.SetActive(false);
            ValueText = PTSValues​ - 515000;
            level = 3;
            sd[2].value = 0;
            slider[2].SetActive(false);
            slider[0].SetActive(false);
            slider[1].SetActive(false);
            slider[level].SetActive(true);
            sd[level].minValue = 0;
            sd[level].maxValue = 10000000;
            sd[level].value = ValueText;
            print("last sd:" + ValueText);
            //  ValueText = PlayerPrefs.GetInt("Value");
            ptsText[level].text = ValueText.ToString();

        }
        else if (sd[3].value.Equals(10000000))
        {
            level = 0;
            PTSValues = 0;
            ValueText = 0;
            GameRestart();
        }
        // CheckGameLevelCondition();
        sd[level].value = ValueText;
        print("valueText: " + ValueText+" level: "+level);
      //  sd[level].enabled = false;
        hand.SetActive(true);
        wait.SetActive(true);
        handOnclick.Play("hand");
        FindAnyObjectByType<AudioManage>().musicPlay("background1");
        feelingPanel.SetActive(true);
        resultPanel.SetActive(true);
        buttonGroup(false, 0);
        SpeedSet = HandleShakeSpeed;
        Roud.GetComponent<BoxCollider2D>().isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        FindAnyObjectByType<SavingData>().SaveProgressScore();
        for (int i = 0; i < sd.Length; i++)
        {
            sd[i].enabled = false;
        }
        StartShake();
        if (PTSValues < 5000 && level == 0)
        {
            backgroundImage.sprite = background[0];
            ValueText = PTSValues;
            ptsText[level].text = ValueText.ToString();
        }

        if (sd[0].value.Equals(5000) && level == 0)//PTSValues.Equals(5000) || (PTSValues >5000 && PTSValues<10000)
        {
            backgroundImage.sprite = background[1];
            lab.SetActive(false);
            ValueText = PTSValues​ - 5000;
            level = 1;
            sd[0].value = 0;
            sd[0].enabled = false;
            slider[0].SetActive(false);
            slider[level].SetActive(true);
            sd[level].minValue = 0;
            sd[level].maxValue = 10000;
            sd[level].value = ValueText;
            print("1: "+ValueText);
          //  ValueText = PlayerPrefs.GetInt("Value");
            ptsText[level].text = ValueText.ToString();

        }
        else if (sd[1].value.Equals(10000) && level == 1)
        {
            backgroundImage.sprite = background[2];
            ValueText = PTSValues​ - 15000;
            level = 2;
            sd[1].value = 0;
            slider[1].SetActive(false);
            slider[level].SetActive(true);
            sd[level].minValue = 0;
            sd[level].maxValue = 500000;
            sd[level].value = ValueText;
            //  ValueText = PlayerPrefs.GetInt("Value");
            ptsText[level].text = ValueText.ToString();

        }
        else if (sd[2].value.Equals(500000) && level == 2)
        {
            backgroundImage.sprite = background[3];
            ValueText = PTSValues​ - 515000;
            level = 3;
            sd[2].value = 0;
            slider[2].SetActive(false);
            slider[level].SetActive(true);
            sd[level].minValue = 0;
            sd[level].maxValue = 10000000;
            sd[level].value = ValueText;
            //  ValueText = PlayerPrefs.GetInt("Value");
            ptsText[level].text = ValueText.ToString();

        }
        else if(sd[3].value.Equals(10000000) && level == 3)
        {
            level = 0;
            PTSValues = 0;
            ValueText = 0;
            ptsText[level].text = ValueText.ToString();
            GameRestart();
        }


        if (lerpIsTrue)
        {
            if (sd[level].value < ValueText)
            {
                print("ptsvalue: " + ValueText + "Level: " + level);
                sd[level].GetComponent<Slider>().value += Mathf.Lerp(10f, ptsNum, Time.deltaTime * 0.1f);
            }
            else if (sd[level].value >= ValueText)
            {
                lerpIsTrue = false;
            }

        }
    }

    // TODO: Game Start Play New Game First
    public void GameRestart()
    {
        level = 0;
        PTSValues = 0;
        ValueText = 0;
        ptsText[level].text = ValueText.ToString();
        backgroundImage.sprite = background[0];
        lab.SetActive(true);
        slider[3].SetActive(false);
        slider[level].SetActive(true);
        sd[3].value = 0;
        sd[level].maxValue = 5000;
        sd[level].minValue = 0;
        sd[level].value = ValueText;
        ptsText[level].text = ValueText.ToString();
    }

    private void StartShake()
    {
        if (IsPlay)
        {
            HandleShake.Rotate(0f, 0f, HandleShakeSpeed * Time.deltaTime);
        }
    }
    // shake balls button
    public void startButton()
    {
        levelGame.enabled = false;
        levelGame.image.color = Color.gray;
        handle1.GetComponent<BoxCollider2D>().isTrigger = false;
        handle2.GetComponent<BoxCollider2D>().isTrigger = false;
        handle3.GetComponent<BoxCollider2D>().isTrigger = false;
        HandleShakeSpeed = SpeedSet;
        IsPlay = true;
        state = 0;
        startBtn.SetActive(false);
        StartCoroutine(GameProcessing(FindAnyObjectByType<BallsDetect>().state));
    }
 
    // Billiard Balls get Sprites
    void BilliarBallGetSprites(int indexStart, int indexEnd, Image[] images)
    {
        for(int i = indexStart; i< indexEnd; i++)
        {
            for(int j = 0; j<Balls.Length; j++)
            {
                if(FindAnyObjectByType<BallsDetect>().BallValues[i]-1 == j)
                {
                   // BallTrue.SetActive(false);
                    BallImage.sprite = Balls[j];
                    images[indexStart].sprite = Balls[j];

                }
            }
        }
    }
    
    // BilliarBall Processing
    void BilliarBall(int indexStart, int indexEnd, Image[] images)
    {
        for (int i = indexStart; i < indexEnd; i++)
        {
            for (int j = 0; j < Balls.Length; j++)
            {
                if (FindAnyObjectByType<BallsDetect>().BallValues[i]-1 == j)
                {
                    BallImage.sprite = Balls[j];

                }
            }
        }
    }

    // controll Button Group
    void buttonGroup(bool bol, int des)
    {
        for (int i = 0; i < buttonsGroup.Length; i++)
        {
            if (des == 0)
            {
                buttonsGroup[i].enabled = bol;
                buttonsGroup[i].image.color = Color.gray;
            }else if(des == 1)
            {
                buttonsGroup[i].enabled = bol;
                buttonsGroup[i].image.color = new Color(255,255,255,255);
            }
        }
    }

    // Table Show 
    void tableShow(bool bol1, bool bol2, GameObject tb)
    {
        table.SetActive(bol1);
        tb.SetActive(bol2);
    }

    // make compare value of BilliarBall
    void compareBilliarBall(int ball, int balls, Image[] selected,Text[] matchTxt)
    {
        for(int i = ball; i<balls; i++)
        {
            for(int j = 0; j<ballsValues.Count; j++)
            {
                if(FindAnyObjectByType<BallsDetect>().BallValues[i]==ballsValues[j])
                {
                    print("Balls: " + FindAnyObjectByType<BallsDetect>().BallValues[i] + "Value: "+ballsValues[j]);
                    selected[j].color = new Color(255, 255, 255, 255);
                    match ++;
                    matchPanel(1, selected, match,1, matchTxt);
                }
            }
        }
    }
    
    // Match Panel Show
    void matchPanel(int descending, Image[] selected, int match, int temp, Text[] texts)
    {
        
        for (int k = 0; k < selected.Length + temp; k++)
        {
            if (descending == 1)
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("win");
                if (match == k) 
                {
                    texts[k - 1].color = new Color(255, 255, 0);
                    v++;
                    valueProgressing(v,level);
                    print("v: " + v);
                } 
                
                print("text match: " + k);
            }
            else if (descending == 0)
            {
                texts[k].color = new Color(255, 255, 255, 255);
            }
        }
    }
    private bool lerpIsTrue;
    void valueProgressing(int v,int level) 
    {
        switch (v)
        {
            case 1: 
                ptsNum = 100;
                ValueText += ptsNum;
                lerpIsTrue = true;
                print("pts: 100");
                break;            
            case 2: ptsNum = 500;
                ValueText += ptsNum;
                lerpIsTrue = true;
                print("pts: 500");
                break;            
            case 3: ptsNum = 1000;
                ValueText += ptsNum;
                lerpIsTrue = true;
                print("pts: 1000");
                break;            
            case 4: ptsNum = 10000;
                ValueText += ptsNum;
                lerpIsTrue = true;
                print("pts: 10000");
                break;
            case 5: ptsNum = 50000;
                ValueText += ptsNum;
                lerpIsTrue = true;
                print("pts: 50000");
                break;            
            case 6: ptsNum = 100000;
                ValueText += ptsNum;
                lerpIsTrue = true;
                print("pts: 100000");
                break;
        }
        PTSValues += ptsNum;
       // sd[level].value = ValueText;
        ptsText[level].text = ValueText.ToString();
      //  print("PTSValue[level]: " + PTSValues);

    }

    // Game Processing
    IEnumerator GameProcessing(int state)
    {
        Ball.Clear();

        if (BallSelectStart.Equals(FindAnyObjectByType<BallsDetect>().BallValues.Length) && valueOfBallOpt.Equals(3) && FindAnyObjectByType<BallsDetect>().state < 3)
        {
            Ball.Clear();
            tableShow(false, true, table3Match);
            setBallsFales(selectedOpt3);

            yield return new WaitForSecondsRealtime(2f);
            BilliarBall(0, 1, BallsAfterShakeOpt3);
            checkBallOutOfBound(FindAnyObjectByType<BallsDetect>().state, valueOfBallOpt);
            yield return new WaitForSecondsRealtime(2.5f);
            BilliarBallGetSprites(0, 1, BallsAfterShakeOpt3);
            compareBilliarBall(0, 1, selectedOpt3, matchText3);

            yield return new WaitForSecondsRealtime(2f);
            BilliarBall(1, 2, BallsAfterShakeOpt3);
            checkBallOutOfBound(FindAnyObjectByType<BallsDetect>().state, valueOfBallOpt);
            yield return new WaitForSecondsRealtime(2.5f);
            BilliarBallGetSprites(1, 2, BallsAfterShakeOpt3);
            compareBilliarBall(1, 2, selectedOpt3, matchText3);

            yield return new WaitForSecondsRealtime(2f);
            BilliarBall(2, 3, BallsAfterShakeOpt3);
            checkBallOutOfBound(FindAnyObjectByType<BallsDetect>().state, valueOfBallOpt);
            yield return new WaitForSecondsRealtime(2.5f);
            BilliarBallGetSprites(2, 3, BallsAfterShakeOpt3);
            compareBilliarBall(2, 3, selectedOpt3, matchText3);
            Roud.GetComponent<BoxCollider2D>().isTrigger = false;


            HandleShakeSpeed = (HandleShakeSpeed - Subtra) * Time.deltaTime;
            if (HandleShakeSpeed <= 0)
            {
                IsPlay = false;
                HandleShakeSpeed = SpeedSet;

            }

            yield return new WaitForSecondsRealtime(2f);
            handle1.GetComponent<BoxCollider2D>().isTrigger = true;
            handle2.GetComponent<BoxCollider2D>().isTrigger = true;
            handle3.GetComponent<BoxCollider2D>().isTrigger = true;
            yield return new WaitForSecondsRealtime(2f);
            StartCoroutine(clearBalls(BallsAfterShakeOpt3, selectedOpt3));
            StartCoroutine(backUpBalls(FindAnyObjectByType<BallsDetect>().BallValues));
            print("Ball Values: " + FindAnyObjectByType<BallsDetect>().BallValues);

            ballsValues.Clear();
            valueOfBallOpt = 3;
            BallSelectStart = 3;
            state = 0;

            startBtn.SetActive(false);
            tableShow(true, false, table3Match);
            matchPanel(0, selectedOpt3, match, 0, matchText3);
            match = 0;
            for (int i = 0; i < FindAnyObjectByType<BallsDetect>().BallValues.Length; i++)
            {
                FindAnyObjectByType<BallsDetect>().BallValues[i] = 0;
            }
            FindAnyObjectByType<BallsDetect>().state = 0;

        }
        else if (BallSelectStart.Equals(FindAnyObjectByType<BallsDetect>().BallValues.Length) && valueOfBallOpt.Equals(6) && FindAnyObjectByType<BallsDetect>().state < 6)
        {
            
            setBallsFales(selectedOpt6);
            tableShow(false, true, table6Match);
            yield return new WaitForSecondsRealtime(2f);
            BilliarBall(0, 1, BallsAfterShakeOpt6);
            checkBallOutOfBound(FindAnyObjectByType<BallsDetect>().state, valueOfBallOpt);
             yield return new WaitForSecondsRealtime(2.5f);
            BilliarBallGetSprites(0, 1, BallsAfterShakeOpt6);
            compareBilliarBall(0, 1, selectedOpt6, matchText6);

            yield return new WaitForSecondsRealtime(2f);
            BilliarBall(1, 2, BallsAfterShakeOpt6);
            checkBallOutOfBound(FindAnyObjectByType<BallsDetect>().state, valueOfBallOpt);
            yield return new WaitForSecondsRealtime(2.5f);
            BilliarBallGetSprites(1, 2, BallsAfterShakeOpt6);
            compareBilliarBall(1, 2, selectedOpt6, matchText6);

            yield return new WaitForSecondsRealtime(2f);
            BilliarBall(2, 3, BallsAfterShakeOpt6);
            checkBallOutOfBound(FindAnyObjectByType<BallsDetect>().state, valueOfBallOpt);
            yield return new WaitForSecondsRealtime(2.5f);
            BilliarBallGetSprites(2, 3, BallsAfterShakeOpt6);
            compareBilliarBall(2, 3, selectedOpt6, matchText6);

            yield return new WaitForSecondsRealtime(2f);
            BilliarBall(3, 4, BallsAfterShakeOpt6);
            checkBallOutOfBound(FindAnyObjectByType<BallsDetect>().state, valueOfBallOpt);
            yield return new WaitForSecondsRealtime(2.5f);
            BilliarBallGetSprites(3, 4, BallsAfterShakeOpt6);
            compareBilliarBall(3, 4, selectedOpt6, matchText6);

            yield return new WaitForSecondsRealtime(2f);
            BilliarBall(4, 5, BallsAfterShakeOpt6);
            checkBallOutOfBound(FindAnyObjectByType<BallsDetect>().state, valueOfBallOpt);
            yield return new WaitForSecondsRealtime(2.5f);
            BilliarBallGetSprites(4, 5, BallsAfterShakeOpt6);
            compareBilliarBall(4, 5, selectedOpt6, matchText6);

            yield return new WaitForSecondsRealtime(2f);
            BilliarBall(5, 6, BallsAfterShakeOpt6);
            checkBallOutOfBound(FindAnyObjectByType<BallsDetect>().state,valueOfBallOpt);
            yield return new WaitForSecondsRealtime(2.5f);
            BilliarBallGetSprites(5, 6, BallsAfterShakeOpt6);
            compareBilliarBall(5, 6, selectedOpt6, matchText6);



            Roud.GetComponent<BoxCollider2D>().isTrigger = false;
            HandleShakeSpeed = (HandleShakeSpeed - Subtra) * Time.deltaTime;
            if (HandleShakeSpeed <= 0)
            {
                IsPlay = false;
                HandleShakeSpeed = SpeedSet;

            }
            yield return new WaitForSecondsRealtime(2f);
            FindAnyObjectByType<BallsDetect>().state = 0;
            handle1.GetComponent<BoxCollider2D>().isTrigger = true;
            handle2.GetComponent<BoxCollider2D>().isTrigger = true;
            handle3.GetComponent<BoxCollider2D>().isTrigger = true;
            yield return new WaitForSecondsRealtime(2f);
            StartCoroutine(clearBalls(BallsAfterShakeOpt6, selectedOpt6));
            StartCoroutine(backUpBalls(FindAnyObjectByType<BallsDetect>().BallValues));
            ballsValues.Clear();
            BallSelectStart = 6;
            valueOfBallOpt = 6;

            startBtn.SetActive(false);
            tableShow(true, false, table6Match);
            matchPanel(0, selectedOpt6, match, 0, matchText6);
            match = 0;

            for(int i=0; i< FindAnyObjectByType<BallsDetect>().BallValues.Length; i++)
            {
                FindAnyObjectByType<BallsDetect>().BallValues[i] = 0;
            }
            FindAnyObjectByType<BallsDetect>().state = 0;
        }
        else
            print("None Option!!");
    }
    
    void checkBallOutOfBound(int state, int val)
    {
        if(state < val)
        {
            Roud.GetComponent<BoxCollider2D>().isTrigger = true;
        }
        else
        {
            Roud.GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }

    // Back Up Ball ofter Suffer
    IEnumerator backUpBalls(int[] BallValues)
    {
        print("Ball: " + BallValues.Length.ToString());
        yield return new WaitForSecondsRealtime(2f);
        for (int j = 0; j < BallValues.Length; j++)
        {
            for (int i = 0; i < BallsGroups.Count; i++)
            {
                if (BallValues[j] == BallsGroups[i].value || BallsGroups[i].sprite.transform.position.y<=-2 || BallsGroups[i].sprite.transform.position.y >= yPos) //|| 
                {
                   // int add = i - 1;
                    print("i: " + i + " balls: " + BallsGroups[i].value);
                    Vector3 vector = new Vector3(transform.position.x+ xPos, transform.position.y+ yPos, 0f);
                    BallsGroups[i].sprite.transform.position = vector;
                    BallsGroups[i].sprite.SetActive(true);
                    print("PosY");
                }
            }
        }
        yield return new WaitForSecondsRealtime(1f);
        for(int ins = 0; ins<BallsGroups.Count; ins++)
        {
            BallsGroups[ins].sprite.SetActive(true);
        }
        for (int i = 0; i < FindAnyObjectByType<BallsDetect>().resultText.Length; i++)
            FindAnyObjectByType<BallsDetect>().resultText[i].text = "0";
            
    }

    // Cleare balls
    IEnumerator clearBalls(Image[] selected, Image[] opt)
    {
        yield return new WaitForSecondsRealtime(2f);
        for (int i = 0; i < selected.Length; i++)
        {
            selected[i].sprite = opt[i].sprite = BallAfterDefualt;
            selected[i].color = opt[i].color = new Color(255, 255, 255, 255);
            

        }
        state = 0;
        v = 0;
        levelGame.enabled = true;
        levelGame.image.color = new Color(255, 255, 255, 255);
    }

    // Game Options Controll
    // GameOption
    public void GameOption()
    {
        hand.SetActive(false);
        wait.SetActive(false);
        isOpt = !isOpt;
        if (isOpt)
            Opt.Play("opt");
        else if (!isOpt)
            Opt.Play("opts");
    }
 
    // OptionONE
    public void OptionONEButton()
    {
        FindFirstObjectByType<AudioManage>().sfxPlay("onClick");
        buttonGroup(true, 1);
        feelingPanel.SetActive(false);
        resultPanel.SetActive(false);
        state = 0;
        ballsValues.Clear();
        optTxt[0].text = optTxt[1].text;
        Opt.Play("opts");
        valueOfBallOpt = 3;
        BallSelectStart = 3;
        FindAnyObjectByType<BallsDetect>().BallValues = new int[3];
        resultPanelOpt[0].SetActive(true);
        selectionOpt[0].SetActive(true);
        resultPanelOpt[1].SetActive(false);
        selectionOpt[1].SetActive(false);
    }

    // OptionTWO
    public void OptionTWOButton()
    {
        FindFirstObjectByType<AudioManage>().sfxPlay("onClick");
        buttonGroup(true, 1);
        feelingPanel.SetActive(false);
        resultPanel.SetActive(false);
        state = 0;
        ballsValues.Clear();
        optTxt[0].text = optTxt[2].text;
        Opt.Play("opts");
        valueOfBallOpt = 6;
        BallSelectStart = 6;
        FindAnyObjectByType<BallsDetect>().BallValues = new int[6];
        resultPanelOpt[0].SetActive(false);
        selectionOpt[0].SetActive(false);
        resultPanelOpt[1].SetActive(true);
        selectionOpt[1].SetActive(true);
    }

    // Billiard Balls Selection
    public void clickOnBalls()
    {
        string bntIndex = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        if (state < valueOfBallOpt)
        {
            switch (bntIndex)
            {
                case "Ball (0)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 1;
                    break;
                case "Ball (1)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 2;
                    break;
                case "Ball (2)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 3;
                    break;
                case "Ball (3)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 4;
                    break;
                case "Ball (4)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 5;
                    break;
                case "Ball (5)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 6;
                    break;
                case "Ball (6)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 7;
                    break;
                case "Ball (7)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 8;
                    break;
                case "Ball (8)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 9;
                    break;                
                case "Ball (9)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 10;
                    break;
                case "Ball (10)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 11;
                    break;
                case "Ball (11)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 12;
                    break;
                case "Ball (12)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 13;
                    break;
                case "Ball (13)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 14;
                    break;
                case "Ball (14)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 15;
                    break;
                case "Ball (15)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 16;
                    break;
                case "Ball (16)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 17;
                    break;
                case "Ball (17)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 18;
                    break;
                case "Ball (18)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 19;
                    break;
                case "Ball (19)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 20;
                    break;
                case "Ball (20)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 21;
                    break;
                case "Ball (21)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 22;
                    break;
                case "Ball (22)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 23;
                    break;
                case "Ball (23)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 24;
                    break;
                case "Ball (24)":
                    FindFirstObjectByType<AudioManage>().sfxPlay("balls");
                    index = 25;
                    break;
            }
            ballsValues.Add(index);
            if (valueOfBallOpt == 6)
            {
                selectedOpt6[state].sprite = Balls[index-1];
            }else if(valueOfBallOpt == 3)
            {
                selectedOpt3[state].sprite = Balls[index-1];
            }
            state++;
            print("Stat: " + state);
        }
        if (state == valueOfBallOpt)
        {
            startBtn.SetActive(true);
        }
    }

    // set BallFalse
    void setBallsFales(Image[] selected)
    {
        for(int i = 0; i<selected.Length; i++)
        {
            selected[i].color = Color.gray;
        }
    }

    // set time scale
    bool PauseTrue;
    public Button Pause;
    [SerializeField] GameObject Panel;
    public Sprite[] PauseSprite;
    public void PauseAndPlay()
    {
        PauseTrue = !PauseTrue;
        if (PauseTrue)
        {
            Pause.image.sprite = PauseSprite[0];
            Time.timeScale = 0f;
            FindFirstObjectByType<AudioManage>().sfxPlay("onClick");
            FindAnyObjectByType<AudioManage>().audioSources.mute = true;
            FindAnyObjectByType<AudioManage>().musicBtn.image.sprite = FindAnyObjectByType<AudioManage>().btnSprites[0];
            Panel.SetActive(true);
        }
        else if (!PauseTrue)
        {
            Time.timeScale = 1f;
            Pause.image.sprite = PauseSprite[1];
            FindFirstObjectByType<AudioManage>().sfxPlay("onClick");
            FindAnyObjectByType<AudioManage>().audioSources.mute = false;
            FindAnyObjectByType<AudioManage>().musicBtn.image.sprite = FindAnyObjectByType<AudioManage>().btnSprites[1];
            Panel.SetActive(false);
        }
    }

    // call Home Scene
    public void HomeScene()
    {
        SceneManager.LoadScene("Home Game Scene");
    }
}
