using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/// <summary>
/// ������ĺ���
/// </summary>
class EntryDrawBox : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform parentTF;
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
                if (parentTF.childCount <= 9) {
                    GameObject word = Instantiate(wordPrefab, canvas.transform);
                    Type absWord = AllSkills.OnDrawBox();
                    word.AddComponent(absWord);
                    word.transform.SetParent(parentTF);
                }               
            }
        }       
    }
} 
