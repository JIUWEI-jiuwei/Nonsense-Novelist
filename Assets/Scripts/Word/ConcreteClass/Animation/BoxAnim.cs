using UnityEngine;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
///<summary>
///�齱�ж���
///</summary>
class BoxAnim : MonoBehaviour
{
    /// <summary>�����ں����ϵĶ���Ƭ������</summary>
    private string anim1;
    private string anim2;
    private string anim3;
    private string anim4;
    private string anim5;
    private string anim6;
    private string anim7;
    /// <summary>������Ϊ��</summary>
    public AnimationActor animActor;
    /// <summary>����Ƭ�����Ƶļ���</summary>
    private List<string> animNames=new List<string>();
    /// <summary>������ɵ�6�������</summary>
    private int[] nums = new int[6];
    /// <summary>����Ԥ����</summary>
    public GameObject wordPrefab;
    /// <summary>������任���</summary>
    public Transform parentTF;
    /// <summary>������任���</summary>
    private Type[] absWords=new Type [6];

    private void Awake()
    {
        animActor = new AnimationActor(GetComponent<Animation>());
        animNames.AddRange(new string[] { anim1, anim2, anim3, anim4, anim5, anim6, anim7 });
        DontDestroyOnLoad(this.gameObject);
    }
    /// <summary>
    /// ��ȡ6����������
    /// </summary>
    /// <returns></returns>
    public void NumberRandom()
    {
        UnityEngine.Random.InitState((int)Time.time);
        nums[0] = UnityEngine.Random.Range(0, animNames.Count);
        for (int i = 1; i < nums.Length;)
        {
            UnityEngine.Random.InitState((int)Time.time);
            nums[i] = UnityEngine.Random.Range(0, animNames.Count);
            Useable(i);
        }
    }
    /// <summary>
    /// �ݹ飨����һ��δ�ظ���Ԫ�أ�
    /// </summary>
    /// <param name="a">��ǰ��Ԫ��</param>
    /// <returns></returns>
    private int Useable(int a)
    {
        if (IsUseable(a))
        {
            a++;
        }
        else
        {
            nums[a] = UnityEngine.Random.Range(0, animNames.Count);
            Useable(a);
        }
        return nums[a];
    }
    /// <summary>
    /// �ж��Ƿ��ظ�
    /// </summary>
    /// <param name="length">��ǰ��Ԫ��</param>
    /// <returns></returns>
    public bool IsUseable(int length)
    {
        for (int j = 0; j < length; j++)
        {
            if (animNames[nums[length]] == animNames[nums[j]])
            {
                return false;
            }
        }
        return true;
    }
    /// <summary>
    /// ������Ӳ��Ŷ���
    /// </summary>
    public void BoxPlay()
    {
        for (int i = 0; i < nums.Length; i++)
        {
            //animActor.Play(animNames[nums[i]]);
        }
    }
    /// <summary>
    /// �������6���µĴ���
    /// </summary>
    public void CreateWord()
    {
        foreach (Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "MainCanvas")
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    GameObject word = Instantiate(wordPrefab, canvas.transform);
                    Type absWord = AllSkills.OnDrawBox();
                    //�����ܴ��棬���ص���һ������
                    absWords[i] = absWord;
                    word.AddComponent(absWord);
                    //��button��text��ʾ��������
                    word.GetComponentInChildren<Image>().sprite = Resources.Load(word.GetComponent<AbstractWords0>().wordName)as Sprite;
                    word.transform.SetParent(parentTF);
                }
            }
        }
    }
}
