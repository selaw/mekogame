using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quiz : MonoBehaviour
{

    [SerializeField] public Color correctCol, wrongCol, normalCol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int answer;
    public void Answer(int ans){
        if (ans==1){
            answer = 1;
        }
        else{
            answer = 0;
        }
    }

    public void Answer_Button(Button btn){

        //bool answer = quiz.Answer();

        if(answer==1){
            btn.image.color = correctCol;
            ColorBlock cb = btn.colors;
            cb.normalColor = correctCol;
            cb.highlightedColor = correctCol;
            cb.pressedColor = correctCol;
            btn.colors = cb;
        }
        else{
            btn.image.color = wrongCol;
            ColorBlock cb = btn.colors;
            cb.normalColor = wrongCol;
            cb.highlightedColor = wrongCol;
            cb.pressedColor = wrongCol;
            btn.colors = cb;
            
        }
        
    }
    public void Correct_button(Button cbtn){
        cbtn.image.color = correctCol;
        ColorBlock cb = cbtn.colors;
        cb.normalColor = correctCol;
        cb.highlightedColor = correctCol;
        cb.pressedColor = correctCol;
        cbtn.colors = cb;
    }
}
