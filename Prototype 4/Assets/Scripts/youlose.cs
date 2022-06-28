using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class youlose : MonoBehaviour
{
    public AudioSource sound;

    void Start()
    {
        StartCoroutine(Stop());
    }
    
    IEnumerator Stop()
    {
        sound.Play();
        yield return new WaitUntil(() => sound.isPlaying == false);

        SceneManager.LoadScene(sceneName: "Prototype4Scene");
    }

    
}
