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
    public float oneWordTime = 20f;

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

    /// <summary>���ʰ�ť��һ�ε��</summary>
    private bool nounFirst = false;
    /// <summary>���ʰ�ť��һ�ε��</summary>
    private bool verbFirst = false;
    /// <summary>���ݴʰ�ť��һ�ε��</summary>
    private bool adjFirst = false;
    /// <summary>box��ť��һ�ε��</summary>
    private bool boxFirst = false;
    /// <summary>box��ť��һ�ε��</summary>
    private bool hlmFirst = false;

    //���س�ʼ��������
    private void Start()
    {
        /*if (SceneManager.GetActiveScene().name == "Combat")
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
        } */       
    }
    private void FixedUpdate()
    {
        //����������ӵ�CD��CD��������һ������
        /*if (SceneManager.GetActiveScene().name == "Combat")
        {
            oneWordTimer += Time.deltaTime;
            if (oneWordTimer <= oneWordTime)
            {
                threeStar.GetComponent<Image>().fillAmount = (float)(oneWordTimer / oneWordTime);
                return;
            }
            CreateOneWord();
            oneWordTimer = 0f;
        }   */     
    }
    /// <summary>
    /// ����齱�У����ɴ���
    /// </summary>
    /*public void OnDrawBox()
    {
        CreateOneWord();
    }*/

    private void CreateOneWord()
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
                if (canvas.name == "Canvas")
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
                if (canvas.name == "Canvas")
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
                if (canvas.name == "Canvas")
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
                if (canvas.name == "Canvas")
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
                if (canvas.name == "Canvas")
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
}
