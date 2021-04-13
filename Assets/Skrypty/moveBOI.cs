using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBOI : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject BigBoi;
    long bigBoi33 = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {bigBoi33++;
            Debug.Log("KUTAS");
            BigBoi.transform.localScale = new Vector3(BigBoi.transform.localScale.x, BigBoi.transform.localScale.y,  bigBoi33);
            BigBoi.transform.localPosition += new Vector3(0,0,0.5f);
            
        }
       
    }
}
