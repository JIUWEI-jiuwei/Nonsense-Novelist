
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
   /* private void Start()
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
    }*/
    /// <summary>
    /// 点击抽奖盒，生成词条
    /// </summary>
    public void OnDrawBox()
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
    /// 测试用的全部技能面板
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
