using UnityEngine.SceneManagement;
using UnityEngine;
using System;
using UnityEngine.UI;
/// <summary>
/// 抽词条的盒子
/// </summary>
class EntryDrawBox : MonoBehaviour
{
    /// <summary>词条预制体</summary>
    public GameObject wordPrefab;
    /// <summary>父物体变换组件</summary>
    public Transform parentTF;
    /// <summary>战斗界面词条最大数量</summary>
    private int wordNum = 10;
    /// <summary>词条盒子加载的三颗星</summary>
    public Image threeStar;
    public float oneWordTimer = 0f;
    public float oneWordTime = 6f;
    public float oneWordTimer2 = 0f;
    public float oneWordTime2 = 20f;

    /// <summary>书桌界面父panel</summary>
    public Transform bookDeskPanel;
    /// <summary>书桌界面名词父panel</summary>
    public Transform bookDeskNounPanel;
    /// <summary>书桌界面动词父panel</summary>
    public Transform bookDeskVerbPanel;
    /// <summary>书桌界面形容词父panel</summary>
    public Transform bookDeskAdjPanel;
    /// <summary>书桌界面形容词父panel</summary>
    public Transform hlmbookDeskPanel;
    /// <summary>书桌界面仿生人父panel</summary>
    public Transform bookDeskHumanPanel;
    /// <summary>书桌界面动物园父panel</summary>
    public Transform bookDeskAnimalPanel;
    /// <summary>书桌界面水晶能量父panel</summary>
    public Transform bookDeskCrystalPanel;
    /// <summary>书桌界面查看词库父panel</summary>
    public Transform bookDeskCombatPanel;

    /// <summary>名词按钮第一次点击</summary>
    private bool nounFirst = false;
    /// <summary>动词按钮第一次点击</summary>
    private bool verbFirst = false;
    /// <summary>形容词按钮第一次点击</summary>
    private bool adjFirst = false;
    /// <summary>box按钮第一次点击</summary>
    private bool boxFirst = false;
    /// <summary>红楼梦按钮第一次点击</summary>
    private bool hlmFirst = false;
    /// <summary>仿生人按钮第一次点击</summary>
    private bool humanFirst = false;
    /// <summary>动物园按钮第一次点击</summary>
    private bool animalFirst = false;
    /// <summary>水晶能量按钮第一次点击</summary>
    private bool crystalFirst = false;
    /// <summary>水晶能量按钮第一次点击</summary>
    private bool combatAllFirst = false;
    /// <summary>CD加载满，点击能否生成词条</summary>
    //public bool isCreateWord = false;
    public int wordNumm = 0;

