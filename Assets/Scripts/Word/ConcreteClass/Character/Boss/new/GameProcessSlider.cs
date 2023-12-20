using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#region �ṹ��
[System.Serializable]public struct Time_Stage
{
    public GameObject boss;//boss ��Ԥ����
    public float time;//����ʱ��
    public Sprite image;//��Ӧͼ��
    [HideInInspector]public float time_count;//�ۼ�ʱ��
}
#endregion


public class GameProcessSlider : MonoBehaviour
{


    [Header("����ͼ��Ԥ���壨�ֶ���")]
    public GameObject perfab_icon;

    [Header("����λ��s����Ϸ������ز������ֶ���")]
    public Time_Stage[] time_stage;

    private int stageCount=0;
    private float time_all=0;
    private float timeNow = 0;

    private bool countTime = false;//��ʱ����
    private Slider sliderProcess;
<<<<<<< HEAD


    [Header("�г���ȡ�鱾������Ϸ")]
    public GameObject bookCanvas;
    public GameObject characterCanvas;

    private void Start()
    {
        //��������
        bookCanvas.SetActive(false);
        characterCanvas.SetActive(true);

        //���ɽ�����
=======
   

    private void Start()
    {
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        sliderProcess = this.GetComponent<Slider>();
        sliderProcess.value = 0;

        for (int _i=0;_i<time_stage.Length;_i++)
        { time_all += time_stage[_i].time;}
        sliderProcess.maxValue = time_all;

        float _timeAmount=0;
        float _width = GetComponent<RectTransform>().sizeDelta.x;
        for (int _i = 0; _i < time_stage.Length; _i++)
        {
          
            _timeAmount += time_stage[_i].time;
            time_stage[_i].time_count = _timeAmount;
       
            GameObject _icon=GameObject.Instantiate<GameObject>(perfab_icon);
            _icon.transform.SetParent(this.transform);
            _icon.GetComponent<RectTransform>().localPosition = Vector3.zero;
            _icon.GetComponent<RectTransform>().localScale = Vector3.one;
            _icon.GetComponent<RectTransform>().localPosition += new Vector3(-_width/2+(_timeAmount / time_all)*_width, 0,0);
            _icon.GetComponent<Image>().sprite = time_stage[_i].image;
        }
        sliderProcess.maxValue = time_all;
        
       
    }
    private void FixedUpdate()
    {
        if (!countTime)
            return;


        timeNow += Time.deltaTime;
        sliderProcess.value = timeNow ;

        //�������
        if (stageCount >= time_stage.Length)
        {
            Debug.LogWarning("time_stage overCount!");
            countTime = false;
        }

        //�������׶�
        if (timeNow>time_stage[stageCount].time_count)
        {
<<<<<<< HEAD
            CreateBookCanvas();
            //CreateBoss(time_stage[stageCount].boss);
=======
            CreateBoss(time_stage[stageCount].boss);
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454

            countTime = false;
            stageCount++;
        }
    }


    /// <summary>
    /// ����boss
    /// </summary>
    /// <param name="_boss"></param>
    void CreateBoss(GameObject _boss)
    {
        print("����boss");

        //����boss
        GameObject boss = Instantiate(_boss);
        boss.transform.SetParent(GameObject.Find("Circle5.5").transform);
        boss.transform.localPosition = Vector3.zero;

        //���ɵ���
        boss.GetComponentInChildren<AI.MyState0>().enabled = true;
        boss.GetComponent<AbstractCharacter>().enabled = true;
        boss.gameObject.AddComponent(typeof(AfterStart));
        Destroy(boss.GetComponent<CharacterMouseDrag>());

        //����һ�����Ŀ�꣬ʹ����빥��״̬
        IAttackRange attackRange = new SingleSelector();

        //��һ��Խ����
        AbstractCharacter[] a = attackRange.CaculateRange(100, boss.GetComponent<AbstractCharacter>().situation, NeedCampEnum.all);
        boss.GetComponentInChildren<AI.MyState0>().aim = a[Random.Range(0, a.Length)];


    }

<<<<<<< HEAD
    /// <summary>
    ///�����ȡ�鱾ҳ��
    /// </summary>
    void CreateBookCanvas()
    {  
        //��ͷ��Զ
        Camera.main.GetComponent<CameraController>().SetCameraSizeTo(5);
        //��Ϸ��ͣ
        CharacterManager.instance.pause = true;
        //�������
        bookCanvas.SetActive(true);
        characterCanvas.SetActive(false);
    }
    /// <summary>
    /// ��BookCanvas��ȷ�ϰ�ťOnclick�ϵ���
    /// </summary>
    public void BookCanvasClickYes()
    {
        //����Ž�ɫҳ��
        //�������
        bookCanvas.SetActive(false);
        characterCanvas.SetActive(true);

        GameObject.Find("UICanvas").GetComponentInChildren<CreateOneCharacter>().CreateNewCharacter(2);
    }
=======

>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
    /// <summary>
    /// ��createOneCharacter��ִ��
    /// </summary>
    public void ProcessStart()
    {
        countTime = true;
<<<<<<< HEAD
        CharacterManager.instance.pause = false;
=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
    }
 
    void Update()
    {
        #region test
        if (Input.GetKeyDown(KeyCode.R))
        {
            timeNow = time_stage[stageCount].time_count - 0.5f;
            countTime = true;
        }
    #endregion
    }
}
