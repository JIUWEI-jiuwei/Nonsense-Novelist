using System.Collections.Generic;
using UnityEngine;
using System;

///<summary>
///���м��ܾ�̬��
///</summary>
public static class AllSkills
{
    /// <summary>ȫ�����ʴ���</summary>
    public static List<Type> list_noun = new List<Type>();
    /// <summary>ȫ�����ݴʴ���</summary>
    public static List<Type> list_adj= new List<Type>();
    /// <summary>ȫ�����ʴ���</summary>
    public static List<Type> list_verb = new List<Type>();
    /// <summary>ȫ�����ܴ���</summary>
    public static List<Type> list = new List<Type>();
    /// <summary>ȫ������</summary>
    public static List<Type> list_all = new List<Type>();

    /// <summary>��¥�����ʴ���</summary>
    public static List<Type> hlmList_noun = new List<Type>();
    /// <summary>��¥�����ݴʴ���</summary>
    public static List<Type> hlmList_adj = new List<Type>();
    /// <summary>��¥�ζ��ʴ���</summary>
    public static List<Type> hlmList_verb = new List<Type>();
    /// <summary>��¥��ȫ������</summary>
    public static List<Type> hlmList_all = new List<Type>();

    /// <summary>6����ʼ����</summary>
    public static Type[] absWords = new Type[6];
    /// <summary>
    /// ��̬���캯��
    /// </summary>
    static AllSkills()
    {       
        //��Ӷ��ʴ���
        list_verb.AddRange(new Type[] { typeof(BuryFlower),  typeof(WritePoem) , typeof(HeartBroken),           
           typeof(CHOOHShoot) ,typeof(FallBadly),typeof(QiChongShaDance),typeof(TongPinGongZhen) });
        //������ݴʴ���
        list_adj.AddRange(new Type[] {  typeof(TaiXuHuanJing), typeof(TouXiangQieYu), typeof(HeChenAi), 
            typeof(ChaoMinFanYing),typeof(GuanZhuangFeiYan) ,typeof(HunFei),typeof(KeBanXingWei) ,typeof(LinQiuJun) });
        //������ʴ���
        list_noun.AddRange(new Type[] { typeof(Exoskeleton), typeof(JiShengChong), typeof(LengXiangPill), typeof(Nexus6Arm),
            typeof(NoteFragment),typeof(PinkStone),typeof(PurpleStone) ,typeof(RiLunGuaZhui),
            typeof(TeaCup),typeof(TigerStone) ,typeof(UnlockMagicCode),typeof(WhiteStone) });
        //ȫ��
        list_all.AddRange(list_verb);
        list_all.AddRange(list_adj);
        list_all.AddRange(list_noun);
        //ȫ������+���ݴ�
        list.AddRange(list_verb);
        list.AddRange(list_adj);
        

        //����¥�Ρ���Ӷ��ʴ���
        hlmList_verb.AddRange(new Type[] { typeof(BuryFlower), typeof(WritePoem), typeof(FallBadly), typeof(FuYao) });
        //����¥�Ρ�������ݴʴ���
        hlmList_adj.AddRange(new Type[] { typeof(TaiXuHuanJing), typeof(TouXiangQieYu)});
        //����¥�Ρ�������ʴ���
        hlmList_noun.AddRange(new Type[] { typeof(TeaCup), typeof(LengXiangPill) });
        //����¥�Ρ�ȫ������
        hlmList_all.AddRange(hlmList_verb);
        hlmList_all.AddRange(hlmList_adj);
        hlmList_all.AddRange(hlmList_noun);

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
    /// <summary>
    /// ����ȫ�����ܴ���
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type TestBox(int i)
    {
        return list[i];
    }
    /// <summary>
    /// ����ȫ������
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type AllWords(int i)
    {
        return list_all[i];
    }/// <summary>
    /// ����ȫ�����ʴ���
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type AllNounWords(int i)
    {
        return list_noun[i];
    }
    /// ����ȫ�����ݴʴ���
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type AllAdjWords(int i)
    {
        return list_adj[i];
    }
    /// ����ȫ�����ʴ���
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type AllVerbWords(int i)
    {
        return list_verb[i];
    }

    /// <summary>
    /// ���ء���¥�Ρ��е�ȫ������
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type HLMWords(int i)
    {
        return hlmList_all[i];
    }

}
