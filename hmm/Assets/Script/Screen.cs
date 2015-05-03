using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Screen : MonoBehaviour {
    public bool fade = false;
    public bool death = false, n_death = true;
    public int max = 400;
    public int fill = 0, tired = 400;
    public Material mat1, mat2, mat3, mat4, mat5, mat6, mat0 ;
    public GameObject follower;
    public GameObject[] enemy;
    private List<GameObject> list = new List<GameObject>();
    void Start()
    {
        transform.tag = "Screen";
        tired = max;
        gameObject.GetComponent<Renderer>().material = mat6;
        death = true;
        n_death = true;
        fill = 0;
    }

    void Update()
    {
        //if()
        if (Input.GetButtonDown("Fire1"))
        {
            Start_Fade();
        }
       
    }
    
    void Start_Fade()
    {
        if (fade == false && tired < 0.65 * max)
        {
            Fadein(mat1);
            fade = true;
        }
    }
    void FixedUpdate()
    {
        if(death&&!n_death)
        {
            //fill = 0;
            fade = false;
            tired = max;
            fill++;
            if (fill == 3)
            {
                Fadein(mat2);
                SendStopMessage(); 
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
            else if (fill == 15)
            {
                Fadein(mat6);
                Time.timeScale = 0;
                //fill = 0;
            }
            
        }
        else if(death&&n_death)
        {
            
            fill++;
            if (fill == 65)
            {
                Fadein(mat5);

            }
            else if (fill == 68)
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
            else if (fill == 77)
            {
                SendGoMessage();
                fade = false;
                Fadein(mat0); //StartCoroutine(FadeTo(0.0f, 1.0f));
                fill = 0;
                death = false;
            }
        }
        if(fade && !death)
        {
            tired = max;
            fill++;
            if (fill == 3)
            {
                Fadein(mat2);
                SendStopMessage(); 
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
                SendGoMessage();
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

    void SendStopMessage()
    {
        CheckList();
        foreach (GameObject obj in list)
        {
            obj.SendMessage("Stop");
        }
    }

    void CheckList()
    {
        int i;
        //follower = GameObject.FindGameObjectWithTag("Follower");
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        //Debug.Log(follower);
        list = new List<GameObject>();
        //list.Add(follower);
        if (enemy.Length > 0)
        {
            for (i = 0; i < enemy.Length; i++)
                list.Add(enemy[i]);
        }
        enemy = GameObject.FindGameObjectsWithTag("Arrow");
        if (enemy.Length > 0)
        {
            for (i = 0; i < enemy.Length; i++)
                list.Add(enemy[i]);
        }
        enemy = GameObject.FindGameObjectsWithTag("Move");
        if (enemy.Length > 0)
        {
            for (i = 0; i < enemy.Length; i++)
                list.Add(enemy[i]);
        }
        enemy = GameObject.FindGameObjectsWithTag("Dark");
        if (enemy.Length > 0)
        {
            for (i = 0; i < enemy.Length; i++)
                list.Add(enemy[i]);
        }
        //Debug.Log(list.Count);
    }

    void SendGoMessage()
    {
        CheckList();
        foreach (GameObject obj in list)
        {
           // Debug.Log(obj);
            obj.SendMessage("Go");
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

    void Death()
    {
        
        death = true;
        n_death = false;
    }
}
