using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chanks : MonoBehaviour
{

    //переменная, содержащая список картинок, на которые можно поменять текущую
    public Sprite[] imgs;

    //переменная для указания-какой вид имеет текущая ячейка на поле
    public int Index = 0;

    void ChangeImgs()
    {
        if (imgs.Length > Index)
        {
            //задаём картинку блоку 
            GetComponent<SpriteRenderer>().sprite = imgs[Index];
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ChangeImgs();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeImgs();
    }
}
