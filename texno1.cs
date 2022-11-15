using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class texno1 : MonoBehaviour
{
    [SerializeField] private TMP_InputField wdh, len, dept, name;
    public void Click()
    {
        float lenght = 0, width = 0, depth = 0,size = 0;
        width = float.Parse(wdh.text);
        lenght = float.Parse(len.text);
        depth = float.Parse(dept.text);
        size = width / 5;
        string path = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\"+name.text+ ".tap");
        StreamWriter f = new StreamWriter(@path, true);
        f.Write("T1M6\n0G0Z5.000\nG0X0.000Y0.000S18000M3\n");
        f.Write("G0X0.000Y" + size  + "Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1X" + lenght +"F132000.0\n");
        f.Write("G0Z5.000\n");
        f.Write("G0X" +lenght+ "Y" + (2*size)  + "Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1X0.000F132000.0\n");
        f.Write("G0Z5.000\n");
        f.Write("G0X0.000Y" + (3*size)  + "Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1X" + lenght +"F132000.0\n");
        f.Write("G0Z5.000\n");
        f.Write("G0X" +lenght+ "Y" + (4*size)  + "Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1X0.000F132000.0\n");
        f.Write("G0Z5.000\n");
        f.Write("G0X" +(lenght/2)+ "Y0.000Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1Y"+ width +"F132000.0\n");
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
