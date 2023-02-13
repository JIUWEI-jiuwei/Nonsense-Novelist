using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �������
/// </summary>
abstract public class AbstractWords0 : MonoBehaviour
{
    /// <summary>词性</summary>
    public WordKindEnum wordKind;
    /// <summary>所属书目</summary>
    public BookNameEnum bookName=BookNameEnum.allBooks;
    /// <summary>名称（词汇本体）</summary>
    public string wordName;
    /// <summary>图标/头像</summary>
    public Image pattern;
    /// <summary>简介</summary>
    public string brief;
    /// <summary>详细描述</summary>
    public string description;
    /// <summary>别称（弃用）</summary>
    public List<string> nickname=new List<string>();
    /// <summary>稀有度</summary>
    public int rarity;

    /// <summary>
    /// 使用时文本
    /// </summary>
    virtual public string UseText()
    {
        return null;
    }

}
