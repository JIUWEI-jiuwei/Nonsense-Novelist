using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 挂在父物体上.负责角色和situation的单例
/// </summary>
public class CharacterManager : MonoSingleton<CharacterManager>
{
    public static GameObject father;
    /// <summary>当下全部角色</summary>
    private AbstractCharacter[] Charas;
    public  AbstractCharacter[] charas
    {
        get
        {
            //获取全部角色
            Charas = GetComponentsInChildren<AbstractCharacter>();
            return Charas;
        }
        set
        {
            Charas = value;
        }
    }
    /// <summary>左侧角色</summary>
    public static List< AbstractCharacter> charas_left=new List<AbstractCharacter>();
    /// <summary>右侧角色</summary>
    public static List<AbstractCharacter> charas_right = new List<AbstractCharacter>();

    /// <summary>
    /// int=situation的number。方便快捷寻找situation的自典
    /// </summary>
    public static Dictionary<float, Situation> situationDic = new Dictionary<float, Situation>();


    public override void Awake()
    {
        base.Awake();
        Charas = GetComponentsInChildren<AbstractCharacter>();
        father = this.gameObject;
    }


    private void Start()
    {
        GetAllSituation();
        if (situationDic.Count == 0) print("初始化Situation字典失败");
    }


    /// <summary>
    /// 获取所有的situation，存入字典
    /// </summary>
    static private void GetAllSituation()
    {
        Situation[] _sits;
        _sits = GameObject.Find("AllCharacter").GetComponentsInChildren<Situation>();
        print("初始化situation字典，共有：" + _sits.Length + "个");
        foreach (var _sit in _sits)
        {
            if(!situationDic.ContainsKey(_sit.number))
                situationDic.Add(_sit.number, _sit);
        }
    }


    /// <summary>
    /// 返回与输入的Situation相邻的situation的数值
    /// </summary>
    /// <param name="a">需要计算相邻situation的点</param>
    /// <returns>Situation[0]和Situation[1]（和Situation[2]）</returns>
     public Situation[] GetNearBy_S(Situation a)
    {
        Situation[] _resSits = new Situation[3];

        switch (a.number)
        {
            case 1: { _resSits[0] = situationDic[2]; _resSits[1] = situationDic[3]; _resSits[2] = null; } break;
            case 2: { _resSits[0] = situationDic[1]; _resSits[1] = situationDic[4]; _resSits[2] = null; } break;
            case 3: { _resSits[0] = situationDic[1]; _resSits[1] = situationDic[4]; _resSits[2] = situationDic[4.5f]; } break;
            case 4: { _resSits[0] = situationDic[2]; _resSits[1] = situationDic[3]; _resSits[2] = null; } break;
            case 5: { _resSits[0] = situationDic[6]; _resSits[1] = situationDic[7]; _resSits[2] = situationDic[4.5f]; } break;
            case 6: { _resSits[0] = situationDic[5]; _resSits[1] = situationDic[8]; _resSits[2] = null; } break;
            case 7: { _resSits[0] = situationDic[5]; _resSits[1] = situationDic[8]; _resSits[2] = null; } break;
            case 8: { _resSits[0] = situationDic[6]; _resSits[1] = situationDic[7];  _resSits[2] = null;} break;
        }
        return _resSits;
    }


    /// <summary>
    /// 返回与输入的Situation相邻的situation的数值
    /// </summary>
    /// <param name="a">需要计算相邻situation的点</param>
    /// <returns>Situation[0]和Situation[1]（和Situation[2]）</returns>
    public AbstractCharacter[] GetNearBy_C(Situation a)
    {
        AbstractCharacter[] _resSits = new AbstractCharacter[3];

        switch (a.number)
        {
            case 1: { _resSits[0] = situationDic[2].GetComponentInChildren<AbstractCharacter>(); _resSits[1] = situationDic[3].GetComponentInChildren<AbstractCharacter>(); _resSits[2] = null; } break;
            case 2: { _resSits[0] = situationDic[1].GetComponentInChildren<AbstractCharacter>(); _resSits[1] = situationDic[4].GetComponentInChildren<AbstractCharacter>(); _resSits[2] = null; } break;
            case 3: { _resSits[0] = situationDic[1].GetComponentInChildren<AbstractCharacter>(); _resSits[1] = situationDic[4].GetComponentInChildren<AbstractCharacter>(); _resSits[2] = situationDic[4.5f].GetComponentInChildren<AbstractCharacter>(); } break;
            case 4: { _resSits[0] = situationDic[2].GetComponentInChildren<AbstractCharacter>(); _resSits[1] = situationDic[3].GetComponentInChildren<AbstractCharacter>(); _resSits[2] = null; } break;
            case 5: { _resSits[0] = situationDic[6].GetComponentInChildren<AbstractCharacter>(); _resSits[1] = situationDic[7].GetComponentInChildren<AbstractCharacter>(); _resSits[2] = situationDic[4.5f].GetComponentInChildren<AbstractCharacter>(); } break;
            case 6: { _resSits[0] = situationDic[5].GetComponentInChildren<AbstractCharacter>(); _resSits[1] = situationDic[8].GetComponentInChildren<AbstractCharacter>(); _resSits[2] = null; } break;
            case 7: { _resSits[0] = situationDic[5].GetComponentInChildren<AbstractCharacter>(); _resSits[1] = situationDic[8].GetComponentInChildren<AbstractCharacter>(); _resSits[2] = null; } break;
            case 8: { _resSits[0] = situationDic[6].GetComponentInChildren<AbstractCharacter>(); _resSits[1] = situationDic[7].GetComponentInChildren<AbstractCharacter>(); _resSits[2] = null; } break;
        }
        return _resSits;
    }
}
