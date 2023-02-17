using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 挂在父物体上
/// </summary>
public class CharacterManager : MonoBehaviour
{
    public static GameObject father;
    /// <summary>当下全部角色</summary>
    public static AbstractCharacter[] charas;
    /// <summary>左侧角色</summary>
    public static List< AbstractCharacter> charas_left=new List<AbstractCharacter>();
    /// <summary>右侧角色</summary>
    public static List<AbstractCharacter> charas_right = new List<AbstractCharacter>();


    private void Awake()
    {
        father = this.gameObject;
    }
    private void Update()
    {
        //获取全部角色
        charas= GetComponentsInChildren<AbstractCharacter>();

        for(int i = 0; i < charas.Length; i++)
        {
            if (charas[i].camp == CampEnum.left)
            {
                charas_left.Add(charas[i]);
            }
            else if (charas[i].camp == CampEnum.right)
            {
                charas_right.Add(charas[i]);
            }
        }
        
    }
}
