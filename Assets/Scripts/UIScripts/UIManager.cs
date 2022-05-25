using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///UI管理器
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
    /// 每一章的下一关按钮
    /// </summary>
    public void NextQuanQia()
    {       
        charaTransAndCamera.BeginMove();
        nextQuanQia = true;
    }
}
