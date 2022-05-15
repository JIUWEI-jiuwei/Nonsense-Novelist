using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
/// <summary>
/// ��һ����ת���ģ���������ϣ�
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
        FindLeadingChara();
        string result = a[0];
        return result;
    }
}
