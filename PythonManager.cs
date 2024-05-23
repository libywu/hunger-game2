using System.Diagnostics;
using System.IO;
using UnityEditor.Scripting.Python;
using UnityEngine;


public class PythonManager : MonoBehaviour
{

    [System.Obsolete]

    void Update()
    {
        string path = Application.dataPath + "/Python/pythonTest.py";
        PythonRunner.RunFile(path);
    }



}
