using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class buttons : MonoBehaviour {
	public void StartLevel1()
	{
		SceneManager.LoadScene("Level 1");
	}
	public void StartLevel2()
	{
		SceneManager.LoadScene ("Level 2");
	}
	public void StartLevel3()
	{
		SceneManager.LoadScene ("Level 3");
	}

	public void QuitGame()
	{
		Application.Quit();
	}
	public void LevelSelect()
	{
		SceneManager.LoadScene ("LevelSel");
	}
	public void Settings()
	{
		SceneManager.LoadScene ("Settings");
	}
	public void MainMenu()
	{
		SceneManager.LoadScene ("mainmen");
	}
	public void Credits()
	{
		SceneManager.LoadScene ("Credits");
	}
	public void StartLevel4()
	{
		SceneManager.LoadScene ("Level 4");
	}
}

		