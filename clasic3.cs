using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class clasic3 : MonoBehaviour
{
    [SerializeField] private TMP_InputField wdh, len, dept, name, b1;
    public void Click()
    {
        float lenght = 0, width = 0, depth = 0,size = 0;
        width = float.Parse(wdh.text);
        lenght = float.Parse(len.text);
        depth = float.Parse(dept.text);
        size = float.Parse(b1.text);
        lenght = (lenght-60) / 2;
        string path = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\"+name.text+ ".tap");
        StreamWriter f = new StreamWriter(@path, true);
        f.Write("T1M6\n0G0Z5.000\nG0X0.000Y0.000S18000M3\n");
        f.Write("G0X"+ size +"Y" + 130  + "Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1Y" + 700 +"F132000.0\n");
        f.Write("X"+lenght+"\n");
        f.Write("Y"+130+"\n");
        f.Write("X"+size+"\n");
        f.Write("G0Z5.000\n");
        f.Write("G0Y" + 800 +"\n");
        f.Write("G1Z-" + depth + "F60000.0\n");
        f.Write("G1Y" + 1000 +"F132000.0\n");
        f.Write("X"+lenght+"\n");
        f.Write("Y"+800+"\n");
        f.Write("X"+size+"\n");
        f.Write("G0Z5.000\n");
        f.Write("G0Y" + 1100 +"\n");
        f.Write("G1Z-" + depth + "F60000.0\n");
        f.Write("G1Y" + (width-130) +"F132000.0\n");
        f.Write("X"+lenght+"\n");
        f.Write("Y"+ 1100 +"\n");
        f.Write("X"+ size +"\n");
        f.Write("G0Z5.000\n");
        
        size = lenght + 100;
        lenght = lenght*2;
        f.Write("T1M6\n0G0Z5.000\nG0X0.000Y0.000S18000M3\n");
        f.Write("G0X"+ size +"Y" + 130  + "Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1Y" + 700 +"F132000.0\n");
        f.Write("X"+lenght+"\n");
        f.Write("Y"+130+"\n");
        f.Write("X"+size+"\n");
        f.Write("G0Z5.000\n");
        f.Write("G0Y" + 800 +"\n");
        f.Write("G1Z-" + depth + "F60000.0\n");
        f.Write("G1Y" + 1000 +"F132000.0\n");
        f.Write("X"+lenght+"\n");
        f.Write("Y"+800+"\n");
        f.Write("X"+size+"\n");
        f.Write("G0Z5.000\n");
        f.Write("G0Y" + 1100 +"\n");
        f.Write("G1Z-" + depth + "F60000.0\n");
        f.Write("G1Y" + (width-130) +"F132000.0\n");
        f.Write("X"+lenght+"\n");
        f.Write("Y"+ 1100 +"\n");
        f.Write("X"+ size +"\n");


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
