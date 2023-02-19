using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���ڸ�������
/// </summary>
public class CharacterManager : MonoSingleton<CharacterManager>
{
    public static GameObject father;
    /// <summary>����ȫ����ɫ</summary>
    private AbstractCharacter[] Charas;
    public  AbstractCharacter[] charas
    {
        get
        {
            //��ȡȫ����ɫ
            Charas = GetComponentsInChildren<AbstractCharacter>();
            return Charas;
        }
        set
        {
            Charas = value;
        }
    }
    /// <summary>����ɫ</summary>
    public static List< AbstractCharacter> charas_left=new List<AbstractCharacter>();
    /// <summary>�Ҳ��ɫ</summary>
    public static List<AbstractCharacter> charas_right = new List<AbstractCharacter>();


    public override void Awake()
    {
        base.Awake();
        Charas = GetComponentsInChildren<AbstractCharacter>();
        father = this.gameObject;
    }
}
