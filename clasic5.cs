using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class clasic5 : MonoBehaviour
{
    [SerializeField] private TMP_InputField wdh, len, len2, dept, name, b1;
    public void Click()
    {

        float lenght = 0, width = 0, depth = 0,size = 0;
        width = float.Parse(wdh.text);
        lenght = float.Parse(len.text);
        depth = float.Parse(dept.text);
        size = float.Parse(b1.text);
        float size2 = (lenght-500-2*size)/2;
        string path = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\"+name.text+ ".tap");
        StreamWriter f = new StreamWriter(@path, true);
        f.Write("T1M6\n0G0Z5.000\nG0X0.000Y0.000S18000M3\n");
        f.Write("G0X"+ size +"Y" + 130  + "Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1Y480F132000.0\n");
        f.Write("X"+(lenght-size)+"\n");
        f.Write("Y130\n");
        f.Write("X"+size+"\n");
        f.Write("G0Z5.000\n");

        f.Write("G0Y" + 580 +"\n");
        f.Write("G1Z-" + depth + "F60000.0\n");
        f.Write("G1Y" + (width-430-size2) +"F132000.0\n");
        f.Write("X"+((lenght-500)/2)+"\n");
        f.Write("Y"+ 580 +"\n");
        f.Write("X"+size+"\n");
        f.Write("G0Z5.000\n");

        f.Write("G0Y" + (width-330-size2) +"\n");
        f.Write("G1Z-" + depth + "F60000.0\n");
        f.Write("G1Y" + (width-130) +"F132000.0\n");
        f.Write("X"+(lenght/2-50)+"\n");
        f.Write("Y"+ (width-130-size2) +"\n");
        for (float i = 90+11.53f; i <= 180-11.53f; i += 0.26f)
        {
            f.Write( "G1X" + (250 * Mathf.Cos(i * Mathf.PI / 180)+lenght/2) + "Y" + (250 * Mathf.Sin(i * Mathf.PI / 180)+(width-380-(size2))) + "\n");
        }
        f.Write("X"+size+"\n");
        f.Write("G0Z5.000\n");


        f.Write("G0X" + (lenght-size-size2) +"Y" + 580  + "Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1Y" + (width-430-size2) +"F132000.0\n");
        f.Write("X"+(lenght-size)+"\n");
        f.Write("Y"+ 580 +"\n");
        f.Write("X"+(lenght-size-size2)+"\n");
        f.Write("G0Z5.000\n");


        f.Write("G0Y" + (width-330-size2) +"\n");
        f.Write("G1Z-" + depth + "F60000.0\n");
        for (float i = 11.53f; i <= 90-11.53f; i += 0.26f)
        {
           f.Write( "G1X" + (250 * Mathf.Cos(i * Mathf.PI / 180)+lenght/2) + "Y" + (250 * Mathf.Sin(i * Mathf.PI / 180)+(width-380-(size2))) + "\n");
        }
        f.Write("G1Y" + (width-130) +"F132000.0\n");
        f.Write("X"+(lenght-size)+"\n");
        f.Write("Y"+ (width-330-size2) +"\n");
        f.Write("X"+(lenght-size-size2)+"\n");
        f.Write("G0Z5.000\n");

        f.Write("G0X" + (lenght-size-size2-100) +"Y" + (width-380-size2) + "Z5.000\nG1Z-" + depth + "F60000.0\n");
        for (float i = 0; i <= 180; i += 0.25f)
        {
            f.Write( "G1X" + (150 * Mathf.Cos(i * Mathf.PI / 180)+lenght/2) + "Y" + (150 * Mathf.Sin(i * Mathf.PI / 180)+(width-380-(size2))) + "\n");
        }
        f.Write("Y"+ 580 +"\n");
        f.Write("X"+(lenght-size-size2-100)+"\n");
        f.Write("Y"+ (width-380-size2) +"\n");

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
        file_2();


    }
    private void file_2()
    {
        float lenght = 0, width = 0, depth = 0,size = 0;
        width = float.Parse(wdh.text);
        lenght = float.Parse(len2.text);
        depth = float.Parse(dept.text);
        size = float.Parse(b1.text);
        float size2 = (float.Parse(len.text)-500-2*size)/2;
        string path = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\"+name.text+ "_U10"+".tap");
        StreamWriter f = new StreamWriter(@path, true);

        f.Write("T1M6\n0G0Z5.000\nG0X0.000Y0.000S18000M3\n");
        f.Write("G0X"+ size +"Y" + 130  + "Z5.000\nG1Z-" + depth + "F60000.0\n");
        f.Write("G1Y480F132000.0\n");
        f.Write("X"+(lenght-size)+"\n");
        f.Write("Y"+130+"\n");
        f.Write("X"+size+"\n");
        f.Write("G0Z5.000\n");

        f.Write("G0Y" + 580 +"\n");
        f.Write("G1Z-" + depth + "F60000.0\n");
        f.Write("G1Y" + (width-430-size2) +"F132000.0\n");
        f.Write("X"+(lenght-size)+"\n");
        f.Write("Y"+ 580 +"\n");
        f.Write("X"+size+"\n");
        f.Write("G0Z5.000\n");

        f.Write("G0Y" + (width-330-size2) +"\n");
        f.Write("G1Z-" + depth + "F60000.0\n");
        f.Write("G1Y" + (width-130) +"F132000.0\n");
        f.Write("X"+(lenght-size)+"\n");
        f.Write("Y"+ (width-330-size2) +"\n");
        f.Write("X"+size+"\n");


        f.Write("G0Z5.000\nG0X0.000Y0.000\nG0Z5.000\nG0X0Y0\nM30");
        f.Close();
        string  str = string.Empty;
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
