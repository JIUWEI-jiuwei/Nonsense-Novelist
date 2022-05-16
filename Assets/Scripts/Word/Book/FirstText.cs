using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
/// <summary>
/// ��һ����ת���ģ����������,ÿ�δ򶷽�������ã�
/// </summary>
public class FirstText : MonoBehaviour
{
    /// <summary>
    /// ����
    /// </summary>
    private AbstractCharacter leadingChara;

    /// <summary>
    /// ���н�ɫ�ĸ�����
    /// </summary>
    private GameObject fatherObject;

    private void Start()
    {
        fatherObject = GameObject.Find("panel");
        FindLeadingChara();
    }

    /// <summary>
    /// ��ȡ����
    /// </summary>
    private void FindLeadingChara()
    {
        if (leadingChara == null)
            leadingChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
    }

    /// <summary>
    /// ��������
    /// </summary>
    public string StartText()
    {
        return File.ReadAllText("Assets/StreamingAssets/Ů��ѧͽ/0.txt");
    }
    /// <summary>
    /// ��һ�µ�һĻ����
    /// </summary>
    public string FirstBegin()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/1_1_1.txt");
        FindLeadingChara();
        string result = a[0] + leadingChara.wordName + a[1];

        if (leadingChara.gender == GenderEnum.girl)
            result += "��";
        else if (leadingChara.gender == GenderEnum.boy)
            result += "��";
        else
            result += "��";

        result += a[2];
        return result;
    }

    /// <summary>
    /// ��һ�µ�һĻս��
    /// </summary>
    public string FirstFight()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/1_1_2.txt");
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
    /// ��һ�µ�һĻ����
    /// </summary>
    public string FirstEnd()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/1_1_3.txt");
        FindLeadingChara();
        string result = a[0] + leadingChara.wordName + a[1];

        if (leadingChara.gender == GenderEnum.girl)
            result += "����һЦ";
        else
            result += "������Ц";
        result += a[2];
        result += leadingChara.wordName;
        result += a[3];
        result += leadingChara.wordName;
        result += a[4];
        return result;
    }

    /// <summary>
    /// ��һ�µڶ�Ļ����
    /// </summary>
    public string SecondStart()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/1_2_1.txt");
        FindLeadingChara();
        //�����ѷ�
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//��ֹ��
        string result = "ͬ" +secondChara.wordName + a[0]+leadingChara.wordName+a[1]+leadingChara.name+a[2];
        if (secondChara.trait.traitName != "����")
        {
            result += "����";
            result += a[3];
            result+=secondChara.wordName;
            result += "�����ǳ�";
            result += a[4];
        }
        else
        {
            result += "��Ц";
            result += a[3];
            result+=secondChara.wordName;
            result += "С������";
            result += a[4];
        }

        return result;
    }
    /// <summary>
    /// ��һ�µڶ�Ļս��
    /// </summary>
    public string SecondFight()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/1_2_2.txt");
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
    /// ��һ�µڶ�Ļ����
    /// </summary>
    public string SecondEnd()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/1_2_3.txt");
        string result = a[0];
        return result;
    }
}
