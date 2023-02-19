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
    private void Update()
    {
        //四个角色全部上场
        if (GetComponentInChildren<AbstractCharacter>() == null)
        {
            ButtonCombat.isAllCharaUp = true;
        }
    }

}
