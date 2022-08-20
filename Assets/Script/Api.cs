using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Api : MonoBehaviour
{
    // Start is called before the first frame update
   
    public RawImage thisRenderer;
    public AudioSource Audio;
    AudioClip clip;
    string url;
    bool AudioGet;

    // automatically called when game started
    void Start()
    {
        url = "https://test.iamdave.ai/static/uploads/dave_expo/conversations/exhibit_aldo/1ef107d7-c3f6-3649-9cfb-b5523411cd70/voice.wav"; 
        StartCoroutine(LoadFromLikeCoroutine());
        AudioGet = true;
    }

    // this section will be run independently
    private IEnumerator LoadFromLikeCoroutine()
    {
        Debug.Log("Loading ....");
        WWW wwwLoader = new WWW(url);   // create WWW object pointing to the url
        yield return wwwLoader;         // start loading whatever in that url ( delay happens here )

        Debug.Log("Loaded");
        
        if (AudioGet)
                {
            AudioGet = false;

            clip = wwwLoader.GetAudioClip();
        Audio.clip = clip;
        Audio.Play();

         }
        else
        {
            thisRenderer.texture = wwwLoader.texture;  // set loaded image
        }





    }

    void imageChange() {
       
    }




    public void CButto(int i)
    
    {
        if (i == 1)
        {
             url = "http://d3chc9d4ocbi4o.cloudfront.net/conversations/aldo/MT1.jpg";
            StartCoroutine(LoadFromLikeCoroutine());
        }
        if (i == 2)
        {
             url = "http://d3chc9d4ocbi4o.cloudfront.net/conversations/aldo/MT2.jpg";
            StartCoroutine(LoadFromLikeCoroutine());
        }
        if (i == 3)
        {
             url = "http://d3chc9d4ocbi4o.cloudfront.net/conversations/aldo/MT3.jpg";
            StartCoroutine(LoadFromLikeCoroutine());
        }
    }
}
