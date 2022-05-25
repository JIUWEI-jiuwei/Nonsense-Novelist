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
    private static GameObject endPanel;

    private void Awake()
    {
        charaTransAndCamera = GameObject.Find("MainCamera").GetComponent<CharacterTranslateAndCamera>();
        endPanel = GameObject.Find("endPanel");
    }
    /// <summary>
    /// 每一章的下一关按钮
    /// </summary>
    public void NextQuanQia()
    {
        //打开关卡结束面板
        endPanel.transform.GetChild(0).gameObject.SetActive(false);
        charaTransAndCamera.BeginMove();
        nextQuanQia = true;
    }
    /// <summary>
    /// 判断是否结束
    /// </summary>
    /// <returns></returns>
    public static bool isEnd()
    {
        if (GameObject.Find("EnemyCharacter").transform.childCount <= 1)
        {
            //打开关卡结束面板
            endPanel.transform.GetChild(0).gameObject.SetActive(true);
            return true;
        }
        return false;
    }
}
