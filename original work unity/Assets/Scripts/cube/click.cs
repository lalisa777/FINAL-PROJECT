using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    [SerializeField]private string glassTag = "glassTag";
    private int num = 3;
    void Update()
    {
         if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 1000.0f))
            {
                if(hit.transform)
                {
                        var click = hit.transform;
                        if(click.CompareTag(glassTag))
                        {
                        print(hit.transform.gameObject);
                        float detect = hit.transform.GetComponent<Renderer>().material.GetFloat("IOR");
                        
                        if(num > 0)
                        {
                            hit.transform.GetComponent<Renderer>().material.SetFloat("IOR",detect-10);
                            num -= 1;
                            //RenderSettings.ambientLight += new Color(0.1f, 0.1f, 0.1f);
                        }
                        else
                        {
                            Destroy (GameObject.FindWithTag("dis"));
                            Destroy (GameObject.FindWithTag("glassTag"));
                            hearfloating.perRadian = 0.1f;
                          
                            //RenderSettings.ambientLight = Color.Lerp(new Color(), new Color(), Mathf.PingPong(Time.time, 1));
                        }
                        }

                    
                }
            }
        } 
    }
}
