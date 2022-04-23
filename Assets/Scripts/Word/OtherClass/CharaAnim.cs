using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 角色动画组件（不要用Play用这个）
/// </summary>
class CharaAnim : MonoBehaviour
{
    /// <summary>实际动画组件</summary>
    public Animator anim;
    /// <summary>当前动画名</summary>
    public AnimEnum currentAnim = AnimEnum.idle;
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    private string newAnimName;//新动画字符串(仅用于↓）
    private string currentAnimName;//当前动画字符串(仅用于↓）
    /// <summary>
    /// 播放动画用这个
    /// </summary>
    /// <param name="paramName">新动画枚举</param>
    public void Play(AnimEnum newAnimEnum)
    {
        newAnimName = Enum.GetName(typeof(AnimEnum),newAnimEnum);
        currentAnimName = Enum.GetName(typeof(AnimEnum), currentAnim);
        anim.SetBool(currentAnimName, false);
        anim.SetBool(newAnimName, true);
        currentAnim = newAnimEnum;
    }
}