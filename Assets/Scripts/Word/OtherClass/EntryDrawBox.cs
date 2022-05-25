
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

    //���س�ʼ��������
    private void Start()
    {
        /*foreach (Canvas canvas in FindObjectsOfType<Canvas>())
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
        }*/
    }
    private void FixedUpdate()
    {
        /*oneWordTimer += Time.deltaTime;
        if (oneWordTimer <= oneWordTime)
        {
            threeStar.GetComponent<Image>().fillAmount = (float)(oneWordTimer / oneWordTime);
            return;
        }
        CreateOneWord();
        oneWordTimer = 0f;*/
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
    /// �����õ�ȫ���������
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
}
