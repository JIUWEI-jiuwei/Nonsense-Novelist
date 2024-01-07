using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 挂在父物体上
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


    public override void Awake()
    {
        base.Awake();
        Charas = GetComponentsInChildren<AbstractCharacter>();
        father = this.gameObject;
    }
}
