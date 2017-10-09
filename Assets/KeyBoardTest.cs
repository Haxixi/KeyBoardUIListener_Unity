using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using DG.Tweening;

public class KeyBoardTest : MonoBehaviour
{

    public Image[] images;

    private Image preTransform;

    private Image curTransform;

    List<Image> templist = new List<Image>();

    private int s;

    private int w;

    private int d;

    private int a;

    private int PreNum;

    // Use this for initialization
    void Start()
    {
        images = GetComponentsInChildren<Image>();

        Image temp;

        for (int i = 0; i < images.Length; i++)
        {
            for (int j = i + 1; j < images.Length; j++)
            {
                if (SetNameNum(images[j].name) < SetNameNum(images[i].name))
                {
                    temp = images[j];
                    images[j] = images[i];
                    images[i] = temp;
                }
            }
        }

        images[s].DOFade(0f, 1);

    }


    //Image BubbleSort(List<Image> list)
    //{
    //    Image temp;

    //    for (int i = 0; i < list.Count; i++)
    //    {
    //        for (int j = i + 1; j < list.Count; j++)
    //        {
    //            if (SetNameNum(images[j].name) < SetNameNum(images[i].name))
    //            {
    //                temp = images[j];
    //                images[j] = images[i];
    //                images[i] = temp;
    //            }
    //        }
    //    }

    //    return list[0];
    //}


    void Update()
    {
        SetButton();

        if (Input.GetKeyDown(KeyCode.Z))
        {
            SelectButton();
        }

    }

    void SelectButton()
    {
        if (curTransform == images[0])
        {
            Method1();
        }
        else if (curTransform == images[1])
        {
            Method2();
        }
        else if (curTransform == images[1])
        {
            Method3();
        }
        else if (curTransform == images[1])
        {
            Method4();
        }
        else if (curTransform == images[1])
        {
            Method5();
        }
        else if (curTransform == images[1])
        {
            Method6();
        }
        else if (curTransform == images[1])
        {
            Method7();
        }
        else if (curTransform == images[1])
        {
            Method8();
        }
        else if (curTransform == images[1])
        {
            Method9();
        }
        else
        {
            Method10();
        }
    }


    int CurSerialNumber(Image curImage)
    {
        for (int i = 0; i < images.Length; i++)
        {
            if (images[i] == curImage)
                return i;
        }

        return 0;
    }

    //int PreSerialNumber(Image preImage)
    //{
    //    for (int i = 0; i < images.Length; i++)
    //    {
    //        if (images[i] == preImage)
    //            return i;
    //    }

    //    return 0;
    //}


    void SetButton()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            s = CurSerialNumber(curTransform);

            PreNum = s;

            for (int k = 1; k < images.Length; k++)
            {
                if (images[k].rectTransform.position.y < images[s].rectTransform.position.y)
                {
                    s = k;

                    curTransform = images[s];

                    preTransform = images[PreNum];

                    curTransform.DOFade(0f, 1);

                    preTransform.DOFade(1, 1);

                    return;
                }
            }
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            w = CurSerialNumber(curTransform);

            PreNum = w;

            int count = 0;

            for (int k = w - 1; k >= 0; k--)
            {
                if (images[k].rectTransform.position.y > images[w].rectTransform.position.y)
                {
                    for (int i = 0; i <= k; i++)
                    {
                        if (images[i].rectTransform.position.y != images[k].rectTransform.position.y)
                        {
                            count++;
                        }
                    }

                    k = count;

                    w = k;

                    curTransform = images[w];

                    preTransform = images[PreNum];

                    curTransform.DOFade(0f, 1);

                    preTransform.DOFade(1, 1);

                    return;
                }
            }
        }


        else if (Input.GetKeyDown(KeyCode.D))
        {
            d = CurSerialNumber(curTransform);

            PreNum = d;

            for (int i = d + 1; i < images.Length; i++)
            {
                if (images[i].rectTransform.position.x > images[d].rectTransform.position.x && images[i].rectTransform.position.y == images[d].rectTransform.position.y)
                {
                    d = i;

                    curTransform = images[d];

                    preTransform = images[PreNum];

                    curTransform.DOFade(0f, 1);

                    preTransform.DOFade(1, 1);

                    return;
                }
            }
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            a = CurSerialNumber(curTransform);

            PreNum = a;

            for (int i = a - 1; i >= 0; i--)
            {
                if (images[i].rectTransform.position.x < images[a].rectTransform.position.x && images[i].rectTransform.position.y == images[a].rectTransform.position.y)
                {
                    a = i;

                    curTransform = images[a];

                    preTransform = images[PreNum];

                    curTransform.DOFade(0f, 1);

                    preTransform.DOFade(1, 1);

                    return;
                }
            }
        }

    }



    void Method1()
    {
        Debug.Log("1");
    }

    void Method2()
    {
        Debug.Log("2");
    }

    void Method3()
    {
        Debug.Log("3");
    }

    void Method4()
    {
        Debug.Log("4");
    }

    void Method5()
    {
        Debug.Log("5");
    }

    void Method6()
    {
        Debug.Log("6");
    }

    void Method7()
    {
        Debug.Log("7");
    }

    void Method8()
    {
        Debug.Log("8");
    }

    void Method9()
    {
        Debug.Log("9");
    }

    void Method10()
    {
        Debug.Log("10");
    }


    float SetNameNum(string name)
    {
        return int.Parse(name.Split(new char[] { '_' })[1]);
    }
}
