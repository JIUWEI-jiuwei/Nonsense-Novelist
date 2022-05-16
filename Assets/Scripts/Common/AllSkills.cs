using System.Collections.Generic;
using UnityEngine;
using System;

///<summary>
///���м��ܾ�̬��
///</summary>
public static class AllSkills
{
    public static List<Type> list = new List<Type>();
    /// <summary>6����ʼ����</summary>
    public static Type[] absWords = new Type[6];
    /// <summary>
    /// ��̬���캯��
    /// </summary>
    static AllSkills()
    {
        //��ӽű���Ԫ��
        list.AddRange(new Type[] { typeof(BuryFlower), typeof(FallBadly), typeof(HeartBroken), typeof(LengXiangPillSkill), typeof(WritePoem) });
        list.AddRange(new Type[] { typeof(HuoSiRenTangJi), typeof(TaiXuHuanJing), typeof(TouXiangQieYu) });
    }
    /// <summary>
    /// ��̬������ɼ���
    /// </summary>
    public static Type OnDrawBox()
    {
        //UnityEngine.Random.InitState((int)Time.unscaledTime);
        int number = UnityEngine.Random.Range(0, list.Count);
        return list[number];
    }
    public static Type TestBox(int i)
    {
        return list[i];
    }
}
