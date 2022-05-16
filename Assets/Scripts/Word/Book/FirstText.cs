using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
/// <summary>
/// 第一本书转范文（挂摄像机上,每次打斗结束后调用）
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
        AbstractVerbs[] verbs=fatherObject.GetComponentsInChildren<AbstractVerbs>();
        string result = a[0];
        foreach(AbstractVerbs verb in verbs)
        {
            if (string.IsNullOrEmpty(verb.PlaySentence())) 
                continue;
            else
            result+=verb.PlaySentence();
        }
        result += a[1];
        return result;
    }
    /// <summary>
    /// 第一章第一幕结束
    /// </summary>
    public string FirstEnd()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/1_1_3.txt");
        FindLeadingChara();
        string result = a[0] + leadingChara.wordName + a[1];

        if (leadingChara.gender == GenderEnum.girl)
            result += "噗嗤一笑";
        else
            result += "哈哈大笑";
        result += a[2];
        result += leadingChara.wordName;
        result += a[3];
        result += leadingChara.wordName;
        result += a[4];
        return result;
    }

    /// <summary>
    /// 第一章第二幕剧情
    /// </summary>
    public string SecondStart()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/1_2_1.txt");
        FindLeadingChara();
        //二号友方
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//防止空
        string result = "同" +secondChara.wordName + a[0]+leadingChara.wordName+a[1]+leadingChara.name+a[2];
        if (secondChara.trait.traitName != "敏感")
        {
            result += "放肆";
            result += a[3];
            result+=secondChara.wordName;
            result += "厉声呵斥";
            result += a[4];
        }
        else
        {
            result += "可笑";
            result += a[3];
            result+=secondChara.wordName;
            result += "小声嘲讽";
            result += a[4];
        }

        return result;
    }
    /// <summary>
    /// 第一章第二幕战场
    /// </summary>
    public string SecondFight()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/1_2_2.txt");
        AbstractVerbs[] verbs = fatherObject.GetComponentsInChildren<AbstractVerbs>();
        string result="";
        foreach (AbstractVerbs verb in verbs)
        {
            if (string.IsNullOrEmpty(verb.PlaySentence()))
                continue;
            else
                result += verb.PlaySentence();
        }
        return result;
    }

    /// <summary>
    /// 第一章第二幕结束
    /// </summary>
    public string SecondEnd()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/1_2_3.txt");
        string result = a[0];
        return result;
    }
}
