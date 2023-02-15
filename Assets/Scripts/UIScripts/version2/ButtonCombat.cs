using UnityEngine.UI;
using UnityEngine;

/// <summary>
/// 版本二：战斗场景按钮
/// </summary>
public class ButtonCombat : MonoBehaviour
{
    /// <summary>判断游戏是否可开始</summary>
    public static bool isStart;
    /// <summary>开始游戏按钮</summary>
    private Button start;
    /// <summary>所有站位</summary>
    private GameObject[] situations;
    /// <summary>所有角色</summary>
    private GameObject[] characters;

    private void Start()
    {
        start = GetComponent<Button>();
        situations = GameObject.FindGameObjectsWithTag("situation");
        characters = GameObject.FindGameObjectsWithTag("character");
    }
    private void Update()
    {
        //开始游戏按钮
        if (isStart)
        {
            start.interactable = true;
        }
    }
    /// <summary>
    /// 将所有站位颜色隐藏
    /// </summary>
    public void ChangeSituationColor()
    {
        foreach(GameObject it in situations)
        {
            it.GetComponent<SpriteRenderer>().material.color = Color.clear;
        }
    }
    /// <summary>
    /// 所有角色不可拖拽
    /// </summary>
    public void RemoveCharacterDrag()
    {
        foreach(GameObject it in characters)
        {
            Destroy(it.GetComponent<CharacterMouseDrag>());
        }

    }
}
