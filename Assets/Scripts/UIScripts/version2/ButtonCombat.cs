using UnityEngine.UI;
using UnityEngine;

/// <summary>
/// 版本二：战斗场景按钮
/// </summary>
public class ButtonCombat : MonoBehaviour
{
    /// <summary>判断是否所有角色就位</summary>
    public static bool isAllCharaUp;
    /// <summary>判断角色是否站位两侧</summary>
    public static bool isTwoSides;
    /// <summary>开始游戏按钮</summary>
    private Button start;
    /// <summary>所有站位</summary>
    private GameObject[] situations;
    /// <summary>所有角色</summary>
    private GameObject[] characters;
    /// <summary>发射器</summary>
    public GameObject shooter;

    private void Start()
    {
        start = GetComponent<Button>();
        situations = GameObject.FindGameObjectsWithTag("situation");
        characters = GameObject.FindGameObjectsWithTag("character");
        //发射器禁用
        shooter.GetComponent<Shoot>().enabled = false;
        shooter.GetComponent<RollControler>().enabled = false;

    }

    /// <summary>
    /// 将所有站位颜色隐藏
    /// </summary>
    public void ChangeSituationColor()
    {
        if (isTwoSides&&isAllCharaUp)
        {
            // 将所有站位颜色隐藏
            foreach (GameObject it in situations)
            {
                it.GetComponent<SpriteRenderer>().material.color = Color.clear;
            }
            // 所有角色不可拖拽
            foreach (GameObject it in characters)
            {
                Destroy(it.GetComponent<CharacterMouseDrag>());
            }
            //发射器启用
            shooter.GetComponent<Shoot>().enabled = true;
            shooter.GetComponent<RollControler>().enabled = true;

        }
        
    }


    /// <summary>
    /// 两方至少要有一名角色
    /// </summary>
    public void TwoSides()
    {
        
        if (CharacterManager. charas.Length > 0)
        {
            for (int i = 0; i < CharacterManager.charas.Length; i++)
            {
                for (int j = i + 1; j < CharacterManager.charas.Length; j++)
                {
                    if (CharacterManager.charas[i].camp != CharacterManager.charas[j].camp)
                    {
                        isTwoSides = true;
                    }
                }
            }
        }
        if (isAllCharaUp && !isTwoSides)
        {
            print("两方至少要有一名角色");
        }
    }
    /// <summary>
    /// 仍有角色未就位
    /// </summary>
    public void AllCharaUp()
    {
        if (!isAllCharaUp)
        {
            print("仍有角色未就位");
        }
    }
}
