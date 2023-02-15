using UnityEngine.UI;
using UnityEngine;

/// <summary>
/// �汾����ս��������ť
/// </summary>
public class ButtonCombat : MonoBehaviour
{
    /// <summary>�ж���Ϸ�Ƿ�ɿ�ʼ</summary>
    public static bool isStart;
    /// <summary>��ʼ��Ϸ��ť</summary>
    private Button start;
    /// <summary>����վλ</summary>
    private GameObject[] situations;
    /// <summary>���н�ɫ</summary>
    private GameObject[] characters;

    private void Start()
    {
        start = GetComponent<Button>();
        situations = GameObject.FindGameObjectsWithTag("situation");
        characters = GameObject.FindGameObjectsWithTag("character");
    }
    private void Update()
    {
        //��ʼ��Ϸ��ť
        if (isStart)
        {
            start.interactable = true;
        }
    }
    /// <summary>
    /// ������վλ��ɫ����
    /// </summary>
    public void ChangeSituationColor()
    {
        foreach(GameObject it in situations)
        {
            it.GetComponent<SpriteRenderer>().material.color = Color.clear;
        }
    }
    /// <summary>
    /// ���н�ɫ������ק
    /// </summary>
    public void RemoveCharacterDrag()
    {
        foreach(GameObject it in characters)
        {
            Destroy(it.GetComponent<CharacterMouseDrag>());
        }

    }
}
