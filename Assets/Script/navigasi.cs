using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navigasi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // NAVIGASI TOMBOL
    public void ke(int step){
        //Application.LoadLevel (step);
        SceneManager.LoadScene(step);
    }

    //click sound
    public AudioSource SoundFx;
    public AudioClip click;
    public AudioClip hover;

    public void hoverSound(){
        SoundFx.PlayOneShot (hover);
    }

    public void clickSound(){
        SoundFx.PlayOneShot (click);
    } 

    // QUIT BUTTON
    public void Exit(){
        Application.Quit();
        Debug.Log("Keluar!!");
    }


   
}