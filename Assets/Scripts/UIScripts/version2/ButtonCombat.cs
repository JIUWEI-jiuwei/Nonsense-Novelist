using UnityEngine.UI;
using UnityEngine;

/// <summary>
/// �汾����ս��������ť
/// </summary>
public class ButtonCombat : MonoBehaviour
{
    /// <summary>�ж��Ƿ����н�ɫ��λ</summary>
    public static bool isAllCharaUp;
    /// <summary>�жϽ�ɫ�Ƿ�վλ����</summary>
    public static bool isTwoSides;
    /// <summary>��ʼ��Ϸ��ť</summary>
    private Button start;
    /// <summary>����վλ</summary>
    private GameObject[] situations;
    /// <summary>���н�ɫ</summary>
    private GameObject[] characters;

    private void Start()
    {
        start = GetComponent<Button>();
        situations = GameObject.FindGameObjectsWithTag("situation");
        characters = GameObject.FindGameObjectsWithTag("character");
    }

    /// <summary>
    /// ������վλ��ɫ����
    /// </summary>
    public void ChangeSituationColor()
    {
        if (isTwoSides&&isAllCharaUp)
        {
            foreach (GameObject it in situations)
            {
                it.GetComponent<SpriteRenderer>().material.color = Color.clear;
            }
        }
        
    }
    /// <summary>
    /// ���н�ɫ������ק
    /// </summary>
    public void RemoveCharacterDrag()
    {
        if (isTwoSides && isAllCharaUp)
        {
            foreach (GameObject it in characters)
            {
                Destroy(it.GetComponent<CharacterMouseDrag>());
            }
        }
        

    }
    public void TwoSides()
    {
        
        if (CharacterManager. charas.Length > 0)
        {
            for (int i = 0; i < CharacterManager.charas.Length; i++)
            {
                for (int j = i + 1; j < CharacterManager.charas.Length; j++)
                {
                    if (CharacterManager.charas[i].camp != CharacterManager.charas[j].camp)
                    {
                        isTwoSides = true;
                    }
                }
            }
        }
        if (isAllCharaUp && !isTwoSides)
        {
            print("��������Ҫ��һ����ɫ");
        }
    }
    public void AllCharaUp()
    {
        if (!isAllCharaUp)
        {
            print("���н�ɫδ��λ");
        }
    }
}
