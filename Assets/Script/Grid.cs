using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Grid : MonoBehaviour
{
    public int rows = 0;
    public int cols = 0;
    
    public float square_scale = 1.0f;
    public float square_offset = 0.0f;
    public Vector2 start_pos = new Vector2(0, 0);
    public GameObject grid_square;

    public GameObject _squares;
    public GameObject text_number;
    public Text number_text;
    int number = 1;
    public List<GameObject> grid_squares = new List<GameObject>();
    public GameObject[] arrBt;

    public GameObject[,] arr = new GameObject[9, 9];
    static bool[,] markRow = new bool[9,9];
    static bool[,] markCol = new bool[9,9];
    static bool[,,] markMatrix = new bool[3,3,9];
    // Start is called before the first frame update
    void Start()
    {
      
        //CreateGrid();
        Setup();
        Setup2();
    }

    // Update is called once per frame
    void Update()
    {
        SudokuSolver(9, 9);
    }
    
    private void Setup()
    {
        //for(int i =0;i< 81;i++)
        //{

        //}
        GameObject button = (GameObject)Instantiate(_squares, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
        button.AddComponent<RectTransform>();
        button.AddComponent<Button>();
    }
    private void Setup2()
    {
        //for (int i = 0; i < 81; i++)
        //{
        //    arrBt[i].GetComponentInChildren<Text>().text = number.ToString();
        //}
        text_number.GetComponent<Text>().text = number.ToString();
        number_text.text = number.ToString();

    }

    private void CreateGrid()
    {
        SpawnGridSquare();
        GridSquarePos();
    }
    private void SpawnGridSquare()
    {
        for(int row = 0;row < rows;row++)
        {
            for(int col = 0;col < cols;col++)
            {
                grid_squares.Add(Instantiate(grid_square) as GameObject);
                grid_squares[grid_squares.Count - 1].transform.parent = this.transform;
                grid_squares[grid_squares.Count - 1].transform.localScale = new Vector3(square_scale,square_scale,square_scale);

            }
        }
    }
    private void GridSquarePos()
    {
        //var square_rect = grid_squares[0].GetComponent<RectTransform>();
        //Vector2 offset = new Vector2();
        //offset.x = square_rect.rect.width * square_rect.transform.localScale.x + square_offset;
        //offset.y = square_rect.rect.height * square_rect.transform.localScale.y + square_offset;
        //int row_number = 0;
        //int col_number = 0;
        //foreach(GameObject square in grid_squares)
        //{
        //    if(col_number +1>cols)
        //    {
        //        row_number++;
        //        col_number = 0;
        //    }
        //    var pos_x_offset = offset.x * row_number;
        //    var pos_y_offset = offset.y * col_number;
        //    square.GetComponent<RectTransform>().anchoredPosition = new Vector2(start_pos.x + pos_x_offset, start_pos.y - pos_y_offset);
        //    col_number++;
        //}
    }

    public void SudokuSolver(int row,int col)
    {
        if(row < 9 && col <9 )
        {

        }
        else if(row < 9 && col >=9)
        {

        }

    }
    public void StartSolve()
    {
        SudokuSolver(9, 9);
        Debug.Log("AAAAAAAAAAAAAAAAA");
    }
}
