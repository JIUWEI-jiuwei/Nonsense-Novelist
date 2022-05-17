using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �������
/// </summary>
abstract class AbstractWords0 : MonoBehaviour
{
    /// <summary>�����飨ȫ�鼮Ϊ0�� </summary>
    public BookNameEnum bookName;
    /// <summary>�ʵ�����(���壩</summary>
    public string wordName;
    /// <summary>ͼ��/ͷ�� </summary>
    public Image pattern;
    /// <summary>�������������У�</summary>
    public string brief;
    /// <summary>��ϸ����</summary>
    public string description;
    /// <summary>��ƣ������ı�ʱ���ʹ�ã�</summary>
    public List<string> nickname=new List<string>();
    /// <summary>����</summary>
    public WordSortEnum wordSort;
}
