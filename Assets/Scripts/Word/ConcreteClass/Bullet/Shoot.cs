using UnityEngine.UI;
using UnityEngine;
using System;

/// <summary>
/// 发射词弹
/// </summary>
public class Shoot : MonoBehaviour
{
    /// <summary>发射位置</summary>
    public Transform gang;
    /// <summary>词条</summary>
    public GameObject bullet;
    /// <summary>发射后词条的父物体</summary>
    public Transform bulletRoot;
    /// <summary>当前的力</summary>
    [SerializeField]
    private float crtForce = 0;
    /// <summary>最小力</summary>
    private float minForce = 0;
    /// <summary>最大力</summary>
    private float maxForce = 200;
    /// <summary>蓄力速度</summary>
    public float forceSpeed = 80;
    /// <summary>有无发射</summary>
    private bool fired = false;
    /// <summary>蓄力Slider</summary>
    public Slider aimSlider;
    /// <summary>存储WordCollisionShoot的词条属性</summary>
    public static AbstractWord0 abs;
    /// <summary>手动，词条信息板 </summary>
    public WordInformation information;

    private void Update()
    {
        if (ButtonCombat. isTwoSides && ButtonCombat.isAllCharaUp)
        {
            aimSlider.value = 0; // 重置slider的值

            if (crtForce >= maxForce && !fired)// 蓄力到最大值
            {
                crtForce = maxForce;
            }

            if (Input.GetButtonDown("Fire1"))
            {
                crtForce = minForce; // 重置力的大小
                fired = false; // 设置开火状态为未开火
            }
            else if (Input.GetButton("Fire1") && !fired)// 一直按着
            {
                crtForce += forceSpeed * Time.deltaTime; // 蓄力
                aimSlider.value = crtForce / maxForce; // 更新slider的值
            }
            else if (Input.GetButtonUp("Fire1") && !fired)
            {
                //有请九尾+++++++++++++++++++++++++
                CreateWordBullet(new DuXian());//因为没有实际用处所以暂时用new，可以随便改
            }

        }
    }
    /// <summary>
    /// 产生词条实体
    /// </summary>
    void CreateWordBullet(AbstractWord0 word)
    {
        fired = true; // 设置开火状态为已开火

        GameObject go = Instantiate(bullet);

        //预制体相关
        go.transform.SetParent(gang);
        go.transform.localPosition = Vector3.zero;
        go.transform.localScale = Vector3.one;
        go.transform.localEulerAngles = Vector3.zero;
        go.transform.SetParent(bulletRoot);

        //给小球增加词条属性
        //GameObject.Find("WordCollisionShoot").GetComponent<WordCollisionShoot>().absWord= go.AddComponent(AllSkills.CreateSkillWord()) as AbstractWords0;
        GameObject.Find("WordCollisionShoot").GetComponent<WordCollisionShoot>().absWord = go.gameObject.AddComponent(word.GetType()) as AbstractWord0;
        //GameObject.Find("WordCollisionShoot").GetComponent<WordCollisionShoot>().absWord = go.gameObject.AddComponent<LengXiangPill>();
        //GameObject.Find("WordCollisionShoot").GetComponent<WordCollisionShoot>().absWord = go.gameObject.AddComponent<XinShenJiDang>();
        //GameObject.Find("WordCollisionShoot").GetComponent<WordCollisionShoot>().absWord = go.gameObject.AddComponent<YouAnQuanGan>();

        abs = GameObject.Find("WordCollisionShoot").GetComponent<WordCollisionShoot>().absWord;
        //增加词条图像

        //给词条添加一个初始的力
        go.GetComponent<Rigidbody2D>().AddForce(go.transform.up * crtForce);

        //下一个词条？++++++++++++++++++++
        information.ChangeInformation(word);//等你写好了改这个实参++++++++++++++++++++++++++++++
    }
}
