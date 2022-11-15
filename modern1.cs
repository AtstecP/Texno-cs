using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class modern1 : MonoBehaviour
{
    [SerializeField] private TMP_InputField wdh, len, dept, name, b1;
    public void Click()
    {

        float lenght = 0, width = 0, depth = 0,size = 0;
        width = float.Parse(wdh.text);
        lenght = float.Parse(len.text);
        depth = float.Parse(dept.text);
        size = float.Parse(b1.text);
        string path = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\"+name.text+ ".tap");
        StreamWriter f = new StreamWriter(@path, true);
        f.Write("T1M6\n0G0Z5.000\nG0X0.000Y0.000S18000M3\n");
        f.Write("G0X"+ size +"Y0Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1Y"+ width +"F132000.0\n");
        f.Write("G0Z5.000\n");
        f.Write("G0X"+ (size+40) +"Y"+ width +"Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1Y0F132000.0\n");
        f.Write("G0Z5.000\n");
        f.Write("G0X"+ (size+40+80) +"Y0Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1Y"+ width +"F132000.0\n");
        f.Write("G0Z5.000\n");
        f.Write("G0X0Y580Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1X"+ lenght +"F132000.0\n");
        f.Write("G0Z5.000\n");
        f.Write("G0X"+ lenght +"Y660Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1X0F132000.0\n");
        f.Write("G0Z5.000\n");
        f.Write("G0X0Y700Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1X"+ lenght +"F132000.0\n");
        f.Write("G0Z5.000\nG0X0.000Y0.000\nG0Z5.000\nG0X0Y0\nM30");
        f.Close();
        string str = string.Empty;
        using (System.IO.StreamReader reader = System.IO.File.OpenText(@path))
        {
            str = reader.ReadToEnd();
        }
        str = str.Replace(",", ".");
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@path))
        {
            file.Write(str);
        }


    }
   
}
