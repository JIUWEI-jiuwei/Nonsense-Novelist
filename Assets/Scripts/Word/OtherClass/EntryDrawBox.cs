using UnityEngine.SceneManagement;
using UnityEngine;
using System;
using UnityEngine.UI;
/// <summary>
/// ������ĺ���
/// </summary>
class EntryDrawBox : MonoBehaviour
{
    /// <summary>����Ԥ����</summary>
    public GameObject wordPrefab;
    /// <summary>������任���</summary>
    public Transform parentTF;
    /// <summary>ս����������������</summary>
    private int wordNum = 10;
    /// <summary>�������Ӽ��ص�������</summary>
    public Image threeStar;
    public float oneWordTimer = 0f;
    public float oneWordTime = 6f;
    public float oneWordTimer2 = 0f;
    public float oneWordTime2 = 20f;

    /// <summary>�������游panel</summary>
    public Transform bookDeskPanel;
    /// <summary>�����������ʸ�panel</summary>
    public Transform bookDeskNounPanel;
    /// <summary>�������涯�ʸ�panel</summary>
    public Transform bookDeskVerbPanel;
    /// <summary>�����������ݴʸ�panel</summary>
    public Transform bookDeskAdjPanel;
    /// <summary>�����������ݴʸ�panel</summary>
    public Transform hlmbookDeskPanel;
    /// <summary>������������˸�panel</summary>
    public Transform bookDeskHumanPanel;
    /// <summary>�������涯��԰��panel</summary>
    public Transform bookDeskAnimalPanel;
    /// <summary>��������ˮ��������panel</summary>
    public Transform bookDeskCrystalPanel;
    /// <summary>��������鿴�ʿ⸸panel</summary>
    public Transform bookDeskCombatPanel;

    /// <summary>���ʰ�ť��һ�ε��</summary>
    private bool nounFirst = false;
    /// <summary>���ʰ�ť��һ�ε��</summary>
    private bool verbFirst = false;
    /// <summary>���ݴʰ�ť��һ�ε��</summary>
    private bool adjFirst = false;
    /// <summary>box��ť��һ�ε��</summary>
    private bool boxFirst = false;
    /// <summary>��¥�ΰ�ť��һ�ε��</summary>
    private bool hlmFirst = false;
    /// <summary>�����˰�ť��һ�ε��</summary>
    private bool humanFirst = false;
    /// <summary>����԰��ť��һ�ε��</summary>
    private bool animalFirst = false;
    /// <summary>ˮ��������ť��һ�ε��</summary>
    private bool crystalFirst = false;
    /// <summary>ˮ��������ť��һ�ε��</summary>
    private bool combatAllFirst = false;
    /// <summary>CD������������ܷ����ɴ���</summary>
    //public bool isCreateWord = false;
    public int wordNumm = 0;

    //���س�ʼ��������
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
        //����������ӵ�CD��CD��������һ������
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
    /// �����õ�ȫ��������壨����+���ݴʣ�
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
    /// ��������ȫ������
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
    /// ��������ȫ�����ʴ���
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
    /// ��������ȫ�����ʴ���
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
    /// ��������ȫ�����ݴʴ���
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
    /// �������桶��¥�Ρ�����
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
    /// �������桶�����ˡ�����
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
    /// �������桶����԰������
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
    /// �������桶ˮ������������
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
    /// ��������鿴ս���ʿ��ȫ������
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
