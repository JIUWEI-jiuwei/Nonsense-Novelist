using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ɫ�����������Ҫ��Play�������
/// </summary>
public class CharaAnim : MonoBehaviour
{
    /// <summary>ʵ�ʶ������</summary>
    public Animator anim;
    /// <summary>��ǰ������</summary>
    public string currentAnim = "idle";
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    private string newAnimName;//�¶����ַ���(�����ڡ���
    /// <summary>
    /// ���Ŷ��������
    /// </summary>
    /// <param name="paramName">�¶���ö��</param>
    public void Play(AnimEnum newAnimEnum)
    {
        newAnimName = Enum.GetName(typeof(AnimEnum),newAnimEnum);
        anim.SetBool(currentAnim, false);
        anim.SetBool(newAnimName, true);
        currentAnim = newAnimName;
    }
}