using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickNewGame()
    {
      LoadingSceneController.Instance.LoadScene("scene2");
    }

    public void OnClickLoad()
    {

    }

    public void OnClickOption()
    {

    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
