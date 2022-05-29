using UnityEngine.UI;
using UnityEngine;

///<summary>
///Ѫ��ԲȦ����
///</summary>
class HealthCircleBar : MonoBehaviour
{
    /// <summary>ս��������������</summary>
    private AbstractCharacter linDaiYu;
    /// <summary>ս�������ļֱ���</summary>
    private AbstractCharacter jiaBaoYu;
    /// <summary>ս�������ļ�ĸ</summary>
    private AbstractCharacter jiaMu;
    /// <summary>ս��������������</summary>
    private AbstractCharacter liuLaoLao;
    /// <summary>ս��������������</summary>
    private AbstractCharacter wangXiFeng;

    private void Start()
    {
        linDaiYu = GameObject.Find("LinDaiYu").GetComponent<AbstractCharacter>();
        //jiaBaoYu = GameObject.Find("JiaBaoYu").GetComponent<AbstractCharacter>();
        //jiaMu = GameObject.Find("JiaMu").GetComponent<AbstractCharacter>();
        //liuLaoLao = GameObject.Find("LiuLaoLao").GetComponent<AbstractCharacter>();
        //wangXiFeng = GameObject.Find("WangXiFeng").GetComponent<AbstractCharacter>();
    }
    private void FixedUpdate()
    {
        if (this.transform.GetChild(0).gameObject.name== "LinDaiYu_Circle"&& linDaiYu != null)
        {
            float hpPercent=(float)linDaiYu.hp / linDaiYu.maxHP;
            this.GetComponent<Image>().fillAmount = hpPercent;
        }
        if (this.transform.GetChild(0).gameObject.name== "JiaBaoYu_Circle" && jiaBaoYu != null)
        {
            float hpPercent=(float)jiaBaoYu.hp / jiaBaoYu.maxHP;
            this.GetComponent<Image>().fillAmount = hpPercent;
        }
        if (this.transform.GetChild(0).gameObject.name== "JiaMu_Circle" && jiaMu != null)
        {
            float hpPercent=(float)jiaMu.hp / jiaMu.maxHP;
            this.GetComponent<Image>().fillAmount = hpPercent;
        }
        if (this.transform.GetChild(0).gameObject.name== "LiuLaoLao_Circle" && liuLaoLao != null)
        {
            float hpPercent=(float)liuLaoLao.hp / liuLaoLao.maxHP;
            this.GetComponent<Image>().fillAmount = hpPercent;
        }
        /*if (this.transform.GetChild(0).gameObject.name== "WangXiFeng_Circle" && wangXiFeng != null)
        {
            float hpPercent=(float)wangXiFeng.hp / wangXiFeng.maxHP;
            this.GetComponent<Image>().fillAmount = hpPercent;
        }*/

    }
}
