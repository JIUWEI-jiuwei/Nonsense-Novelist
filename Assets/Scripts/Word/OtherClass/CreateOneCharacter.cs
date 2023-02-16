using System;
using UnityEngine;

/// <summary>
/// ���ڸ�����(charaPos)�ϣ��������4����ɫ�����壬�ֱ�λ���ĸ���������
/// </summary>
public class CreateOneCharacter : MonoBehaviour
{
    public GameObject[] charaPrefabs;
    private void Awake()
    {
        for(int i = 0; i < 4; i++)
        {
            GameObject chara = Instantiate(CreateCharacter());
            chara.transform.SetParent(this.transform.GetChild(i));
            chara.transform.position = new Vector3(transform.GetChild(i).position.x, transform.GetChild(i).position.y + CharacterMouseDrag.offsetY, transform.GetChild(i).position.z);

        }
    }
    private void Update()
    {
        //�ĸ���ɫȫ���ϳ�
        if (GetComponentInChildren<AbstractCharacter>() == null)
        {
            ButtonCombat.isAllCharaUp = true;
        }
    }

    /// <summary>
    /// �������һ����ɫԤ����
    /// </summary>
    /// <returns></returns>
    public GameObject CreateCharacter()
    {
        int number = UnityEngine.Random.Range(0, charaPrefabs.Length);
        return charaPrefabs[number];
    }
}
