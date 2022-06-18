using System.Collections.Generic;
using UnityEngine;
using System;

///<summary>
///所有技能静态类
///</summary>
public static class AllSkills
{
    /// <summary>全部名词词条</summary>
    public static List<Type> list_noun = new List<Type>();
    /// <summary>全部形容词词条</summary>
    public static List<Type> list_adj= new List<Type>();
    /// <summary>全部动词词条</summary>
    public static List<Type> list_verb = new List<Type>();
    /// <summary>全部技能词条</summary>
    public static List<Type> list = new List<Type>();
    /// <summary>全部词条</summary>
    public static List<Type> list_all = new List<Type>();

    /// <summary>红楼梦名词词条</summary>
    public static List<Type> hlmList_noun = new List<Type>();
    /// <summary>红楼梦形容词词条</summary>
    public static List<Type> hlmList_adj = new List<Type>();
    /// <summary>红楼梦动词词条</summary>
    public static List<Type> hlmList_verb = new List<Type>();
    /// <summary>红楼梦全部词条</summary>
    public static List<Type> hlmList_all = new List<Type>();

    /// <summary>6个初始词条</summary>
    public static Type[] absWords = new Type[6];
    /// <summary>
    /// 静态构造函数
    /// </summary>
    static AllSkills()
    {       
        //添加动词词条
        list_verb.AddRange(new Type[] { typeof(BuryFlower),  typeof(WritePoem) , typeof(HeartBroken),           
           typeof(CHOOHShoot) ,typeof(FallBadly),typeof(QiChongShaDance),typeof(TongPinGongZhen) });
        //添加形容词词条
        list_adj.AddRange(new Type[] {  typeof(TaiXuHuanJing), typeof(TouXiangQieYu), typeof(HeChenAi), 
            typeof(ChaoMinFanYing),typeof(GuanZhuangFeiYan) ,typeof(HunFei),typeof(KeBanXingWei) ,typeof(LinQiuJun) });
        //添加名词词条
        list_noun.AddRange(new Type[] { typeof(Exoskeleton), typeof(JiShengChong), typeof(LengXiangPill), typeof(Nexus6Arm),
            typeof(NoteFragment),typeof(PinkStone),typeof(PurpleStone) ,typeof(RiLunGuaZhui),
            typeof(TeaCup),typeof(TigerStone) ,typeof(UnlockMagicCode),typeof(WhiteStone) });
        //全部
        list_all.AddRange(list_verb);
        list_all.AddRange(list_adj);
        list_all.AddRange(list_noun);
        //全部动词+形容词
        list.AddRange(list_verb);
        list.AddRange(list_adj);
        

        //《红楼梦》添加动词词条
        hlmList_verb.AddRange(new Type[] { typeof(BuryFlower), typeof(WritePoem), typeof(FallBadly), typeof(FuYao) });
        //《红楼梦》添加形容词词条
        hlmList_adj.AddRange(new Type[] { typeof(TaiXuHuanJing), typeof(TouXiangQieYu)});
        //《红楼梦》添加名词词条
        hlmList_noun.AddRange(new Type[] { typeof(TeaCup), typeof(LengXiangPill) });
        //《红楼梦》全部词条
        hlmList_all.AddRange(hlmList_verb);
        hlmList_all.AddRange(hlmList_adj);
        hlmList_all.AddRange(hlmList_noun);

    }
    /// <summary>
    /// 静态随机生成技能
    /// </summary>
    public static Type OnDrawBox()
    {
        //UnityEngine.Random.InitState((int)Time.unscaledTime);
        int number = UnityEngine.Random.Range(0, list.Count);
        return list[number];
    }
    /// <summary>
    /// 返回全部技能词条
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type TestBox(int i)
    {
        return list[i];
    }
    /// <summary>
    /// 返回全部词条
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type AllWords(int i)
    {
        return list_all[i];
    }/// <summary>
    /// 返回全部名词词条
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type AllNounWords(int i)
    {
        return list_noun[i];
    }
    /// 返回全部形容词词条
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type AllAdjWords(int i)
    {
        return list_adj[i];
    }
    /// 返回全部动词词条
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type AllVerbWords(int i)
    {
        return list_verb[i];
    }

    /// <summary>
    /// 返回《红楼梦》中的全部词条
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type HLMWords(int i)
    {
        return hlmList_all[i];
    }

}
