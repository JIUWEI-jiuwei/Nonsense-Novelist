using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ɫ�����������Ҫ��Play�������
/// </summary>
class CharaAnim : MonoBehaviour
{
    /// <summary>ʵ�ʶ������</summary>
    public Animator anim;
    /// <summary>��ǰ������</summary>
    public AnimEnum currentAnim = AnimEnum.idle;
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    private string newAnimName;//�¶����ַ���(�����ڡ���
    private string currentAnimName;//��ǰ�����ַ���(�����ڡ���
    /// <summary>
    /// ���Ŷ��������
    /// </summary>
    /// <param name="paramName">�¶���ö��</param>
    public void Play(AnimEnum newAnimEnum)
    {
        newAnimName = Enum.GetName(typeof(AnimEnum),newAnimEnum);
        currentAnimName = Enum.GetName(typeof(AnimEnum), currentAnim);
        anim.SetBool(currentAnimName, false);
        anim.SetBool(newAnimName, true);
        currentAnim = newAnimEnum;
    }
}