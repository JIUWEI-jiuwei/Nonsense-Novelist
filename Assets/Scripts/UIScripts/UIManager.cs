using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///UI������
///</summary>
class UIManager  : MonoBehaviour
{
    public static bool nextQuanQia;
    private CharacterTranslateAndCamera charaTransAndCamera;

    private void Awake()
    {
        charaTransAndCamera = GameObject.Find("MainCamera").GetComponent<CharacterTranslateAndCamera>();
    }
    /// <summary>
    /// ÿһ�µ���һ�ذ�ť
    /// </summary>
    public void NextQuanQia()
    {       
        charaTransAndCamera.BeginMove();
        nextQuanQia = true;
    }
}
