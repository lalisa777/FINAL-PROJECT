using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectclick : MonoBehaviour
{
   public float cubeSize = 0.2f;
   public int cubesInRow = 5;

   public float upForce = 1f;
   public float sideForce =.1f;

   public GameObject voxel;

   private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 1000.0f))
            {
                if(hit.transform)
                {
                    
                    Rigidbody rd;

                    if(rd = hit.transform.GetComponent<Rigidbody>())
                    {
                        if(rd.name != "Cube")
                        {
                        //PrintName(hit.transform.gameObject);
                        float detect = hit.transform.GetComponent<Renderer>().material.GetFloat("_Speed");
                        float shape = hit.transform.GetComponent<Renderer>().material.GetFloat("_Amount");
                        float a = hit.transform.GetComponent<Renderer>().material.GetFloat("_Amp");
                        if(detect < 50)
                        {
                            hit.transform.GetComponent<Renderer>().material.SetFloat("_Speed",detect+20);
                            hit.transform.GetComponent<Renderer>().material.SetFloat("_Amount",shape+3);
                            hit.transform.GetComponent<Renderer>().material.SetFloat("_Amp",shape+30);
                        }
                        else
                        {
                            explode(rd);
                            Quaternion randomRotation = Quaternion.Euler(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f));
                            Instantiate(voxel,new Vector3 (Random.Range(-12, 12),Random.Range(-2, 20),Random.Range(-8,-6)),randomRotation);

                        }
                        }

                    }
                }
            }
        }   
    
    }   
              
            
        
    public void explode(Rigidbody item)
    {
        item.gameObject.SetActive(false);
        Vector3 p = item.gameObject.transform.position;
        
        for(int x = 0; x < cubesInRow; x++)
        {
            for(int y = 0; y < cubesInRow; y++)
            {
                for(int z = 0; z < cubesInRow; z++)
                {
                    createPiece(x,y,z,p);
                }
            }
        }
        
    }

    void createPiece(int x, int y, int z, Vector3 p)
    {
        GameObject piece;
        piece = GameObject.CreatePrimitive(PrimitiveType.Cube);

        piece.transform.position = p + new Vector3(cubeSize * x, cubeSize * y, cubeSize * z);
        piece.transform.localScale = new Vector3(cubeSize,cubeSize,cubeSize);

        piece.AddComponent<Rigidbody>();
        piece.GetComponent<Rigidbody>().mass = 0.2f;

        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce / 2f, upForce);
        float zForce = Random.Range(-sideForce, sideForce);

        Vector3 force = new Vector3(xForce,yForce,zForce);

        piece.GetComponent<Rigidbody>().velocity = force;
    }
}


    
 
