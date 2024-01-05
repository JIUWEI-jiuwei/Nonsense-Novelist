using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 站位
/// </summary>
public class Situation : MonoBehaviour
{
    /// <summary>几号位（手动输入）</summary>
    public float number;//1-10,boss为5.5（这样计算距离时得到0）

    /// <summary>所有站位</summary>
    static public Situation[] allSituation;

    public void Awake()
    {
        CaculateAllSituation();
    }

    /// <summary>计算距离</summary>
    static public int Distance(Situation a, Situation b)
    {
        return (int)Mathf.Abs(a.number - b.number);
    }

    /// <summary>
    /// 重新计算所有站位
    /// AllCharacter的子物体是所有站位，每个站位的子物体是角色
    /// </summary>
    static public Situation[] CaculateAllSituation()
    {
        if (GameObject.Find("AllCharacter") != null)
        {
            allSituation = GameObject.Find("AllCharacter").GetComponentsInChildren<Situation>();
            return allSituation;
        }
        return null;
    }
}
