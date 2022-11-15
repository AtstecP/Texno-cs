using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class modern2 : MonoBehaviour
{
    [SerializeField] private TMP_InputField wdh, len, dept, name;
    public float alfa;
    public void Click()
    {

        float lenght = 0, width = 0, depth = 0,size = 0, r;
        width = float.Parse(wdh.text);
        lenght = float.Parse(len.text);
        depth = float.Parse(dept.text);
        string path = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\"+name.text+ ".tap");
        StreamWriter f = new StreamWriter(@path, true);
        r = ((width/2-100)*(width/2-100)+(lenght-170)*(lenght-170))/(2*(lenght-170));
        f.Write("T1M6\n0G0Z5.000\nG0X0.000Y0.000S18000M3\n");
        f.Write("G0X0Y100Z5.000\nG1Z-" + depth + "F60000.0\n");
        //alfa = (float)Math.Acos((r-(lenght-170))/r)* 180/Mathf.PI  ;
        // for (float i = -alfa; i <= alfa; i += 0.025f)
        // {
        //     f.Write( "G1X" + (r * Mathf.Cos(i * Mathf.PI / 180)-(r-lenght+170)) + "Y" + (r * Mathf.Sin(i * Mathf.PI / 180)+(width/2)) + "\n");
        // }
        f.Write("G03X0Y"+ width+"I"+ (-(r-lenght+170))+ "J"+(width/2-100));
        f.Write("\nG0Z5.000\n");
        r = ((width/2)*(width/2)+(lenght-300)*(lenght-300))/(2*(lenght-300));
        //alfa = (float)Math.Asin((width/2)/r) * 180/Mathf.PI  ;
        f.Write("G0X150Y0Z5.000\nG1Z-" + depth + "F60000.0\n");
        // for (float i = -alfa; i <= alfa; i += 0.025f)
        // {
        //     f.Write( "G1X" + (r * Mathf.Cos(i * Mathf.PI / 180)-(-lenght+150+r)) + "Y" + (r * Mathf.Sin(i * Mathf.PI / 180)+(width/2)) + "\n");
        // }
        f.Write("G03X150Y"+ width+"I"+ (-(-lenght+150+r)-150)+ "J"+(width/2));
        f.Write("\nG0Z5.000\n");
        r = ((width/2)*(width/2)+(lenght-430)*(lenght-430))/(2*(lenght-430));
        //alfa = (float)Math.Asin((width/2)/r) * 180/Mathf.PI  ;
        f.Write("G0X300Y0Z5.000\nG1Z-" + depth + "F60000.0\n");
        // for (float i = -alfa; i <= alfa; i += 0.025f)
        // {
        //     f.Write( "G1X" + (r * Mathf.Cos(i * Mathf.PI / 180)-(-lenght+130+r)) + "Y" + (r * Mathf.Sin(i * Mathf.PI / 180)+(width/2)) + "\n");
        // }
        f.Write("G03X300Y"+ width+"I"+ (-(-lenght+130+r)-300)+ "J"+(width/2));
        f.Write("\nG0Z5.000\nG0X0.000Y0.000\nG0Z5.000\nG0X0Y0\nM30");
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
