using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIlePuzzle : MonoBehaviour
{
    public NumberBox boxPrefab;

    public NumberBox[,] boxes = new NumberBox[4, 4];

    public Sprite[] sprites;

    void Start()
    {
        Init();
    }

    void FixedUpdate()
    {
        if (boxes[0, 2] != null && boxes[0, 2].GetComponent<SpriteRenderer>().sprite.name == "0")
        {
            if (boxes[1, 2] != null && boxes[1, 2].GetComponent<SpriteRenderer>().sprite.name == "1")
            {
                if (boxes[2, 2] != null && boxes[2, 2].GetComponent<SpriteRenderer>().sprite.name == "2")
                {
                    if (boxes[0, 1] != null && boxes[0, 1].GetComponent<SpriteRenderer>().sprite.name == "3")
                    {
                        if (boxes[1, 1] != null && boxes[1, 1].GetComponent<SpriteRenderer>().sprite.name == "4")
                        {
                            if (boxes[2, 1] != null && boxes[2, 1].GetComponent<SpriteRenderer>().sprite.name == "5")
                            {
                                if (boxes[0, 0] != null && boxes[0, 0].GetComponent<SpriteRenderer>().sprite.name == "6")
                                {
                                    if (boxes[1, 0] != null && boxes[1, 0].GetComponent<SpriteRenderer>().sprite.name == "7")
                                    {
                                        TileVar.y = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    void Init()
    {
        int n = 0;
        for(int y = 2; y >= 0; y--)
        {
            for (int x = 0; x < 3; x++)
            {
                NumberBox box = Instantiate(boxPrefab, new Vector2(x, y), Quaternion.identity);
                box.Init(x, y, n + 1, sprites[n], ClickToSwap);
                boxes[x, y] = box;
                n++;
            }
        }
    }

    void ClickToSwap(int x, int y)
    {
        int dx = getDx(x, y);
        int dy = getDy(x, y);
        Swap(x, y, dx, dy);
    }

    void Swap(int x, int y, int dx, int dy)
    {
        var from = boxes[x, y];
        var target = boxes[x + dx, y + dy];
        // swap the 2 boxes
        boxes[x, y] = target;
        boxes[x + dx, y + dy] = from;
        // update pos 2 boxes
        from.UpdatePos(x + dx, y + dy);
        target.UpdatePos(x, y);
    }


    int getDx(int x, int y)
    {
        // is right empty
        if(x < 2 && boxes[x + 1, y].IsEmpty())
        {
            return 1;
        }
        // is left empty
        if (x > 0 && boxes[x - 1, y].IsEmpty())
        {
            return -1;
        }
        return 0;
    }


    int getDy(int x, int y)
    {
        // is top empty
        if (y < 2 && boxes[x , y + 1].IsEmpty())
        {
            return 1;
        }
        // is bottom empty
        if (y > 0 && boxes[x, y - 1].IsEmpty())
        {
            return -1;
        }
        return 0;
    }
}
