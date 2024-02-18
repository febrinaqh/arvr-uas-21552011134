using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void MainMenu() {
        SceneManager.LoadScene("MainMenu");
    }

    public void ARrestroom() {
        SceneManager.LoadScene("ARrestroom");
    }

    public void ARlivingroom() {
        SceneManager.LoadScene("ARlivingroom");
    }

    public void ARinterior() {
        SceneManager.LoadScene("ARinterior");
    }
    public void VRrestroom() {
        SceneManager.LoadScene("VRrestroom");
    }
    public void VRlivingroom() {
        SceneManager.LoadScene("VRlivingroom");
    }
    public void VRinterior() {
        SceneManager.LoadScene("VRinterior");
    }
}
