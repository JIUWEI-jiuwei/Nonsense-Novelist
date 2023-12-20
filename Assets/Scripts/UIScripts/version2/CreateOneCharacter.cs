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
       Camera.main.GetComponent<CameraController>().SetCameraSizeTo(5);
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

            SpriteRenderer _sr = chara.GetComponentInChildren<AI.MyState0>().GetComponent<SpriteRenderer>();
            //��ɫ����ʾͼ��ָ�����
            _sr.sortingLayerName = "UICanvas";
            _sr.sortingOrder = 3;
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
            //camera�ı�
            Camera.main.GetComponent<CameraController>().SetCameraSizeTo(4);

            //��UICanvas����
            GameObject.Find("UICanvas").SetActive(false);

            //������������ʼ����
            GameObject.Find("GameProcess").GetComponent<GameProcessSlider>().ProcessStart();
            //װ��һ��shooter
            GameObject.Find("shooter").GetComponent<Shoot>().ReadyWordBullet();

            // ������վλ��ɫ����
            foreach (Situation it in Situation.allSituation)
            {
                it.GetComponent<SpriteRenderer>().material.color = Color.clear;
            }
            // ���н�ɫ������ק
            foreach (AbstractCharacter it in CharacterManager.instance.charas)
            {
                //��ɫ����ʾͼ��ָ�����
                it.charaAnim.GetComponent<SpriteRenderer>().sortingLayerName = "Character";
                it.charaAnim.GetComponent<SpriteRenderer>().sortingOrder = 2 /*+(int) it.charaAnim.transform.parent.GetComponent<Situation>().number*/;
                // it.GetComponent<SpriteRenderer>().sortingLayerName = "Character";
                //it.GetComponent<SpriteRenderer>().sortingOrder = 2;

                //
                it.charaAnim.GetComponent<AI.MyState0>().enabled = true;
                it.GetComponent<AbstractCharacter>().enabled = true;
                it.gameObject.AddComponent(typeof(AfterStart));
                Destroy(it.GetComponent<CharacterMouseDrag>());
            }
            //����������
            shooter.GetComponent<Shoot>().enabled = true;
            shooter.GetComponent<RollControler>().enabled = true;

        }

    }

}
