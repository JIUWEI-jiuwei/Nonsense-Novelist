using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
/// <summary>
/// Ů��ѧͽת���ģ����������,ÿ�δ򶷽�������ã�
/// </summary>
public class BookNvWuXueTu : MonoBehaviour
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
    /// ���ô˷�������
    /// </summary>
    /// <param name="character">�½���1.2.(0Ϊ��������)</param>
    /// <param name="part">��1.2.Ļ(0Ϊ�½ڱ���)</param>
    /// <param name="phase">1����2ս��3����</param>
    /// <returns></returns>
    public string GetText(int character,int part,int phase)
    {
         if (character == 0)
                return StartText();
         if (character==1)
            {
                if (part == 0)
                    return "����֮��";
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
                return "������";
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
                return "��Ĭ��ɭ��";
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
                return "�ξ�̽��";
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
                return "���ټ���";
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
                return "��������";
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
                return "������˹�Ĺ���";
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
                return "���ֽ��";
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
                return "��ڵؽ�";
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
    /// ��������
    /// </summary>
    private string StartText()
    {
        return File.ReadAllText("Assets/StreamingAssets/Ů��ѧͽ/0.txt");
    }
    /// <summary>
    /// ��һ�µ�һĻ����
    /// </summary>
    private string First_1_Start()
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
    private string First_1_Fight()
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
    private string First_1_End()
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
    private string First_2_Start()
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
    private string First_2_Fight()
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
    private string First_2_End()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/1_2_3.txt");
        string result = a[0];
        return result;
    }

    /// <summary>
    /// �ڶ��µ�һĻ����
    /// </summary>
    private string Second_1_Start()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/2_1_1.txt");
        FindLeadingChara();
        //�����ѷ�
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//��ֹ��
        string result = a[0];

        return result;
    }

    /// <summary>
    /// �ڶ��µ�һĻս��
    /// </summary>
    private string Second_1_Fight()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/2_1_2.txt");
        FindLeadingChara();
        //�����ѷ�
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//��ֹ��
        string result = a[0];

        return result;
    }

    /// <summary>
    /// �ڶ��µ�һĻ���
    /// </summary>
    private string Second_1_End()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/2_1_3.txt");
        FindLeadingChara();
        //�����ѷ�
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//��ֹ��
        string result = a[0];

        return result;
    }

    /// <summary>
    /// �ڶ��µڶ�Ļ��ʼ
    /// </summary>
    private string Second_2_Start()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/2_2_1.txt");
        FindLeadingChara();
        //�����ѷ�
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//��ֹ��
        string result = a[0];

        return result;
    }
    /// <summary>
    /// �ڶ��µڶ�Ļս��
    /// </summary>
    private string Second_2_Fight()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/2_2_2.txt");
        FindLeadingChara();
        //�����ѷ�
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//��ֹ��
        string result = a[0];

        return result;
    }

    /// <summary>
    /// �ڶ��µڶ�Ļ���
    /// </summary>
    private string Second_2_End()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/2_2_3.txt");
        FindLeadingChara();
        //�����ѷ�
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//��ֹ��
        string result = a[0];

        return result;
    }
    /// <summary>
    /// �����µ�һĻ����
    /// </summary>
    private string Third_1_Start()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/3_1_1.txt");
        FindLeadingChara();
        //�����ѷ�
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//��ֹ��
        string result = a[0];

        return result;
    }
    /// <summary>
    /// �����µ�һĻս��
    /// </summary>
    private string Third_1_Fight()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/3_1_2.txt");
        FindLeadingChara();
        //�����ѷ�
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//��ֹ��
        string result = a[0];

        return result;
    }

    /// <summary>
    /// �����µ�һĻ���
    /// </summary>
    private string Third_1_End()
    {
        string[] a = File.ReadAllLines("Assets/StreamingAssets/Ů��ѧͽ/3_1_3.txt");
        FindLeadingChara();
        //�����ѷ�
        AbstractCharacter secondChara = fatherObject.transform.Find("SelfCharacter").GetComponentInChildren<AbstractCharacter>();
        if (secondChara == null) leadingChara = secondChara;//��ֹ��
        string result = a[0];

        return result;
    }
}
