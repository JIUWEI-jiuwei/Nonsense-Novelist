using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 挂在父物体(charaPos)上，随机生成4个角色子物体，分别位于四个空物体下
/// start按钮响应函数
/// </summary>
public class CreateOneCharacter : MonoBehaviour
{
    /// <summary>（手动挂）角色预制体池</summary>
    /// 
    [Header("（手动挂）角色预制体池")]
    public GameObject[] charaPrefabs;
    private List<int> array = new List<int>();

    [Header("用于提示的文本组件")]
    public Text text;

    [Header("（手动挂）外围墙体")]
    public GameObject wallP;
    private bool needUpdate = true;
  

    private void Awake()
    {
        wallP.SetActive(false);
        Camera.main.GetComponent<CameraController>().SetCameraSizeTo(5);
        //初始生成四个角色
        for (int i = 0; i < 4; i++)
        {
            int number = UnityEngine.Random.Range(0, charaPrefabs.Length);
            while (array.Contains(number))//去重
            {
                number = UnityEngine.Random.Range(0, charaPrefabs.Length);
            }
            array.Add(number);

            GameObject chara = Instantiate(charaPrefabs[number]);
            chara.transform.SetParent(this.transform.GetChild(i));
            chara.transform.position = new Vector3(transform.GetChild(i).position.x, transform.GetChild(i).position.y + CharacterMouseDrag.offsetY, transform.GetChild(i).position.z);

            SpriteRenderer _sr = chara.GetComponentInChildren<AI.MyState0>().GetComponent<SpriteRenderer>();
            //角色的显示图层恢复正常
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

        //四个角色全部上场
        if (GetComponentInChildren<AbstractCharacter>() == null)
        {
            isAllCharaUp = true;
            needUpdate = false;
        }
    }
    /// <summary>判断是否所有角色就位</summary>
    public static bool isAllCharaUp;
    /// <summary>判断角色是否站位两侧</summary>
    public static bool isTwoSides;
    ///// <summary>发射器(手动)</summary>
    //public GameObject shooter;

   
    

    /// <summary>
    /// 开始战斗
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
        // 两方至少要有一名角色
        if (isAllCharaUp && !isTwoSides)
        {
            text.color = Color.red;
            text.text = "两方至少要有一名角色";
        }
        //仍有角色未就位
        else if (!isAllCharaUp)
        {
            text.color = Color.red;
            text.text = "仍有角色未就位";
        }
        else if (isTwoSides && isAllCharaUp)//成功开始
        {
            //
            wallP.SetActive(true);
            //camera改变
            Camera.main.GetComponent<CameraController>().SetCameraSizeTo(3.7f);

            //将UICanvas隐藏
            GameObject.Find("UICanvas").SetActive(false);

            //触发进度条开始开关
            GameObject.Find("GameProcess").GetComponent<GameProcessSlider>().ProcessStart();
            //装载一个shooter
            GameObject.Find("shooter").GetComponent<Shoot>().ReadyWordBullet();

            // 将所有站位颜色隐藏
            foreach (Situation it in Situation.allSituation)
            {
                
                it.GetComponent<SpriteRenderer>().material.color = Color.clear;
            }
            // 所有角色不可拖拽
            foreach (AbstractCharacter it in CharacterManager.instance.charas)
            {
                //角色的显示图层恢复正常
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

            //恢复暂停
            CharacterManager.instance.pause = false;

        }

    }

/// <summary>
/// 外部调用。生成count数量的角色。
/// </summary>
/// <param name="count"></param>
    public void CreateNewCharacter(int count)
    {
        //生成角色
       
        for (int i = 0; i < count; i++)
        {
            int number = UnityEngine.Random.Range(0, charaPrefabs.Length);
            while (array.Contains(number))//去重
            {
                number = UnityEngine.Random.Range(0, charaPrefabs.Length);
            }
            array.Add(number);

            GameObject chara = Instantiate(charaPrefabs[number]);
            chara.transform.SetParent(this.transform.GetChild(i));
            chara.transform.position = new Vector3(transform.GetChild(i).position.x, transform.GetChild(i).position.y + CharacterMouseDrag.offsetY, transform.GetChild(i).position.z);

            SpriteRenderer _sr = chara.GetComponentInChildren<AI.MyState0>().GetComponent<SpriteRenderer>();
            //角色的显示图层恢复正常
            _sr.sortingLayerName = "UICanvas";
            _sr.sortingOrder = 3;
        }

        //打开实时更新器
        needUpdate = true;

   

        //打开站位颜色
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
