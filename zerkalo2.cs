using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class zerkalo2 : MonoBehaviour
{
    [SerializeField] private TMP_InputField wdh, len, size, name, size1;
    public void Start()
    {
        size.text = ("167,5");
        size1.text = ("167,5");
    }
    public void Click()
    {
        float lenght = 0 , width = 0 , depth, cord , cordhight ;
        depth = 2;
        cord = 167.5f;
        cordhight = 167.5f;
        cord = float.Parse(size1.text);
        width = float.Parse(wdh.text);
        lenght = float.Parse(len.text);
        cordhight = float.Parse(size.text);
        string path = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\"+name.text+ ".tap");
        StreamWriter f = new StreamWriter(@path, true);
        f.Write("T1M6\nG0Z5.000\nG0X0.000Y0.000S18000M3\n");
            f.Write("G0X"+ cord + "Y" + (width - cordhight) + "Z5.000\nG1Z-" + depth + ".000F80000.0\n");
            f.Write("G1X" + (lenght - cord) + "F10000.0\n");
            f.Write("Y" + cordhight + "\nX" + cord + "\nY" + (width - cordhight) + "\n");
            f.Write("G1Z-" + depth*2 + ".000F80000.0\n");
            f.Write("G1X" + (lenght - cord) + "F10000.0\n");
            f.Write("Y" + cordhight + "\nX" + cord + "\nY" + (width - cordhight) + "\nG0Z5.000\n");

            cord = cord +15f;
            cordhight = cordhight+15f;
            f.Write("G0X" + cord + "Y" + cordhight);
            for (int i = 1; i <=4;++i)
            {
                f.Write("\nG1Z-" + (depth*i) + "F8000.0\n");
                f.Write("G1X" +(lenght - cord)+ "F10000.0\n");
                f.Write("Y" + (width - cordhight) + "\nX" + cord + "\nY" + cordhight);
            }
            f.Write("\nG0Z5.000\n");

            cord = cord + 20.5f;
            cordhight = cordhight + 20.5f;
            f.Write("G0X" + cord + "Y" + cordhight);
            for(int i = 1; i <=8; ++i)
            {
                f.Write("\nG1Z-" + (depth*i) + "F8000.0\n");
                f.Write("G1X" + (lenght - cord) + "F10000.0\n");
                f.Write("Y" + (width - cordhight) + "\nX" + cord + "\nY" + cordhight);
            }

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
    public void Click2()
    {
        float lenght = 0 , width = 0 , depth , cord  , cordhight ;
        depth = 2.5f;
        cord = 122.5f;
        cordhight = 122.5f;
        cord = float.Parse(size1.text)-45f;
        width = float.Parse(wdh.text);
        lenght = float.Parse(len.text);
        cordhight = float.Parse(size.text)-45f;
        string path = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\"+name.text+"-N4"+".tap");
        StreamWriter f = new StreamWriter(@path, true);
        f.Write("T1M6\nG0Z5.000\nG0X0.000Y0.000S18000M3\n");
        f.Write("G0X"+ cord + "Y" + (width - cordhight) + "Z5.000\nG1Z-" + depth + ".000F80000.0\n");
        f.Write("G1X" + (lenght - cord) + "F2100.0\n");
        f.Write("Y" + cordhight + "\nX" + cord + "\nY" + (width - cordhight));
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
        Click();
    }
    public void Click3()
    {
        float lenght = 0 , width = 0 , depth , cord  , cordhight ;
        
        depth = 2.5f;
        cord = 107.5f;
        cordhight = 107.5f;
        cord = float.Parse(size1.text)-60f;
        width = float.Parse(wdh.text);
        lenght = float.Parse(len.text);
        cordhight = float.Parse(size.text)-60f;
        string path = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\"+name.text+"-N5"+".tap");
        StreamWriter f = new StreamWriter(@path, true);
        f.Write("T1M6\nG0Z5.000\nG0X0.000Y0.000S18000M3\n");
        f.Write("G0X"+ cord + "Y" + (width - cordhight) + "Z5.000\nG1Z-" + depth + ".000F80000.0\n");
        f.Write("G1X" + (lenght - cord) + "F2100.0\n");
        f.Write("Y" + cordhight + "\nX" + cord + "\nY" + (width - cordhight));
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
        Click();
        Click2();
    }
}
