using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControlScript : MonoBehaviour
{

    public GameObject upCube;
    public GameObject downCube;
    public GameObject leftCube;
    public GameObject rightCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow pressed");
            upCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            print("Up arrow released");
            upCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow pressed");
            downCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            print("Down arrow released");
            downCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("Left arrow pressed");
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            print("Left arrow released");
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("Right arrow pressed");
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            print("Right arrow released");
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
    }
}
