using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    
    public GameObject _squares;
    public GameObject number_text;
    int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject button = (GameObject)Instantiate(_squares, new Vector3(50, -45, 0), Quaternion.Euler(0, 0, 0));
        button.AddComponent<RectTransform>();
        button.AddComponent<Button>();
        button.transform.parent = this.transform;
        
        button.AddComponent<Image>();
        number_text.GetComponent<Text>().text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
