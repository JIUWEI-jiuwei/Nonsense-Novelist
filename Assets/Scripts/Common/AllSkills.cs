using System.Collections.Generic;
using UnityEngine;
using System;

///<summary>
///所有技能静态类
///</summary>
public static class AllSkills
{
    public static List<Type> list = new List<Type>();
    /// <summary>6个初始词条</summary>
    public static Type[] absWords = new Type[6];
    /// <summary>
    /// 静态构造函数
    /// </summary>
    static AllSkills()
    {
        //添加脚本类元素
        list.AddRange(new Type[] { typeof(BuryFlower), typeof(FallBadly), typeof(HeartBroken), typeof(LengXiangPillSkill), 
            typeof(WritePoem) ,typeof(CHOOHShoot) ,typeof(FangFuShu) ,typeof(FireBall) ,typeof(QiChongShaDance),typeof(TongPinGongZhen) });
        list.AddRange(new Type[] { typeof(HuoSiRenTangJi), typeof(TaiXuHuanJing), typeof(TouXiangQieYu), typeof(HeChenAi), 
            typeof(ChaoMinFanYing),typeof(GuanZhuangFeiYan) ,typeof(HunFei),typeof(KeBanXingWei) ,typeof(LinQiuJun) });
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
    public static Type TestBox(int i)
    {
        return list[i];
    }
}
