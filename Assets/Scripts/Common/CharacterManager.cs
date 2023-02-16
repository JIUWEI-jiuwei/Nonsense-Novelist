using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���ڸ�������
/// </summary>
public class CharacterManager : MonoBehaviour
{
    public static GameObject father;
    /// <summary>����ȫ����ɫ</summary>
    public static AbstractCharacter[] charas;
    /// <summary>����ɫ</summary>
    public static List< AbstractCharacter> charas_left;
    /// <summary>�Ҳ��ɫ</summary>
    public static List<AbstractCharacter> charas_right;


    private void Awake()
    {
        father = this.gameObject;
    }
    private void Update()
    {
        //��ȡȫ����ɫ
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
