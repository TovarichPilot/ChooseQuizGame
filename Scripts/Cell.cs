using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public int X { get; private set; }
    public int Y { get; private set; }

    [SerializeField]
    private Image image;

    public void Position(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void UpdateCellColor()
    {
        int Value = Random.Range(0, 9);
        image.color = ColorManager.Instance.CellColors[Value];
    }
}
