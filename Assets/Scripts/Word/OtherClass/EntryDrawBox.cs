using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
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
    private void Start()
    {
        
    }  
    /// <summary>
    /// ����齱�У����ɴ���
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
