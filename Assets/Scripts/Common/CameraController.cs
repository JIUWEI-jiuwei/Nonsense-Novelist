using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Camera camera;

    private float count;
    private float nowSize;
    private void Awake()
    {
        camera = GetComponent<Camera>();
        
    }
<<<<<<< HEAD
    bool pausing = false;
=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
    public void SetCameraSizeTo(float _size)
    {

        print("SetCameraSizeTo");
        camera = GetComponent<Camera>();
        nowSize = _size;
<<<<<<< HEAD

        if (Time.timeScale == 0)
        {
            pausing = true;
        }


=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        if (Mathf.Abs(_size- camera.orthographicSize ) > 0.001f)
        {
            StopAllCoroutines();
            count =_size -camera.orthographicSize  ;
            StartCoroutine(ChangeCameraSize());
        }
    }
    IEnumerator ChangeCameraSize()
    {
<<<<<<< HEAD
      if(pausing)Time.timeScale = 1f;
=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        print("ChangeCameraSize");
        while (Mathf.Abs(camera.orthographicSize - nowSize) > 0.001f)
        { 
            yield return new WaitForFixedUpdate();
<<<<<<< HEAD
    
            camera.orthographicSize += (count) * 0.02f; 
            //count = camera.orthographicSize - nowSize;
        }
        if (pausing)
        {
            Time.timeScale = 0f;
            pausing = false;
        }
      
=======
            print("while");
            camera.orthographicSize += (count) * 0.02f; 
            //count = camera.orthographicSize - nowSize;
        }
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
    }
}
