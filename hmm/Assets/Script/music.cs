using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {
    public AudioSource _AudioSource1;
    public AudioSource _AudioSource2;
    public AudioSource _AudioSource3;
    public AudioSource _AudioSource4;
    bool lower = false;
    bool upper = true;
    int fill = 1;
    void Start()
    {
        fill = 1;
        Object.DontDestroyOnLoad(gameObject);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        _AudioSource1.Pause();
        _AudioSource1.volume = fill * 0.00025f;
        lower = false;
        upper = true;
    }


    void Update()
    {

        if(lower)
        {
            if (_AudioSource1.isPlaying)
            {
                _AudioSource1.volume = fill * 0.00025f;
                fill--;
            }
            if(_AudioSource2.isPlaying)
            {
                _AudioSource2.volume = fill * 0.00025f;
                _AudioSource3.volume = fill * 0.00025f;
                fill--;
            }
        }
        if(fill == 0)
        {
            if (_AudioSource1.isPlaying)
            {
                _AudioSource2.volume = fill * 0.00025f;
                _AudioSource3.volume = fill * 0.00025f;
                Next_song();
                upper = true;
                lower = false;
                fill++;
            }
            else if (_AudioSource2.isPlaying)
            {
                _AudioSource2.volume = fill * 0.00025f;
                _AudioSource3.volume = fill * 0.00025f;
                Next_song();
                upper = true;
                lower = false;
                fill++;
            }
        }

        if(upper)
        {   
            if(_AudioSource1.isPlaying)
            {
                _AudioSource1.volume = fill * 0.00025f;
                fill++;
            }
            if (_AudioSource2.isPlaying)
            {
                _AudioSource2.volume = fill * 0.00025f;
                _AudioSource3.volume = fill * 0.00025f;
                fill++;
            }
            if (_AudioSource4.isPlaying)
            {
                _AudioSource4.volume = fill * 0.00025f;
                fill++;
            }
            
        }
        if (fill == 1000)
        {
            upper = false;
        }
    }
    void Lower()
    {
        
        lower = true;
    }

    void Play()
    {
        _AudioSource1.Play();
    }
    void Next_song()
    {
        Debug.Log("QUE?");
        if (_AudioSource1.isPlaying)
        {
            _AudioSource1.Stop();
            _AudioSource2.Play();
            _AudioSource3.Play();
            Debug.Log("What?");
        }
        else if (_AudioSource2.isPlaying)
        {
            Debug.Log("Why?");
            _AudioSource2.Stop();
            _AudioSource3.Stop();
            _AudioSource4.Play();
        }
       
    }
 
}
