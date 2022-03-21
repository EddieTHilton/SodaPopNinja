using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ETH_ClickHandling : MonoBehaviour
{

    public GameObject EnemyPrefab;
    public GameObject PopEffect;

    public int finishSceneIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Ray ray =Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)){

                if (hit.collider.gameObject.tag == "enemy") {
                    
                    
                    Instantiate(EnemyPrefab, new Vector3 (0,0,0), Quaternion.identity);
                    Instantiate(PopEffect, hit.collider.gameObject.transform.position, Quaternion.identity);
                    Destroy(hit.collider.gameObject);
                }

                if (hit.collider.gameObject.tag == "Finish") {
                    
                    
                    SceneManager.LoadScene(finishSceneIndex);
                }
            }

        }
    }
}
