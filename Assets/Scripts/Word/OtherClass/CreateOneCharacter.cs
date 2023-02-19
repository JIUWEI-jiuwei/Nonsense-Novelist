using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 挂在父物体(charaPos)上，随机生成4个角色子物体，分别位于四个空物体下
/// </summary>
public class CreateOneCharacter : MonoBehaviour
{
    public GameObject[] charaPrefabs;
    private List<int> array = new List<int>();

    private void Awake()
    {

        for (int i = 0; i < 4; i++)
        {
            int number = UnityEngine.Random.Range(0, charaPrefabs.Length);
            while (array.Contains(number))
            {
                number = UnityEngine.Random.Range(0, charaPrefabs.Length);
            }
            array.Add(number);

            GameObject chara = Instantiate(charaPrefabs[number]);
            chara.transform.SetParent(this.transform.GetChild(i));
            chara.transform.position = new Vector3(transform.GetChild(i).position.x, transform.GetChild(i).position.y + CharacterMouseDrag.offsetY, transform.GetChild(i).position.z);

        }
    }
    private void Start()
    {
        //发射器禁用
        shooter.GetComponent<Shoot>().enabled = false;
        shooter.GetComponent<RollControler>().enabled = false;

    }
    private void Update()
    {
        //四个角色全部上场
        if (GetComponentInChildren<AbstractCharacter>() == null)
        {
            isAllCharaUp = true;
        }
    }
    /// <summary>判断是否所有角色就位</summary>
    public static bool isAllCharaUp;
    /// <summary>判断角色是否站位两侧</summary>
    public static bool isTwoSides;
    /// <summary>发射器(手动)</summary>
    public GameObject shooter;

   

    /// <summary>
    /// 开始战斗
    /// </summary>
    public void CombatStart()
    {
        if (CharacterManager.instance.charas.Length > 0)
        {
            for (int i = 0; i < CharacterManager.instance.charas.Length; i++)
            {
                for (int j = i + 1; j < CharacterManager.instance.charas.Length; j++)
                {
                    if (CharacterManager.instance.charas[i].camp != CharacterManager.instance.charas[j].camp)
                    {
                        isTwoSides = true;
                    }
                }
            }
        }
        // 两方至少要有一名角色
        if (isAllCharaUp && !isTwoSides)
        {
            print("两方至少要有一名角色");
        }
        //仍有角色未就位
        else if (!isAllCharaUp)
        {
            print("仍有角色未就位");
        }
        else if (isTwoSides && isAllCharaUp)//成功开始
        {

            // 将所有站位颜色隐藏
            foreach (Situation it in Situation.allSituation)
            {
                it.GetComponent<SpriteRenderer>().material.color = Color.clear;
            }
            // 所有角色不可拖拽
            foreach (AbstractCharacter it in CharacterManager.instance.charas)
            {
                it.GetComponent<AI.MyState0>().enabled = true;
                it.GetComponent<AbstractCharacter>().enabled = true;
                Destroy(it.GetComponent<CharacterMouseDrag>());
            }
            //发射器启用
            shooter.GetComponent<Shoot>().enabled = true;
            shooter.GetComponent<RollControler>().enabled = true;

        }

    }

}
