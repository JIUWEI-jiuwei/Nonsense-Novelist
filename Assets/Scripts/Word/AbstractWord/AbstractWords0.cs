using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 抽象词类
/// </summary>
abstract class AbstractWords0 : MonoBehaviour
{
    /// <summary>所属书（全书籍为0） </summary>
    public BookNameEnum bookName;
    /// <summary>词的名字(本体）</summary>
    public string wordName;
    /// <summary>图标/头像 </summary>
    public Image pattern;
    /// <summary>简短描述（如果有）</summary>
    public string brief;
    /// <summary>详细描述</summary>
    public string description;
    /// <summary>别称（导出文本时替代使用）</summary>
    public List<string> nickname=new List<string>();
    /// <summary>词性</summary>
    public WordSortEnum wordSort;
}
