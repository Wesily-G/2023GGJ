﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int totalBoxs;
    public int finishedBoxs;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            //重新加载当前关卡
            ResetStage();
    }

    public void CheckFinish()
    {
        if(finishedBoxs == totalBoxs)
        {
            print("YOU WIN!");
            //等几秒切换
            StartCoroutine(LoadNextStage());
        }
    }

    void ResetStage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator LoadNextStage()
    {
        yield return new WaitForSeconds(2);
        //当前关卡编号+1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}