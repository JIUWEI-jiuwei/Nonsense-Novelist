using UnityEngine;
using UnityEngine.SceneManagement;
///<summary>
///���س�������
///</summary>
class LoadingTest : MonoBehaviour
{
    public string sceneName;
    public void NextLayer()
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
