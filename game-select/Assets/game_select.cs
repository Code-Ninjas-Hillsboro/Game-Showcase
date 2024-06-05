using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.IO;
using System;

public class game_select : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       DirectoryInfo dir = new DirectoryInfo(Environment.CurrentDirectory.ToString());
       FileInfo[] info = dir.GetFiles("*.exe");
       Process p = new Process();
       p.StartInfo.FileName = info[UnityEngine.Random.Range(0,info.Length -1)].ToString();
       p.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
