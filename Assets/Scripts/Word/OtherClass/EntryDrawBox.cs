using UnityEngine.SceneManagement;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.EventSystems;
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
    #region panel
    /// <summary>书桌界面父panel</summary>
    public Transform bookDeskPanel;
    /// <summary>书桌界面红楼梦形容词父panel</summary>
    public Transform hlmbookDeskPanel;
    /// <summary>书桌界面仿生人父panel</summary>
    public Transform bookDeskHumanPanel;
    /// <summary>书桌界面动物园父panel</summary>
    public Transform bookDeskAnimalPanel;
    /// <summary>书桌界面水晶能量父panel</summary>
    public Transform bookDeskCrystalPanel;
    /// <summary>书桌界面莎乐美形容词父panel</summary>
    public Transform shalemeiPanel;
    /// <summary>书桌界面蚂蚁帝国父panel</summary>
    public Transform mayiPanel;
    /// <summary>书桌界面流行病学父panel</summary>
    public Transform liuPanel;
    /// <summary>书桌界面埃及神话父panel</summary>
    public Transform aijiPanel;
    /// <summary>书桌界面通用父panel</summary>
    public Transform commonPanel;
    #endregion

    #region bool
    private List<bool> isFirsts = new List<bool>();
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
    /// <summary>埃及神话按钮第一次点击</summary>
    private bool aijiFirst = false;
    /// <summary>莎乐美按钮第一次点击</summary>
    private bool shalemeiFirst = false;
    /// <summary>流行病学按钮第一次点击</summary>
    private bool liuFirst = false;
    /// <summary>蚂蚁帝国按钮第一次点击</summary>
    private bool mayiFirst = false;
    /// <summary>通用按钮第一次点击</summary>
    private bool commonFirst = false;
    #endregion

    /// <summary>CD加载满，点击能否生成词条</summary>
    //public bool isCreateWord = false;
    public int wordNumm = 0;
    /// <summary>名词toggle</summary>
    public Toggle toggle_noun;
    /// <summary>动词toggle</summary>
    public Toggle toggle_verb;
    /// <summary>形容词toggle</summary>
    public Toggle toggle_adj;

    #region list
    private List<GameObject> hlm_noun = new List<GameObject>();
    private List<GameObject> hlm_verb = new List<GameObject>();
    private List<GameObject> hlm_adj = new List<GameObject>();
    private List<GameObject> ani_noun = new List<GameObject>();
    private List<GameObject> ani_verb = new List<GameObject>();
    private List<GameObject> ani_adj = new List<GameObject>();
    private List<GameObject> aiji_noun = new List<GameObject>();
    private List<GameObject> aiji_verb = new List<GameObject>();
    private List<GameObject> aiji_adj = new List<GameObject>();
    private List<GameObject> shuijing_noun = new List<GameObject>();
    private List<GameObject> shuijing_verb = new List<GameObject>();
    private List<GameObject> shuijing_adj = new List<GameObject>();
    private List<GameObject> liuxing_noun = new List<GameObject>();
    private List<GameObject> liuxing_verb = new List<GameObject>();
    private List<GameObject> liuxing_adj = new List<GameObject>();
    private List<GameObject> common_noun = new List<GameObject>();
    private List<GameObject> common_verb = new List<GameObject>();
    private List<GameObject> common_adj = new List<GameObject>();
    private List<GameObject> sahlemei_noun = new List<GameObject>();
    private List<GameObject> sahlemei_verb = new List<GameObject>();
    private List<GameObject> sahlemei_adj = new List<GameObject>();
    private List<GameObject> mayi_noun = new List<GameObject>();
    private List<GameObject> mayi_verb = new List<GameObject>();
    private List<GameObject> mayi_adj = new List<GameObject>();
    private List<GameObject> fang_noun = new List<GameObject>();
    private List<GameObject> fang_verb = new List<GameObject>();
    private List<GameObject> fang_adj = new List<GameObject>();
    #endregion

    //加载初始六个词条
    private void Start()
    {
        isFirsts.AddRange(new bool[] { hlmFirst, humanFirst, animalFirst, crystalFirst,commonFirst,mayiFirst,liuFirst,shalemeiFirst,aijiFirst });
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
                        if (word.GetComponent<AbstractWord0>() != null)
                        {
                            word.GetComponent<Image>().sprite = Resources.Load<Sprite>("FirstStageLoad/" + word.GetComponent<AbstractWord0>().wordName);
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
        if (wordNumm > 0)
        {
            foreach (Canvas canvas in FindObjectsOfType<Canvas>())
            {
                if (canvas.name == "MainCanvas")
                {
                    if (parentTF.childCount < wordNum)
                    {
                        GameObject word = Instantiate(wordPrefab, canvas.transform);
                        Type absWord = AllSkills.CreateSkillWord();
                        word.AddComponent(absWord);
                        word.GetComponent<Image>().sprite = Resources.Load<Sprite>("FirstStageLoad/" + word.GetComponent<AbstractWord0>().wordName);
                        word.transform.SetParent(parentTF);
                    }
                }
            }
            wordNumm--;
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
                        Type absWord = AllSkills.list_all[i];
                        word.AddComponent(absWord);
                        word.GetComponent<Image>().sprite = Resources.Load<Sprite>("FirstStageLoad/" + word.GetComponent<AbstractWord0>().wordName);
                        word.transform.SetParent(bookDeskPanel);
                    }
                }
                boxFirst = true;
            }
        }
    }
    /*   版本一废弃方法
     *   /// <summary>
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
                            word.GetComponent<Image>().sprite = Resources.Load<Sprite>("FirstStageLoad/" + word.GetComponent<AbstractWord0>().wordName);
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
                            word.GetComponent<Image>().sprite = Resources.Load<Sprite>("FirstStageLoad/" + word.GetComponent<AbstractWord0>().wordName);
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
                            word.GetComponent<Image>().sprite = Resources.Load<Sprite>("FirstStageLoad/" + word.GetComponent<AbstractWord0>().wordName);
                            word.transform.SetParent(bookDeskAdjPanel);
                        }
                    }
                    adjFirst = true;
                }
            }        
        }
    */

    /// <summary>
    /// 书桌界面《红楼梦》词条
    /// </summary>
    public void BookDeskDiffBook()
    {
        // 书桌界面《红楼梦》词条
        if (EventSystem.current.currentSelectedGameObject.name == "红楼梦" )
        {
            ShowWords(hlm_noun,hlm_verb,hlm_adj,hlmbookDeskPanel, AllSkills.hlmList_noun, AllSkills.hlmList_verb, AllSkills.hlmList_adj);
            hlmFirst = true;
        }
        // 书桌界面《仿生人》词条
        else if (EventSystem.current.currentSelectedGameObject.name == "仿生人")
        {
            ShowWords(fang_noun, fang_verb, fang_adj, bookDeskHumanPanel, AllSkills.humanList_noun, AllSkills.humanList_verb, AllSkills.humanList_adj);
            humanFirst = true;
        }
        // 书桌界面《动物园》词条
        else if (EventSystem.current.currentSelectedGameObject.name == "动物园" )
        {
            ShowWords(ani_noun, ani_verb, ani_adj, bookDeskAnimalPanel, AllSkills.animalList_noun, AllSkills.animalList_verb, AllSkills.animalList_adj);
            animalFirst = true;
        }
        // 书桌界面《埃及神话》词条
        else if (EventSystem.current.currentSelectedGameObject.name == "埃及神话")
        {
            ShowWords(aiji_noun, aiji_verb, aiji_adj, aijiPanel, AllSkills.aiJiShenHuaList_noun, AllSkills.aiJiShenHuaList_verb, AllSkills.aiJiShenHuaList_adj);
            aijiFirst = true;
        }
        // 书桌界面《莎乐美》词条
        else if (EventSystem.current.currentSelectedGameObject.name == "莎乐美" )
        {
            ShowWords(sahlemei_noun, sahlemei_verb, sahlemei_adj, shalemeiPanel, AllSkills.shaLeMeiList_noun, AllSkills.shaLeMeiList_verb, AllSkills.shaLeMeiList_adj);
            shalemeiFirst = true;
        }
        // 书桌界面《流行病学》词条
        else if (EventSystem.current.currentSelectedGameObject.name == "流行病学")
        {
            ShowWords(liuxing_noun, liuxing_verb, liuxing_adj, liuPanel, AllSkills.liuXingBXList_noun, AllSkills.liuXingBXList_verb, AllSkills.liuXingBXList_adj);
            liuFirst = true;
        }
        // 书桌界面《蚂蚁帝国》词条
        else if (EventSystem.current.currentSelectedGameObject.name == "蚂蚁帝国")
        {
            ShowWords(mayi_noun, mayi_verb, mayi_adj, mayiPanel, AllSkills.maYiDiGuoList_noun, AllSkills.maYiDiGuoList_verb, AllSkills.maYiDiGuoList_adj);
            mayiFirst = true;
        }
        // 书桌界面《水晶能量》词条
        else if (EventSystem.current.currentSelectedGameObject.name == "水晶能量")
        {
            ShowWords(shuijing_noun, shuijing_verb, shuijing_adj, bookDeskCrystalPanel, AllSkills.crystalList_noun, AllSkills.crystalList_verb, AllSkills.crystalList_adj);
            crystalFirst = true;
        }
        // 书桌界面《通用》词条
        else if (EventSystem.current.currentSelectedGameObject.name == "通用")
        {
            ShowWords(common_noun, common_verb, common_adj, commonPanel, AllSkills.commonList_noun, AllSkills.commonList_verb, AllSkills.commonList_adj);
            commonFirst = true;
        }

    }

    /// <summary>
    /// 勾选模式下生成词条
    /// </summary>
    /// <param name="bookword_noun"></param>
    /// <param name="bookword_verb"></param>
    /// <param name="bookword_adj"></param>
    private void ShowWords(List<GameObject> words_noun, List<GameObject> words_verb, List<GameObject> words_adj,Transform panelTF, List<Type> bookword_noun, List<Type> bookword_verb, List<Type> bookword_adj)
    {
        foreach (Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "MainCanvas")
            {
                if (toggle_noun.isOn && words_noun.Count==0)
                {
                    for (int i = 0; i < bookword_noun.Count; i++)
                    {
                        GameObject word = Instantiate(wordPrefab, canvas.transform);
                        Type absWord = bookword_noun[i];
                        word.AddComponent(absWord);
                        word.GetComponent<Image>().sprite = Resources.Load<Sprite>("FirstStageLoad/" + word.GetComponent<AbstractWord0>().wordName);
                        word.transform.SetParent(panelTF);

                        words_noun.Add(word);
                    }
                }
/*                else if (!toggle_noun.isOn && words_noun.Count != 0)
                {
                    for (int i = 0; i < words_noun.Count; i++)
                    {
                        Destroy(words_noun[i]);
                    }
                    for (int i = 0; i < words_noun.Count; i++)
                    {
                        words_noun.Remove(words_noun[i]);
                    }
                }*/
                if (toggle_verb.isOn && words_verb.Count==0)
                {
                    for (int i = 0; i < bookword_verb.Count; i++)
                    {
                        GameObject word = Instantiate(wordPrefab, canvas.transform);
                        Type absWord = bookword_verb[i];
                        word.AddComponent(absWord);
                        word.GetComponent<Image>().sprite = Resources.Load<Sprite>("FirstStageLoad/" + word.GetComponent<AbstractWord0>().wordName);
                        word.transform.SetParent(panelTF);

                        words_verb.Add(word);
                    }
                }
          /*      else if (!toggle_verb.isOn && words_verb.Count!=0)
                {
                    for (int i = 0; i < words_verb.Count; i++)
                    {
                        Destroy(words_verb[i]);
                    }
                    foreach (GameObject it in words_verb)
                    {
                        words_verb.Remove(it);
                    }
                }*/
                if (toggle_adj.isOn && words_adj.Count==0)
                {
                    for (int i = 0; i < bookword_adj.Count; i++)
                    {
                        GameObject word = Instantiate(wordPrefab, canvas.transform);
                        Type absWord = bookword_adj[i];
                        word.AddComponent(absWord);
                        word.GetComponent<Image>().sprite = Resources.Load<Sprite>("FirstStageLoad/" + word.GetComponent<AbstractWord0>().wordName);
                        word.transform.SetParent(panelTF);

                        words_adj.Add(word);
                    }
                }
              /*  else if (!toggle_adj.isOn && words_adj.Count!=0)
                {
                    for (int i = 0; i < words_adj.Count; i++)
                    {
                        Destroy(words_adj[i]);
                    }
                    foreach (GameObject it in words_adj)
                    {
                        words_adj.Remove(it);
                    }
                }*/
            }
        }

        for(int i = 0; i < isFirsts.Count; i++)
        {
            isFirsts[i] = false;
        }
    }
    public void ToggleEvent()
    {
        //名词
        if (EventSystem.current.currentSelectedGameObject.name == toggle_noun.name && !toggle_noun.isOn)
        {
            //清空list，删除
            //判定当前所在panel
            if (commonFirst)
            {
                for (int i = 0; i < common_noun.Count; i++)
                {
                    Destroy(common_noun[i]);
                }
                hlm_noun.RemoveRange(0, common_noun.Count);
            }
            else if (hlmFirst)
            {
                for (int i = 0; i < hlm_noun.Count; i++)
                {
                    Destroy(hlm_noun[i]);
                }
                hlm_noun.RemoveRange(0, hlm_noun.Count);
            }
            else if (animalFirst)
            {
                for (int i = 0; i < ani_noun.Count; i++)
                {
                    Destroy(ani_noun[i]);
                }
                ani_noun.RemoveRange(0, ani_noun.Count);
            }
        }
        else if(EventSystem.current.currentSelectedGameObject.name == toggle_noun.name && toggle_noun.isOn)
        {
            //生成名词
            print("noun");
        }
    }
}
