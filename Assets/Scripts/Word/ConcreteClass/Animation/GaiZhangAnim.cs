
using UnityEngine;
using UnityEngine.SceneManagement;

///<summary>
///���¶���
///</summary>
class GaiZhangAnim : MonoBehaviour
{
    /// <summary>���µĶ���</summary>
    public Animator gaizhang;
    /// <summary>ѡ�صĶ���</summary>
    public Animator level;
    /// <summary>�Ƿ��һ�ε����ť</summary>
    private bool isFirst = false;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Combat")
        {
            gaizhang.SetBool("start", true);
        }
    }

    public void GZ1_2()
    {
        if (isFirst == false)
        {
            gaizhang.SetBool("GZ1_2", true);
        }
    }
    public void Level1_2()
    {
        if(isFirst == false)
        {
            level.Play("level1_2");
            isFirst = true;
        }
    }
}
