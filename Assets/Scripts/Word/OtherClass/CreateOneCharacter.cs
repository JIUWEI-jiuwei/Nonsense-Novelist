using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ڸ�����(charaPos)�ϣ��������4����ɫ�����壬�ֱ�λ���ĸ���������
/// start��ť��Ӧ����
/// </summary>
public class CreateOneCharacter : MonoBehaviour
{
    /// <summary>���ֶ��ң���ɫԤ�����</summary>
    public GameObject[] charaPrefabs;
    private List<int> array = new List<int>();

    private void Awake()
    {
        //��ʼ�����ĸ���ɫ
        for (int i = 0; i < 4; i++)
        {
            int number = UnityEngine.Random.Range(0, charaPrefabs.Length);
            while (array.Contains(number))//ȥ��
            {
                number = UnityEngine.Random.Range(0, charaPrefabs.Length);
            }
            array.Add(number);

            GameObject chara = Instantiate(charaPrefabs[number]);
            chara.transform.SetParent(this.transform.GetChild(i));
            chara.transform.position = new Vector3(transform.GetChild(i).position.x, transform.GetChild(i).position.y + CharacterMouseDrag.offsetY, transform.GetChild(i).position.z);

        }
    }
    private void Start()
    {
        //����������
        shooter.GetComponent<Shoot>().enabled = false;
        shooter.GetComponent<RollControler>().enabled = false;

    }
    private void Update()
    {
        //�ĸ���ɫȫ���ϳ�
        if (GetComponentInChildren<AbstractCharacter>() == null)
        {
            isAllCharaUp = true;
        }
    }
    /// <summary>�ж��Ƿ����н�ɫ��λ</summary>
    public static bool isAllCharaUp;
    /// <summary>�жϽ�ɫ�Ƿ�վλ����</summary>
    public static bool isTwoSides;
    /// <summary>������(�ֶ�)</summary>
    public GameObject shooter;

   

    /// <summary>
    /// ��ʼս��
    /// </summary>
    public void CombatStart()
    {
        if (CharacterManager.instance.charas.Length > 0)
        {
            for (int i = 0; i < CharacterManager.instance.charas.Length; i++)
            {
                for (int j = i + 1; j < CharacterManager.instance.charas.Length; j++)
                {
                    if (CharacterManager.instance.charas[i].camp != CharacterManager.instance.charas[j].camp)
                    {
                        isTwoSides = true;
                    }
                }
            }
        }
        // ��������Ҫ��һ����ɫ
        if (isAllCharaUp && !isTwoSides)
        {
            print("��������Ҫ��һ����ɫ");
        }
        //���н�ɫδ��λ
        else if (!isAllCharaUp)
        {
            print("���н�ɫδ��λ");
        }
        else if (isTwoSides && isAllCharaUp)//�ɹ���ʼ
        {
            //��UICanvas����
            GameObject.Find("UICanvas").SetActive(false);

            // ������վλ��ɫ����
            foreach (Situation it in Situation.allSituation)
            {
                it.GetComponent<SpriteRenderer>().material.color = Color.clear;
            }
            // ���н�ɫ������ק
            foreach (AbstractCharacter it in CharacterManager.instance.charas)
            {
                it.GetComponent<AI.MyState0>().enabled = true;
                it.GetComponent<AbstractCharacter>().enabled = true;
                Destroy(it.GetComponent<CharacterMouseDrag>());
            }
            //����������
            shooter.GetComponent<Shoot>().enabled = true;
            shooter.GetComponent<RollControler>().enabled = true;

        }

    }

}
