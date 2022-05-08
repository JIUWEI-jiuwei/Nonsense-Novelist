using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
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
    private void Start()
    {
        
    }  
    /// <summary>
    /// 点击抽奖盒，生成词条
    /// </summary>
    public void OnDrawBox()
    {
        foreach(Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "MainCanvas")
            {
                if (parentTF.childCount < wordNum) {
                    GameObject word = Instantiate(wordPrefab, canvas.transform);
                    Type absWord = AllSkills.OnDrawBox();
                    word.AddComponent(absWord);
                    word.transform.SetParent(parentTF);
                }               
            }
        }       
    }
} 
