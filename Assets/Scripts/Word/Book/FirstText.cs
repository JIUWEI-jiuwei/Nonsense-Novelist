using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
/// <summary>
/// 第一本书转范文（挂摄像机上）
/// </summary>
public class FirstText : MonoBehaviour
{
    /// <summary>
    /// 主角
    /// </summary>
    private AbstractCharacter leadingChara;

    /// <summary>
    /// 所有角色的父物体
    /// </summary>
    private GameObject fatherObject;

    private void Start()
    {
        fatherObject = GameObject.Find("panel");
        FindLeadingChara();
    }

    /// <summary>
    /// 获取主角
    /// </summary>
    private void FindLeadingChara()
    {
        if (leadingChara == null)
            leadingChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
    }

    /// <summary>
    /// 开场介绍
    /// </summary>
    public string StartText()
    {
        return File.ReadAllText("Assets/StreamingAssets/女巫学徒/0.txt");
    }
    /// <summary>
    /// 第一章第一幕剧情
    /// </summary>
    public string FirstBegin()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/1_1_1.txt");
        FindLeadingChara();
        string result = a[0] + leadingChara.wordName + a[1];

        if (leadingChara.gender == GenderEnum.girl)
            result += "她";
        else if (leadingChara.gender == GenderEnum.boy)
            result += "他";
        else
            result += "它";

        result += a[2];
        return result;
    }

    /// <summary>
    /// 第一章第一幕战场
    /// </summary>
    public string FirstFight()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/1_1_2.txt");
        FindLeadingChara();
        string result = a[0];
        return result;
    }
}
