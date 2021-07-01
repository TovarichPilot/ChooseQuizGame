using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Field : MonoBehaviour
{
    [Header("Field Properties")]
    public float CellSize;
    public float Spacing;
    public int FieldSize;

    [Space(5)]
    [SerializeField]
    private Cell cellPref;
    [SerializeField]
    private RectTransform rt;

    private Cell[,] field;

    public void Start()
    {
        GenerateField();
    }

    private void CreateField()
    {
        
        field = new Cell[FieldSize, 1];

        float fieldWidth = FieldSize * (CellSize + Spacing) + Spacing;
        rt.sizeDelta = new Vector2(fieldWidth, fieldWidth);

        float StartX = -(fieldWidth / 2) + (CellSize / 2) + Spacing;
        float StartY = (fieldWidth / 2) - (CellSize / 2) - Spacing;

        for (int x = 0; x < FieldSize; x++)
        {
            for (int y = 0; y < 1; y++)
            {
                var cell = Instantiate(cellPref, transform, false);
                var position = new Vector2(StartX + (x * (CellSize + Spacing)), StartY - (y * (CellSize + Spacing)));
                cell.transform.localPosition = position;

                field[x, y] = cell;

                cell.Position(x, y);
            }
        }

    }


    public void GenerateField()
    {
        if (field == null)
            CreateField();

        for (int x = 0; x < FieldSize; x++)
            for (int y = 0; y < 1; y++)
                field[x, y].Position(x, y);
    }
}
