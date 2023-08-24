using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RotateAround : MonoBehaviour
{
    public Transform target; //obj to rotate around
    public int speed; //speed of rotation

    void Start()
    {
        if (target == null)
        {
            target = this.gameObject.transform;
            Debug.Log("RotateAround target not specified.  Defaulting to parent GameObject");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //RotateAround takes three arguments, first is the Venctor to rotate around
        //second is a vector that axis to rotate around
        //third is the degrees to rotate, in this case the speed per second
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
