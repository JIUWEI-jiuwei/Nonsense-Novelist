using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// ���ڸ�����(charaPos)�ϣ��������4����ɫ�����壬�ֱ�λ���ĸ���������
/// start��ť��Ӧ����
/// </summary>
public class CreateOneCharacter : MonoBehaviour
{
    /// <summary>���ֶ��ң���ɫԤ�����</summary>
    /// 
    [Header("���ֶ��ң���ɫԤ�����")]
    public GameObject[] charaPrefabs;
    private List<int> array = new List<int>();

    [Header("������ʾ���ı����")]
    public Text text;

    [Header("���ֶ��ң���Χǽ��")]
    public GameObject wallP;
    private bool needUpdate = true;
  

    private void Awake()
    {
<<<<<<< HEAD
        wallP.SetActive(false);
        Camera.main.GetComponent<CameraController>().SetCameraSizeTo(5);
=======
       Camera.main.GetComponent<CameraController>().SetCameraSizeTo(5);
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
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
        CharacterManager.instance.pause = true;


    }
    private void Update()
    {
        if (!needUpdate)
            return;

        //�ĸ���ɫȫ���ϳ�
        if (GetComponentInChildren<AbstractCharacter>() == null)
        {
            isAllCharaUp = true;
            needUpdate = false;
        }
    }
    /// <summary>�ж��Ƿ����н�ɫ��λ</summary>
    public static bool isAllCharaUp;
    /// <summary>�жϽ�ɫ�Ƿ�վλ����</summary>
    public static bool isTwoSides;
    ///// <summary>������(�ֶ�)</summary>
    //public GameObject shooter;

   
    

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
            text.color = Color.red;
            text.text = "��������Ҫ��һ����ɫ";
        }
        //���н�ɫδ��λ
        else if (!isAllCharaUp)
        {
            text.color = Color.red;
            text.text = "���н�ɫδ��λ";
        }
        else if (isTwoSides && isAllCharaUp)//�ɹ���ʼ
        {
<<<<<<< HEAD
            //
            wallP.SetActive(true);
            //camera�ı�
            Camera.main.GetComponent<CameraController>().SetCameraSizeTo(3.7f);
=======
            //camera�ı�
            Camera.main.GetComponent<CameraController>().SetCameraSizeTo(4);
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454

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

            //�ָ���ͣ
            CharacterManager.instance.pause = false;

        }

    }

/// <summary>
/// �ⲿ���á�����count�����Ľ�ɫ��
/// </summary>
/// <param name="count"></param>
    public void CreateNewCharacter(int count)
    {
        //���ɽ�ɫ
       
        for (int i = 0; i < count; i++)
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

        //��ʵʱ������
        needUpdate = true;

   

        //��վλ��ɫ
        foreach (Situation it in Situation.allSituation)
        {
            if (it.GetComponentInChildren<AbstractCharacter>() == null)
            {
                it.GetComponent<SpriteRenderer>().material.color = Color.white;
            }
            //it.GetComponent<SpriteRenderer>().material.color = Color.white;
        }


    }
}
