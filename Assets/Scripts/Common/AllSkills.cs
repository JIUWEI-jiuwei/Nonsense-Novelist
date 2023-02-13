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

    /// <summary>����԰ȫ������</summary>
    public static List<Type> animalList_all = new List<Type>();
    /// <summary>������ȫ������</summary>
    public static List<Type> humanList_all = new List<Type>();
    /// <summary>ˮ������ȫ������</summary>
    public static List<Type> crystalList_all = new List<Type>();
    /// <summary>Ů��ѧͽȫ������</summary>
    public static List<Type> nvwuList_all = new List<Type>();
    /// <summary>ս������ȫ������</summary>
    public static List<Type> combatList_all = new List<Type>();


    /// <summary>6����ʼ����</summary>
    public static Type[] absWords = new Type[6];
    /// <summary>
    /// ��̬���캯��
    /// </summary>
    static AllSkills()
    {       
        //��Ӷ��ʴ���
        list_verb.AddRange(new Type[] { typeof(BuryFlower),  typeof(WritePoem) , typeof(HeartBroken),
           typeof(CHOOHShoot) ,typeof(FallBadly),typeof(QiChongShaDance),typeof(TongPinGongZhen),
        typeof(BaoZa), typeof(FangFuShu), typeof(GunShoot), typeof(Kiss),typeof(MianYiZengQiang),
        typeof(ShaYu), typeof(ToBigger), typeof(TuLingCeShi), typeof(WanShua), typeof(WenYiChuanBo)});
        //������ݴʴ���
        list_adj.AddRange(new Type[] {  typeof(BuXiu), typeof(ChaFanWuXin), typeof(CuZhuang), typeof(HunFei),
           typeof(FengChan),typeof(FengLi) ,typeof(GuoMin),typeof(HaoZhan) ,typeof(HeWuRan),typeof(HunQianMengYing),
        typeof(JianRuPanShi),typeof(KeBan) ,typeof(LuanLun),typeof(LuoYingBinFen) ,typeof(QingXi),typeof(QuicklyGrowing),
        typeof(RenZao),typeof(SanFaFeiLuoMeng) ,typeof(ShenHuanFeiYan),typeof(ShenYouHuanJing) ,typeof(XinShenJiDang),
            typeof(YouAnQuanGan),typeof(ZhongDu),});
        //������ʴ���
        list_noun.AddRange(new Type[] { typeof(Exoskeleton), typeof(JiShengChong), typeof(LengXiangPill), typeof(Nexus_6Arm),
            typeof(PurpleStone) ,typeof(RiLunGuaZhui),typeof(BenJieShiDui),typeof(DuXian),
            typeof(TeaCup),typeof(TigerStone) ,typeof(WhiteStone) ,typeof(FuTouAxe),typeof(GlassPendant),
            typeof(HorusEyes),typeof(MeiGuiShiYing) ,typeof(MemoryImplantion),typeof(PaintBrush),typeof(StrangeStatue),
            typeof(ThickDictionary),typeof(VolumeProduction) ,typeof(XianZhiHead),typeof(YiZhiWeiShiQi) });
        //ȫ��
        list_all.AddRange(list_verb);
        list_all.AddRange(list_adj);
        list_all.AddRange(list_noun);
        //ȫ������+���ݴ�
        list.AddRange(list_verb);
        list.AddRange(list_adj);
        
        

        //����¥�Ρ���Ӷ��ʴ���
        hlmList_verb.AddRange(new Type[] { typeof(BuryFlower), typeof(WritePoem), typeof(FallBadly)});
        //����¥�Ρ�������ݴʴ���
        //hlmList_adj.AddRange(new Type[] { typeof(TaiXuHuanJing), typeof(TouXiangQieYu)});
        //����¥�Ρ�������ʴ���
        hlmList_noun.AddRange(new Type[] { typeof(TeaCup), typeof(LengXiangPill) });
        //����¥�Ρ�ȫ������
        hlmList_all.AddRange(hlmList_verb);
        hlmList_all.AddRange(hlmList_adj);
        hlmList_all.AddRange(hlmList_noun);
        
        /// <summary>����԰ȫ������</summary>
        //animalList_all.AddRange(new Type[] { typeof(KeBanXingWei) });
        /// <summary>������ȫ������</summary>
        //humanList_all.AddRange(new Type[] { typeof(HeChenAi) });// typeof(Nexus6Arm),
        /// <summary>ˮ������ȫ������</summary>
        crystalList_all.AddRange(new Type[] { typeof(TongPinGongZhen) });//, typeof(PinkStone), typeof(PurpleStone), typeof(TigerStone), typeof(WhiteStone)
        /// <summary>Ů��ѧͽȫ������</summary>
        nvwuList_all.AddRange(new Type[] { typeof(FireBall_x)});//, typeof(UnlockMagicCode), typeof(NoteFragment) 

        /// <summary>ս������ȫ������</summary>
        combatList_all.AddRange(nvwuList_all);
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
    /// ������汾�������������(��������+����+���ݴ�)
    /// </summary>
    /// <returns></returns>
    public static Type CreateSkillWord()
    {
        int number = UnityEngine.Random.Range(0, list_all.Count);
        return list_all[number];
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
    /// <summary>
    /// ���ء������ˡ��е�ȫ������
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type HumanWords(int i)
    {
        return humanList_all[i];
    }
    /// <summary>
    /// ���ء�����԰���е�ȫ������
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type AnimalZooWords(int i)
    {
        return animalList_all[i];
    }
    /// <summary>
    /// ���ء�ˮ���������е�ȫ������
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static Type CrystalWords(int i)
    {
        return crystalList_all[i];
    }

}
