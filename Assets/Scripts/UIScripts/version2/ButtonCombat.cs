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
    /// <summary>������</summary>
    public GameObject shooter;

    private void Start()
    {
        start = GetComponent<Button>();
        situations = GameObject.FindGameObjectsWithTag("situation");
        characters = GameObject.FindGameObjectsWithTag("character");
        //����������
        shooter.GetComponent<Shoot>().enabled = false;
        shooter.GetComponent<RollControler>().enabled = false;

    }

    /// <summary>
    /// ������վλ��ɫ����
    /// </summary>
    public void ChangeSituationColor()
    {
        if (isTwoSides&&isAllCharaUp)
        {
            // ������վλ��ɫ����
            foreach (GameObject it in situations)
            {
                it.GetComponent<SpriteRenderer>().material.color = Color.clear;
            }
            // ���н�ɫ������ק
            foreach (GameObject it in characters)
            {
                Destroy(it.GetComponent<CharacterMouseDrag>());
            }
            //����������
            shooter.GetComponent<Shoot>().enabled = true;
            shooter.GetComponent<RollControler>().enabled = true;

        }
        
    }


    /// <summary>
    /// ��������Ҫ��һ����ɫ
    /// </summary>
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
    /// <summary>
    /// ���н�ɫδ��λ
    /// </summary>
    public void AllCharaUp()
    {
        if (!isAllCharaUp)
        {
            print("���н�ɫδ��λ");
        }
    }
}
