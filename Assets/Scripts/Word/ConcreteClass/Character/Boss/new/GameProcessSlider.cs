using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#region 结构体
[System.Serializable]public struct Time_Stage
{
    public GameObject boss;//boss 的预制体
    public float time;//持续时间
    public Sprite image;//对应图标
    [HideInInspector]public float time_count;//累计时间
}
#endregion


public class GameProcessSlider : MonoBehaviour
{


    [Header("进度图标预制体（手动）")]
    public GameObject perfab_icon;

    [Header("【单位：s】游戏进程相关参数（手动）")]
    public Time_Stage[] time_stage;

    private int stageCount=0;
    private float time_all=0;
    private float timeNow = 0;

    private bool countTime = false;//计时开关
    private Slider sliderProcess;
<<<<<<< HEAD


    [Header("中场抽取书本加入游戏")]
    public GameObject bookCanvas;
    public GameObject characterCanvas;

    private void Start()
    {
        //其它设置
        bookCanvas.SetActive(false);
        characterCanvas.SetActive(true);

        //生成进度条
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

        //如果超出
        if (stageCount >= time_stage.Length)
        {
            Debug.LogWarning("time_stage overCount!");
            countTime = false;
        }

        //如果进入阶段
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
    /// 生成boss
    /// </summary>
    /// <param name="_boss"></param>
    void CreateBoss(GameObject _boss)
    {
        print("生成boss");

        //生成boss
        GameObject boss = Instantiate(_boss);
        boss.transform.SetParent(GameObject.Find("Circle5.5").transform);
        boss.transform.localPosition = Vector3.zero;

        //生成调整
        boss.GetComponentInChildren<AI.MyState0>().enabled = true;
        boss.GetComponent<AbstractCharacter>().enabled = true;
        boss.gameObject.AddComponent(typeof(AfterStart));
        Destroy(boss.GetComponent<CharacterMouseDrag>());

        //设置一个随机目标，使其进入攻击状态
        IAttackRange attackRange = new SingleSelector();

        //这一句越级了
        AbstractCharacter[] a = attackRange.CaculateRange(100, boss.GetComponent<AbstractCharacter>().situation, NeedCampEnum.all);
        boss.GetComponentInChildren<AI.MyState0>().aim = a[Random.Range(0, a.Length)];


    }

<<<<<<< HEAD
    /// <summary>
    ///进入抽取书本页面
    /// </summary>
    void CreateBookCanvas()
    {  
        //镜头拉远
        Camera.main.GetComponent<CameraController>().SetCameraSizeTo(5);
        //游戏暂停
        CharacterManager.instance.pause = true;
        //生成面板
        bookCanvas.SetActive(true);
        characterCanvas.SetActive(false);
    }
    /// <summary>
    /// 在BookCanvas的确认按钮Onclick上调用
    /// </summary>
    public void BookCanvasClickYes()
    {
        //进入放角色页面
        //生成面板
        bookCanvas.SetActive(false);
        characterCanvas.SetActive(true);

        GameObject.Find("UICanvas").GetComponentInChildren<CreateOneCharacter>().CreateNewCharacter(2);
    }
=======

>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
    /// <summary>
    /// 在createOneCharacter中执行
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
