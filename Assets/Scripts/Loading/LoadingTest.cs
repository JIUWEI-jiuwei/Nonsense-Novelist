using UnityEngine;
using UnityEngine.SceneManagement;
///<summary>
///º”‘ÿ≥°æ∞≤‚ ‘
///</summary>
class LoadingTest : MonoBehaviour
{
    public string sceneName;
    public void NextLayer()
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
