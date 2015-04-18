using UnityEngine;
using System.Collections;

public class Screen : MonoBehaviour {
    public bool fade = false;
    public int max = 400;
    public int fill = 0, tired = 400;
    public Material mat1, mat2, mat3, mat4, mat5, mat6, mat0 ;
    public Transform follower;
    void Start()
    {
        tired = max;
        gameObject.GetComponent<Renderer>().material = mat0;
    }

    void Update()
    {
        //if()
        if (Input.GetButtonDown("Fire1")&&fade==false&&tired < 0.60*max)
        {
            Fadein(mat1);
            fade = true;
        }
       
    }
    
    void FixedUpdate()
    {
        if(fade)
        {
            tired = max;
            fill++;
            if (fill == 3)
            {
                Fadein(mat2);
                follower.SendMessage("Stop"); 
            }
            if(fill == 6)
            {
                Fadein(mat3);
            }
            if (fill == 9)
            {
                Fadein(mat4);
            }
            if (fill == 12)
            {
                Fadein(mat5);
            }
            else if(fill == 15)
            {
                Fadein(mat6);  
            }
            if (fill == 65)
            {
                Fadein(mat5);
                
            }
            else if(fill == 68)
            {
                Fadein(mat4);
            }
            if (fill == 71)
            {
                Fadein(mat3);
            }
            if (fill == 74)
            {
                Fadein(mat2);
            }
            else if(fill == 77)
            {
                follower.SendMessage("Stop");
                fade = false;
                Fadein(mat0); //StartCoroutine(FadeTo(0.0f, 1.0f));
                fill = 0;
            }
        }
        else
        {
            tired--;
            if (tired == 0)
            {
                fade = true;
            }
        }
    }

    void Fadein(Material mat)
    {
        gameObject.GetComponent<Renderer>().material = mat;
    }

    /*IEnumerator FadeTo(float aValue, float aTime)
    {
        float alpha = gameObject.GetComponent<Renderer>().material.color.a;
        gameObject.GetComponent<Renderer>().material.color = newColor;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            newColor = new Color(0, 0, 0, Mathf.Lerp(alpha, aValue, t));
            gameObject.GetComponent<Renderer>().material.color = newColor;
            yield return null;
        }
    }*/
}
