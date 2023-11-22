using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelToggle : MonoBehaviour
{
    public GameObject[] levels;
    public int levelDistance = 100;
    private int index = 0;

    void Start()
    {
        levels[0].transform.position = Vector3.zero;
        for (int i = 1; i < levels.Length; i++)
        {
            levels[i].transform.position = new Vector3(0, levelDistance * (i + 1), 0);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            levels[index].transform.position = new Vector3(0, levelDistance * (index + 1), 0);
            index ++;
            if (index >= levels.Length) {
                index = 0;
            }
            levels[index].transform.position = Vector3.zero;
        }
    }
}