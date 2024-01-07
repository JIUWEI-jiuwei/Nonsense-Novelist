using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 伤害治疗飘字
/// </summary>
public class FloatWord : MonoBehaviour
{
    /// <summary>(手动）</summary>
    public Text[] normalTexts;
    /// <summary>(手动）</summary>
    public Text[] bossTexts;

    private Color purple = new Color(153, 0, 255);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <param name="boss">是否是boss</param>
    /// <param name="damage">是否是伤害</param>
    /// <param name="direct">是否是直接的</param>
    internal void InitPopup(float value, bool boss,FloatWordColor color,bool direct)
    {
        string str =((int)value).ToString();
        Text text=null;
        if (boss)
        {
            if (value >= 20)
            {
                text = normalTexts[2];
            }
            else if (value >= 10)
            {
                text = normalTexts[1];
            }
            else if (direct || (!direct && value >= 5))
            {
                text = normalTexts[0];
            }
        }
        else//非boss
        {
            if (value >= 20)
            {
                text = bossTexts[2];
            }
            else if (value >= 10)
            {
                text = bossTexts[1];
            }
            else if (direct || (!direct && value >= 5))
            {
                text = bossTexts[0];
            }
        }
        if (text == null)
        {
            Destroy(this.gameObject);//不漂字
            return;
        }
        text.text = str;
        switch (color)
        {
            case FloatWordColor.physics:
                {
                    text.color = Color.white;
                    break;
                }
            case FloatWordColor.psychic:
                {
                    text.color = purple;
                    break;
                }
            case FloatWordColor.heal:
                {
                    text.color = Color.green;
                    break;
                }
        }
        text.enabled= true;

        float time = 1;
        float height = 2;//弹射高度
        //(什么移动，终点在哪，花多长时间)
        //.setEaseOutBack()设置曲线（），使其往返.setDestroyOnComplete(true)设置完成后销毁
        LeanTween.moveY(this.gameObject, this.transform.position.y + height, time).setDestroyOnComplete(true);
    }
}

public enum FloatWordColor
{
    /// <summary>物理</summary>
    physics=0,
    /// <summary>精神</summary>
    psychic=1,
    /// <summary>治疗</summary>
    heal=2,
}
