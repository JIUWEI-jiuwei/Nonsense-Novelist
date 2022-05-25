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
    private static GameObject endPanel;

    private void Awake()
    {
        charaTransAndCamera = GameObject.Find("MainCamera").GetComponent<CharacterTranslateAndCamera>();
        endPanel = GameObject.Find("endPanel");
    }
    /// <summary>
    /// ÿһ�µ���һ�ذ�ť
    /// </summary>
    public void NextQuanQia()
    {
        //�򿪹ؿ��������
        endPanel.transform.GetChild(0).gameObject.SetActive(false);
        charaTransAndCamera.BeginMove();
        nextQuanQia = true;
    }
    /// <summary>
    /// �ж��Ƿ����
    /// </summary>
    /// <returns></returns>
    public static bool isEnd()
    {
        if (GameObject.Find("EnemyCharacter").transform.childCount <= 1)
        {
            //�򿪹ؿ��������
            endPanel.transform.GetChild(0).gameObject.SetActive(true);
            return true;
        }
        return false;
    }
}