    //加载初始六个词条
    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Combat")
        {
            foreach (Canvas canvas in FindObjectsOfType<Canvas>())
            {
                if (canvas.name == "MainCanvas")
                {
                    for (int i = 0; i < AllSkills.absWords.Length; i++)
                    {
                        GameObject word = Instantiate(wordPrefab, canvas.transform);
                        word.AddComponent(AllSkills.absWords[i]);
                        if (word.GetComponent<AbstractWords0>() != null)
                        {
                            word.GetComponent<Image>().sprite = Resources.Load<Sprite>(word.GetComponent<AbstractWords0>().wordName);
                        }
                        word.transform.SetParent(parentTF);
                    }
                }
            }
        }
    }
    private void FixedUpdate()
    {
        //缓冲词条盒子的CD，CD满了生成一个词条
        if (SceneManager.GetActiveScene().name == "Combat")
        {
            oneWordTimer += Time.deltaTime;
            if (oneWordTimer <= oneWordTime)
            {
                if (wordNumm == 0)
                {
                    threeStar.GetComponent<Image>().fillAmount = (float)(oneWordTimer / oneWordTime);
                }
                else
                {
                    threeStar.GetComponent<Image>().fillAmount = 1;
                }
                return;
            }
            else
            {
                if (wordNumm < 3)
                {
                    wordNumm++;
                }
                oneWordTimer = 0f;
            }
            
        }
    }

    public void CreateOneWord()
    {
        if (wordNumm>0)
        {
            foreach (Canvas canvas in FindObjectsOfType<Canvas>())
            {
                if (canvas.name == "MainCanvas")
                {
                    if (parentTF.childCount < wordNum)
                    {
                        GameObject word = Instantiate(wordPrefab, canvas.transform);
                        Type absWord = AllSkills.OnDrawBox();
                        word.AddComponent(absWord);
                        word.GetComponent<Image>().sprite = Resources.Load<Sprite>(word.GetComponent<AbstractWords0>().wordName);
                        word.transform.SetParent(parentTF);
                    }
                }
            }
            wordNumm--;
        }        
    }

    /// <summary>
    /// 测试用的全部技能面板（动词+形容词）
    /// </summary>
    public void TestDrawBox()
    {
        foreach (Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "MainCanvas")
            {
                for (int i = 0; i < AllSkills.list.Count; i++)
                {
                    GameObject word = Instantiate(wordPrefab, canvas.transform);
                    Type absWord = AllSkills.TestBox(i);
                    word.AddComponent(absWord);
                    word.GetComponent<Image>().sprite = Resources.Load<Sprite>(word.GetComponent<AbstractWords0>().wordName);
                    word.transform.SetParent(parentTF);
                }
            }
        }
    }
    /// <summary>
    /// 书桌界面全部词条
    /// </summary>
    public void BookDeskDrawBox()
    {
        if (boxFirst == false)
        {
            foreach (Canvas canvas in FindObjectsOfType<Canvas>())
            {
                if (canvas.name == "MainCanvas")
                {
                    for (int i = 0; i < AllSkills.list_all.Count; i++)
                    {
                        GameObject word = Instantiate(wordPrefab, canvas.transform);
                        Type absWord = AllSkills.AllWords(i);
                        word.AddComponent(absWord);
                        word.GetComponent<Image>().sprite = Resources.Load<Sprite>(word.GetComponent<AbstractWords0>().wordName);
                        word.transform.SetParent(bookDeskPanel);
                    }
                }
                boxFirst = true;
            }
        }       
    }
    /// <summary>
    /// 书桌界面全部名词词条
    /// </summary>
    public void BookDeskNounWords()
    {
        if (nounFirst == false)
        {
            foreach (Canvas canvas in FindObjectsOfType<Canvas>())
            {
                if (canvas.name == "MainCanvas")
                {
                    for (int i = 0; i < AllSkills.list_noun.Count; i++)
                    {
                        GameObject word = Instantiate(wordPrefab, canvas.transform);
                        Type absWord = AllSkills.AllNounWords(i);
                        word.AddComponent(absWord);
                        word.GetComponent<Image>().sprite = Resources.Load<Sprite>(word.GetComponent<AbstractWords0>().wordName);
                        word.transform.SetParent(bookDeskNounPanel);
                    }
                }
                nounFirst = true;
            }
        }       
    }
    /// <summary>
    /// 书桌界面全部动词词条
    /// </summary>
    public void BookDeskVerbWords()
    {
        if (verbFirst == false)
        {
            foreach (Canvas canvas in FindObjectsOfType<Canvas>())
            {
                if (canvas.name == "MainCanvas")
                {
                    for (int i = 0; i < AllSkills.list_verb.Count; i++)
                    {
                        GameObject word = Instantiate(wordPrefab, canvas.transform);
                        Type absWord = AllSkills.AllVerbWords(i);
                        word.AddComponent(absWord);
                        word.GetComponent<Image>().sprite = Resources.Load<Sprite>(word.GetComponent<AbstractWords0>().wordName);
                        word.transform.SetParent(bookDeskVerbPanel);
                    }
                }
                verbFirst = true;
            }
        }       
    }
    /// <summary>
    /// 书桌界面全部形容词词条
    /// </summary>
    public void BookDeskAdjWords()
    {
        if (adjFirst == false)
        {
            foreach (Canvas canvas in FindObjectsOfType<Canvas>())
            {
                if (canvas.name == "MainCanvas")
                {
                    for (int i = 0; i < AllSkills.list_adj.Count; i++)
                    {
                        GameObject word = Instantiate(wordPrefab, canvas.transform);
                        Type absWord = AllSkills.AllAdjWords(i);
                        word.AddComponent(absWord);
                        word.GetComponent<Image>().sprite = Resources.Load<Sprite>(word.GetComponent<AbstractWords0>().wordName);
                        word.transform.SetParent(bookDeskAdjPanel);
                    }
                }
                adjFirst = true;
            }
        }        
    }

    /// <summary>
    /// 书桌界面《红楼梦》词条
    /// </summary>
    public void BookDeskHLMWords()
    {
        if (hlmFirst == false)
        {
            foreach (Canvas canvas in FindObjectsOfType<Canvas>())
            {
                if (canvas.name == "MainCanvas")
                {
                    for (int i = 0; i < AllSkills.hlmList_all.Count; i++)
                    {
                        GameObject word = Instantiate(wordPrefab, canvas.transform);
                        Type absWord = AllSkills.HLMWords(i);
                        word.AddComponent(absWord);
                        word.GetComponent<Image>().sprite = Resources.Load<Sprite>(word.GetComponent<AbstractWords0>().wordName);
                        word.transform.SetParent(hlmbookDeskPanel);
                    }
                }
                hlmFirst = true;
            }
        }        
    }
    /// <summary>
    /// 书桌界面《仿生人》词条
    /// </summary>
    public void BookDeskHumanWords()
    {
        if (humanFirst == false)
        {
            foreach (Canvas canvas in FindObjectsOfType<Canvas>())
            {
                if (canvas.name == "MainCanvas")
                {
                    for (int i = 0; i < AllSkills.humanList_all.Count; i++)
                    {
                        GameObject word = Instantiate(wordPrefab, canvas.transform);
                        Type absWord = AllSkills.HumanWords(i);
                        word.AddComponent(absWord);
                        word.GetComponent<Image>().sprite = Resources.Load<Sprite>(word.GetComponent<AbstractWords0>().wordName);
                        word.transform.SetParent(bookDeskHumanPanel);
                    }
                }
                humanFirst = true;
            }
        }        
    }
    /// <summary>
    /// 书桌界面《动物园》词条
    /// </summary>
    public void BookDeskAnimalWords()
    {
        if (animalFirst == false)
        {
            foreach (Canvas canvas in FindObjectsOfType<Canvas>())
            {
                if (canvas.name == "MainCanvas")
                {
                    for (int i = 0; i < AllSkills.animalList_all.Count; i++)
                    {
                        GameObject word = Instantiate(wordPrefab, canvas.transform);
                        Type absWord = AllSkills.AnimalZooWords(i);
                        word.AddComponent(absWord);
                        word.GetComponent<Image>().sprite = Resources.Load<Sprite>(word.GetComponent<AbstractWords0>().wordName);
                        word.transform.SetParent(bookDeskAnimalPanel);
                    }
                }
                animalFirst = true;
            }
        }        
    }
    /// <summary>
    /// 书桌界面《水晶能量》词条
    /// </summary>
    public void BookDeskCrystalWords()
    {
        if (crystalFirst == false)
        {
            foreach (Canvas canvas in FindObjectsOfType<Canvas>())
            {
                if (canvas.name == "MainCanvas")
                {
                    for (int i = 0; i < AllSkills.crystalList_all.Count; i++)
                    {
                        GameObject word = Instantiate(wordPrefab, canvas.transform);
                        Type absWord = AllSkills.CrystalWords(i);
                        word.AddComponent(absWord);
                        word.GetComponent<Image>().sprite = Resources.Load<Sprite>(word.GetComponent<AbstractWords0>().wordName);
                        word.transform.SetParent(bookDeskCrystalPanel);
                    }
                }
                crystalFirst = true;
            }
        }        
    }
    /// <summary>
    /// 书桌界面查看战斗词库的全部词条
    /// </summary>
    public void BookDeskCombatAllWords()
    {
        if (combatAllFirst == false)
        {
            foreach (Canvas canvas in FindObjectsOfType<Canvas>())
            {
                if (canvas.name == "MainCanvas")
                {
                    for (int i = 0; i < AllSkills.list.Count; i++)
                    {
                        GameObject word = Instantiate(wordPrefab, canvas.transform);
                        Type absWord = AllSkills.TestBox(i);
                        word.AddComponent(absWord);
                        word.GetComponent<Image>().sprite = Resources.Load<Sprite>(word.GetComponent<AbstractWords0>().wordName);
                        word.transform.SetParent(bookDeskCombatPanel);
                    }
                }
                combatAllFirst = true;
            }
        }        
    }

}
