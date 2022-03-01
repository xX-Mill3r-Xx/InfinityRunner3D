using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlataform : MonoBehaviour
{
    public List<GameObject> plataforms = new List<GameObject>();
    public int offSet;

    void Start()
    {
        for(int i = 0; i < plataforms.Count; i++)
        {
            Instantiate(plataforms[i], new Vector3(0,0,i * 86), transform.rotation);
            offSet += 86;
        }
    }

    void Update()
    {
        
    }

    public void Recycle(GameObject plataform)
    {
        plataform.transform.position = new Vector3(0, 0, offSet);
        offSet += 86;
    }
}
