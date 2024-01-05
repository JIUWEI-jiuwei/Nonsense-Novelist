using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
/// <summary>
/// 直接AddComponent方式
/// </summary>
public class AbstractBuff : MonoBehaviour
{
    public string buffName;
    public BookNameEnum book=BookNameEnum.allBooks;
    /// <summary>可叠加次数（默认无限）</summary>
    public int upup=999;
    protected AbstractCharacter chara;
    public float maxTime=0.5f;

    protected virtual void Awake()
    {
        chara = GetComponent<AbstractCharacter>();
        int num = 0;
        AbstractBuff[] buffs=GetComponents<AbstractBuff>();
        for (int i = buffs.Length-1; i > -1; i--)
        {//倒序,最早的buff先被删除
            if (buffs[i].buffName == buffName)
            {
                num++;
                if (num > upup)
                {
                    Destroy(buffs[i]);
                }
            }
        }
    }

    virtual public void Update()
    {
        maxTime -= Time.deltaTime;
        if(maxTime<0)
        {
            Destroy(this);
        }
    }

}
