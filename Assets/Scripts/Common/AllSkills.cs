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

    /// <summary>动物园全部词条</summary>
    public static List<Type> animalList_all = new List<Type>();
    /// <summary>仿生人全部词条</summary>
    public static List<Type> humanList_all = new List<Type>();
    /// <summary>水晶能量全部词条</summary>
    public static List<Type> crystalList_all = new List<Type>();
    /// <summary>女巫学徒全部词条</summary>
    public static List<Type> nvwuList_all = new List<Type>();
    /// <summary>战斗界面全部词条</summary>
    public static List<Type> combatList_all = new List<Type>();


    /// <summary>6个初始词条</summary>
    public static Type[] absWords = new Type[6];
    /// <summary>
    /// 静态构造函数
    /// </summary>
    static AllSkills()
    {       
        //添加动词词条
        list_verb.AddRange(new Type[] { typeof(BuryFlower),  typeof(WritePoem) , typeof(HeartBroken),
           typeof(CHOOHShoot) ,typeof(FallBadly),typeof(QiChongShaDance),typeof(TongPinGongZhen),
        typeof(BaoZa), typeof(FangFuShu), typeof(GunShoot), typeof(Kiss),typeof(MianYiZengQiang),
        typeof(ShaYu), typeof(ToBigger), typeof(TuLingCeShi), typeof(WanShua), typeof(WenYiChuanBo)});
        //添加形容词词条
        list_adj.AddRange(new Type[] {  typeof(BuXiu), typeof(ChaFanWuXin), typeof(CuZhuang), typeof(HunFei),
           typeof(FengChan),typeof(FengLi) ,typeof(GuoMin),typeof(HaoZhan) ,typeof(HeWuRan),typeof(HunQianMengYing),
        typeof(JianRuPanShi),typeof(KeBan) ,typeof(LuanLun),typeof(LuoYingBinFen) ,typeof(QingXi),typeof(QuicklyGrowing),
        typeof(RenZao),typeof(SanFaFeiLuoMeng) ,typeof(ShenHuanFeiYan),typeof(ShenYouHuanJing) ,typeof(XinShenJiDang),
            typeof(YouAnQuanGan),typeof(ZhongDu),});
        //添加名词词条
        list_noun.AddRange(new Type[] { typeof(Exoskeleton), typeof(JiShengChong), typeof(LengXiangPill), typeof(Nexus_6Arm),
            typeof(PurpleStone) ,typeof(RiLunGuaZhui),typeof(BenJieShiDui),typeof(DuXian),
            typeof(TeaCup),typeof(TigerStone) ,typeof(WhiteStone) ,typeof(FuTouAxe),typeof(GlassPendant),
            typeof(HorusEyes),typeof(MeiGuiShiYing) ,typeof(MemoryImplantion),typeof(PaintBrush),typeof(StrangeStatue),
            typeof(ThickDictionary),typeof(VolumeProduction) ,typeof(XianZhiHead),typeof(YiZhiWeiShiQi) });
        //全部
        list_all.AddRange(list_verb);
        list_all.AddRange(list_adj);
        list_all.AddRange(list_noun);
        //全部动词+形容词
        list.AddRange(list_verb);
        list.AddRange(list_adj);
        
        

        //《红楼梦》添加动词词条
        hlmList_verb.AddRange(new Type[] { typeof(BuryFlower), typeof(WritePoem), typeof(FallBadly)});
        //《红楼梦》添加形容词词条
        //hlmList_adj.AddRange(new Type[] { typeof(TaiXuHuanJing), typeof(TouXiangQieYu)});
        //《红楼梦》添加名词词条
        hlmList_noun.AddRange(new Type[] { typeof(TeaCup), typeof(LengXiangPill) });
        //《红楼梦》全部词条
        hlmList_all.AddRange(hlmList_verb);
        hlmList_all.AddRange(hlmList_adj);
        hlmList_all.AddRange(hlmList_noun);
        
        /// <summary>动物园全部词条</summary>
        //animalList_all.AddRange(new Type[] { typeof(KeBanXingWei) });
        /// <summary>仿生人全部词条</summary>
        //humanList_all.AddRange(new Type[] { typeof(HeChenAi) });// typeof(Nexus6Arm),
        /// <summary>水晶能量全部词条</summary>
        crystalList_all.AddRange(new Type[] { typeof(TongPinGongZhen) });//, typeof(PinkStone), typeof(PurpleStone), typeof(TigerStone), typeof(WhiteStone)
        /// <summary>女巫学徒全部词条</summary>
        nvwuList_all.AddRange(new Type[] { typeof(FireBall_x)});//, typeof(UnlockMagicCode), typeof(NoteFragment) 

        /// <summary>战斗界面全部词条</summary>
        combatList_all.AddRange(nvwuList_all);
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
    /// 【弹射版本】生成随机词条(包含名词+动词+形容词)
    /// </summary>
    /// <returns></returns>
    public static Type CreateSkillWord()
    {
        int number = UnityEngine.Random.Range(0, list_all.Count);
        return list_all[number];
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
    /// <summary>
    /// 返回《仿生人》中的全部词条
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type HumanWords(int i)
    {
        return humanList_all[i];
    }
    /// <summary>
    /// 返回《动物园》中的全部词条
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type AnimalZooWords(int i)
    {
        return animalList_all[i];
    }
    /// <summary>
    /// 返回《水晶能量》中的全部词条
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type CrystalWords(int i)
    {
        return crystalList_all[i];
    }

}
