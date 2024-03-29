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

    /// <summary>动物园名词词条</summary>
    public static List<Type> animalList_noun = new List<Type>();
    /// <summary>动物园形容词词条</summary>
    public static List<Type> animalList_adj = new List<Type>();
    /// <summary>动物园动词词条</summary>
    public static List<Type> animalList_verb = new List<Type>();
    /// <summary>动物园全部词条</summary>
    public static List<Type> animalList_all = new List<Type>();

    /// <summary>仿生人名词词条</summary>
    public static List<Type> humanList_noun = new List<Type>();
    /// <summary>仿生人形容词词条</summary>
    public static List<Type> humanList_adj = new List<Type>();
    /// <summary>仿生人动词词条</summary>
    public static List<Type> humanList_verb = new List<Type>();
    /// <summary>仿生人全部词条</summary>
    public static List<Type> humanList_all = new List<Type>();

    /// <summary>水晶能量名词词条</summary>
    public static List<Type> crystalList_noun = new List<Type>();
    /// <summary>水晶能量形容词词条</summary>
    public static List<Type> crystalList_adj = new List<Type>();
    /// <summary>水晶能量动词词条</summary>
    public static List<Type> crystalList_verb = new List<Type>();
    /// <summary>水晶能量全部词条</summary>
    public static List<Type> crystalList_all = new List<Type>();

    /// <summary>莎乐美名词词条</summary>
    public static List<Type> shaLeMeiList_noun = new List<Type>();
    /// <summary>莎乐美形容词词条</summary>
    public static List<Type> shaLeMeiList_adj = new List<Type>();
    /// <summary>莎乐美动词词条</summary>
    public static List<Type> shaLeMeiList_verb = new List<Type>();
    /// <summary>莎乐美全部词条</summary>
    public static List<Type> shaLeMeiList_all = new List<Type>();
    
    /// <summary>埃及神话名词词条</summary>
    public static List<Type> aiJiShenHuaList_noun = new List<Type>();
    /// <summary>埃及神话形容词词条</summary>
    public static List<Type> aiJiShenHuaList_adj = new List<Type>();
    /// <summary>埃及神话动词词条</summary>
    public static List<Type> aiJiShenHuaList_verb = new List<Type>();
    /// <summary>埃及神话全部词条</summary>
    public static List<Type> aiJiShenHuaList_all = new List<Type>();
   
    /// <summary>流行病学名词词条</summary>
    public static List<Type> liuXingBXList_noun = new List<Type>();
    /// <summary>流行病学形容词词条</summary>
    public static List<Type> liuXingBXList_adj = new List<Type>();
    /// <summary>流行病学动词词条</summary>
    public static List<Type> liuXingBXList_verb = new List<Type>();
    /// <summary>流行病学全部词条</summary>
    public static List<Type> liuXingBXList_all = new List<Type>();
   
    /// <summary>蚂蚁帝国名词词条</summary>
    public static List<Type> maYiDiGuoList_noun = new List<Type>();
    /// <summary>蚂蚁帝国形容词词条</summary>
    public static List<Type> maYiDiGuoList_adj = new List<Type>();
    /// <summary>蚂蚁帝国动词词条</summary>
    public static List<Type> maYiDiGuoList_verb = new List<Type>();
    /// <summary>蚂蚁帝国全部词条</summary>
    public static List<Type> maYiDiGuoList_all = new List<Type>();
   
    /// <summary>通用名词词条</summary>
    public static List<Type> commonList_noun = new List<Type>();
    /// <summary>通用形容词词条</summary>
    public static List<Type> commonList_adj = new List<Type>();
    /// <summary>通用动词词条</summary>
    public static List<Type> commonList_verb = new List<Type>();
    /// <summary>通用全部词条</summary>
    public static List<Type> commonList_all = new List<Type>();
   
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
        

        //《红楼梦》添加动词词条
        hlmList_verb.AddRange(new Type[] { typeof(BuryFlower), typeof(WritePoem)});
        //《红楼梦》添加形容词词条
        hlmList_adj.AddRange(new Type[] { typeof(ChaFanWuXin), typeof(ShenYouHuanJing)});
        //《红楼梦》添加名词词条
        hlmList_noun.AddRange(new Type[] { typeof(TeaCup), typeof(LengXiangPill) });
        //《红楼梦》全部词条
        hlmList_all.AddRange(hlmList_verb);
        hlmList_all.AddRange(hlmList_adj);
        hlmList_all.AddRange(hlmList_noun);

        //动物园添加动词词条
        animalList_verb.AddRange(new Type[] { typeof(WanShua), typeof(ShaYu) });
        //动物园添加形容词词条
        animalList_adj.AddRange(new Type[] { typeof(KeBan), typeof(YouAnQuanGan) });
        //动物园添加名词词条
        animalList_noun.AddRange(new Type[] { typeof(BenJieShiDui), typeof(YiZhiWeiShiQi) });
        //动物园全部词条
        animalList_all.AddRange(animalList_verb);
        animalList_all.AddRange(animalList_adj);
        animalList_all.AddRange(animalList_noun);

        //仿生人添加动词词条
        humanList_verb.AddRange(new Type[] { typeof(TuLingCeShi), typeof(GunShoot) });
        //仿生人添加形容词词条
        humanList_adj.AddRange(new Type[] { typeof(HeWuRan), typeof(RenZao) });
        //仿生人添加名词词条
        humanList_noun.AddRange(new Type[] { typeof(Nexus_6Arm), typeof(VolumeProduction), typeof(MemoryImplantion) });
        //仿生人全部词条
        humanList_all.AddRange(humanList_verb);
        humanList_all.AddRange(humanList_adj);
        humanList_all.AddRange(humanList_noun);

        //水晶能量添加动词词条
        crystalList_verb.AddRange(new Type[] { typeof(TongPinGongZhen)});
        //水晶能量添加形容词词条
        crystalList_adj.AddRange(new Type[] { typeof(QingXi)});
        //水晶能量添加名词词条
        crystalList_noun.AddRange(new Type[] { typeof(WhiteStone), typeof(PurpleStone), typeof(TigerStone), typeof(MeiGuiShiYing) });
        //水晶能量全部词条
        crystalList_all.AddRange(crystalList_verb);
        crystalList_all.AddRange(crystalList_adj);
        crystalList_all.AddRange(crystalList_noun);

        //莎乐美添加动词词条
        shaLeMeiList_verb.AddRange(new Type[] { typeof(QiChongShaDance),typeof(Kiss)});
        //莎乐美添加形容词词条
        shaLeMeiList_adj.AddRange(new Type[] { typeof(XinShenJiDang),typeof(LuanLun),typeof(HunQianMengYing),});
        //莎乐美添加名词词条
        shaLeMeiList_noun.AddRange(new Type[] { typeof(XianZhiHead)});
        //莎乐美全部词条
        shaLeMeiList_all.AddRange(shaLeMeiList_verb);
        shaLeMeiList_all.AddRange(shaLeMeiList_adj);
        shaLeMeiList_all.AddRange(shaLeMeiList_noun);

        //埃及神话添加动词词条
        aiJiShenHuaList_verb.AddRange(new Type[] { typeof(FangFuShu)});
        //埃及神话添加形容词词条
        aiJiShenHuaList_adj.AddRange(new Type[] { typeof(FengChan),typeof(BuXiu),});
        //埃及神话添加名词词条
        aiJiShenHuaList_noun.AddRange(new Type[] { typeof(RiLunGuaZhui),typeof(HorusEyes),});
        //埃及神话全部词条
        aiJiShenHuaList_all.AddRange(aiJiShenHuaList_verb);
        aiJiShenHuaList_all.AddRange(aiJiShenHuaList_adj);
        aiJiShenHuaList_all.AddRange(aiJiShenHuaList_noun);

        //流行病学添加动词词条
        liuXingBXList_verb.AddRange(new Type[] { typeof(WenYiChuanBo),typeof(MianYiZengQiang),});
        //流行病学添加形容词词条
        liuXingBXList_adj.AddRange(new Type[] { typeof(ShenHuanFeiYan),typeof(GuoMin),});
        //流行病学添加名词词条
        liuXingBXList_noun.AddRange(new Type[] { typeof(JiShengChong),typeof(EXingZhongLiu),});
        //流行病学全部词条
        liuXingBXList_all.AddRange(liuXingBXList_verb);
        liuXingBXList_all.AddRange(liuXingBXList_adj);
        liuXingBXList_all.AddRange(liuXingBXList_noun);

        //蚂蚁帝国添加动词词条
        maYiDiGuoList_verb.AddRange(new Type[] { typeof(CHOOHShoot),});
        //蚂蚁帝国添加形容词词条
        maYiDiGuoList_adj.AddRange(new Type[] { typeof(SanFaFeiLuoMeng),typeof(HunFei),typeof(HaoZhan),});
        //蚂蚁帝国添加名词词条
        maYiDiGuoList_noun.AddRange(new Type[] { typeof(Exoskeleton),typeof(DuXian),});
        //蚂蚁帝国全部词条
        maYiDiGuoList_all.AddRange(maYiDiGuoList_verb);
        maYiDiGuoList_all.AddRange(maYiDiGuoList_adj);
        maYiDiGuoList_all.AddRange(maYiDiGuoList_noun);

        //通用添加动词词条
        commonList_verb.AddRange(new Type[] { typeof(FallBadly),typeof(HeartBroken),typeof(ToBigger),typeof(BaoZa),});
        //通用添加形容词词条
        commonList_adj.AddRange(new Type[] { typeof(FengLi),typeof(QuicklyGrowing),typeof(LuoYingBinFen),typeof(CuZhuang),
            typeof(JianRuPanShi),typeof(ZhongDu),});
        //通用添加名词词条
        commonList_noun.AddRange(new Type[] { typeof(FuTouAxe),typeof(ThickDictionary),typeof(StrangeStatue),typeof(GlassPendant),});
        //通用全部词条
        commonList_all.AddRange(commonList_verb);
        commonList_all.AddRange(commonList_adj);
        commonList_all.AddRange(commonList_noun);


        /// <summary>战斗界面全部词条</summary>
        combatList_all.AddRange(shaLeMeiList_all);
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

}
