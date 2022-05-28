
using UnityEngine;
using UnityEngine.SceneManagement;

///<summary>
///盖章动画
///</summary>
class GaiZhangAnim : MonoBehaviour
{
    /// <summary>盖章的动画</summary>
    public Animator gaizhang;
    /// <summary>选关的动画</summary>
    public Animator level;
    /// <summary>是否第一次点击按钮</summary>
    private bool isGZFirst = false;
    /// <summary>是否第一次点击按钮</summary>
    private bool isLevelFirst = false;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Combat")
        {
            gaizhang.SetBool("start", true);
        }
    }

    public void GZ1_2()
    {
        if (isGZFirst == false)
        {
            gaizhang.SetBool("GZ1_2", true);
            isGZFirst = true;
        }
    }
    public void Level1_2()
    {
        if(isLevelFirst == false)
        {
            level.SetBool("level1_2", true);
            isLevelFirst = true;
        }
    }
}
