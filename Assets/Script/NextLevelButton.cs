using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{
    [SerializeField] PlayManager playManager;
    private void OnEnable() {
        //Check next scene kalau tidak ada, sembunyikan button ini
        var currentScene = SceneManager.GetActiveScene();
        int currentLevel = int.Parse(currentScene.name.Split("Level ")[1]);
        int nextLevel = currentLevel + 1;

        var nextSceneBuildIndex = SceneUtility.GetBuildIndexByScenePath("Level " + nextLevel);
        if(nextSceneBuildIndex == -1){
            this.gameObject.SetActive(false);
        }
    }

    private void Start() {
        var gameOver=playManager.GameOver1;
        if(gameOver==true){
            this.gameObject.SetActive(false);
        }
    }

    public void NextLevel(){
        var currentScene = SceneManager.GetActiveScene();
        int currentLevel = int.Parse(currentScene.name.Split("Level ")[1]);
        int nextLevel = currentLevel + 1;
        SceneManager.LoadScene("Level "+ nextLevel);
    }
}
