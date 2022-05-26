using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
/// <summary>
/// 女巫学徒转范文（挂摄像机上,每次打斗结束后调用）
/// </summary>
public class BookNvWuXueTu : MonoBehaviour
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
    /// 调用此方法即可
    /// </summary>
    /// <param name="character">章节数1.2.(0为开场介绍)</param>
    /// <param name="part">第1.2.幕(0为章节标题)</param>
    /// <param name="phase">1开场2战场3结束</param>
    /// <returns></returns>
    public string GetText(int character,int part,int phase)
    {
         if (character == 0)
                return StartText();
         if (character==1)
            {
                if (part == 0)
                    return "不速之客";
                if(part == 1)
                {
                    switch(phase)
                    {
                        case 1:
                            return First_1_Start();
                        case 2:
                            return First_1_Fight();
                        case 3:
                            return First_1_End();
                    default:
                        return null;
                    }
                }
                if(part == 2)
            {
                switch (phase)
                {
                    case 1:
                        return First_2_Start();
                    case 2:
                        return First_2_Fight();
                    case 3:
                        return First_2_End();
                    default:
                        return null;
                }
            }
                else
                     return null;
            }
        if (character == 2)
        {
            if (part == 0)
                return "密特拉";
            if (part == 1)
            {
                switch (phase)
                {
                    case 1:
                        return Second_1_Start();
                    case 2:
                        return Second_1_Fight();
                    case 3:
                        return Second_1_End();
                    default:
                        return null;
                }
            }
            if (part == 2)
            {
                switch (phase)
                {
                    case 1:
                        return Second_2_Start();
                    case 2:
                        return Second_2_Fight();
                    case 3:
                        return Second_2_End();
                    default:
                        return null;
                }
            }
            else
                return null;
        }
        if (character == 3)
        {
            if (part == 0)
                return "沉默的森林";
            if (part == 1)
            {
                switch (phase)
                {
                    case 1:
                        return Third_1_Start();
                    case 2:
                        return Third_1_Fight();
                    case 3:
                        return Third_1_End();
                    default:
                        return null;
                }
            }
            if (part == 1)
            {
                switch (phase)
                {
                    case 1:
                        return Second_1_Start();
                    case 2:
                        return Second_1_Fight();
                    case 3:
                        return Second_1_End();
                    default:
                        return null;
                }
            }
            else
                return null;
        }
        if (character == 4)
        {
            if (part == 0)
                return "梦境探索";
            if (part == 1)
            {
                switch (phase)
                {
                    case 1:
                        return First_2_Start();
                    case 2:
                        return First_2_Fight();
                    case 3:
                        return First_2_End();
                    default:
                        return null;
                }
            }
            else
                return null;
        }
        if (character == 5)
        {
            if (part == 0)
                return "初临尖塔";
            if (part == 1)
            {
                switch (phase)
                {
                    case 1:
                        return First_2_Start();
                    case 2:
                        return First_2_Fight();
                    case 3:
                        return First_2_End();
                    default:
                        return null;
                }
            }
            else
                return null;
        }
        if (character == 6)
        {
            if (part == 0)
                return "书塔修炼";
            if (part == 1)
            {
                switch (phase)
                {
                    case 1:
                        return First_2_Start();
                    case 2:
                        return First_2_Fight();
                    case 3:
                        return First_2_End();
                    default:
                        return null;
                }
            }
            else
                return null;
        }
        if (character == 7)
        {
            if (part == 0)
                return "德洛瑞斯的归来";
            if (part == 1)
            {
                switch (phase)
                {
                    case 1:
                        return First_2_Start();
                    case 2:
                        return First_2_Fight();
                    case 3:
                        return First_2_End();
                    default:
                        return null;
                }
            }
            else
                return null;
        }
        if (character == 8)
        {
            if (part == 0)
                return "大闹金库";
            if (part == 1)
            {
                switch (phase)
                {
                    case 1:
                        return First_2_Start();
                    case 2:
                        return First_2_Fight();
                    case 3:
                        return First_2_End();
                    default:
                        return null;
                }
            }
            else
                return null;
        }
        if (character == 9)
        {
            if (part == 0)
                return "缄口地窖";
            if (part == 1)
            {
                switch (phase)
                {
                    case 1:
                        return First_2_Start();
                    case 2:
                        return First_2_Fight();
                    case 3:
                        return First_2_End();
                    default:
                        return null;
                }
            }
            else
                return null;
        }
        else
            return null;
    }

    /// <summary>
    /// 开场介绍
    /// </summary>
    private string StartText()
    {
        return File.ReadAllText("Assets/StreamingAssets/女巫学徒/0.txt");
    }
    /// <summary>
    /// 第一章第一幕剧情
    /// </summary>
    private string First_1_Start()
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
    private string First_1_Fight()
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
    private string First_1_End()
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
    private string First_2_Start()
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
    private string First_2_Fight()
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
    private string First_2_End()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/1_2_3.txt");
        string result = a[0];
        return result;
    }

    /// <summary>
    /// 第二章第一幕剧情
    /// </summary>
    private string Second_1_Start()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/2_1_1.txt");
        FindLeadingChara();
        //二号友方
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//防止空
        string result = a[0];

        return result;
    }

    /// <summary>
    /// 第二章第一幕战场
    /// </summary>
    private string Second_1_Fight()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/2_1_2.txt");
        FindLeadingChara();
        //二号友方
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//防止空
        string result = a[0];

        return result;
    }

    /// <summary>
    /// 第二章第一幕结局
    /// </summary>
    private string Second_1_End()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/2_1_3.txt");
        FindLeadingChara();
        //二号友方
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//防止空
        string result = a[0];

        return result;
    }

    /// <summary>
    /// 第二章第二幕开始
    /// </summary>
    private string Second_2_Start()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/2_2_1.txt");
        FindLeadingChara();
        //二号友方
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//防止空
        string result = a[0];

        return result;
    }
    /// <summary>
    /// 第二章第二幕战场
    /// </summary>
    private string Second_2_Fight()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/2_2_2.txt");
        FindLeadingChara();
        //二号友方
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//防止空
        string result = a[0];

        return result;
    }

    /// <summary>
    /// 第二章第二幕结局
    /// </summary>
    private string Second_2_End()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/2_2_3.txt");
        FindLeadingChara();
        //二号友方
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//防止空
        string result = a[0];

        return result;
    }
    /// <summary>
    /// 第三章第一幕剧情
    /// </summary>
    private string Third_1_Start()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/3_1_1.txt");
        FindLeadingChara();
        //二号友方
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//防止空
        string result = a[0];

        return result;
    }
    /// <summary>
    /// 第三章第一幕战场
    /// </summary>
    private string Third_1_Fight()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/3_1_2.txt");
        FindLeadingChara();
        //二号友方
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//防止空
        string result = a[0];

        return result;
    }

    /// <summary>
    /// 第三章第一幕结局
    /// </summary>
    private string Third_1_End()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/女巫学徒/3_1_3.txt");
        FindLeadingChara();
        //二号友方
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//防止空
        string result = a[0];

        return result;
    }
}
