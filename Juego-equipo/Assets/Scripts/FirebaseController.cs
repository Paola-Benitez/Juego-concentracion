using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Importa TextMeshPro
using UnityEngine.UI;  // Asegúrate de importar UnityEngine.UI para Toggle

public class FirebaseController : MonoBehaviour
{
    // Paneles de la UI
    public GameObject loginPanel, signupPanel, profilePanel, forgetPasswordPanel, notificationPanel;

    // Cambia InputField a TMP_InputField
    public TMP_InputField loginEmail, loginPassword, signupEmail, signupPassword, signupCPassword, signupUserName, forgetPassEmail;

    // Cambia Text a TMP_Text
    public TMP_Text notif_Title_Text, notif_Message_Text, profileUserName_Text, profileEmail_Text;

    // Toggle de "Recordarme"
    public Toggle rememberMe;

    // Abrir el panel de inicio de sesión
    public void OpenLoginPanel()
    {
        loginPanel.SetActive(true);
        signupPanel.SetActive(false);
        profilePanel.SetActive(false);
        forgetPasswordPanel.SetActive(false);
    }

    // Abrir el panel de registro
    public void OpenSignUpPanel()
    {
        loginPanel.SetActive(false);
        signupPanel.SetActive(true);
        profilePanel.SetActive(false);
        forgetPasswordPanel.SetActive(false);
    }

    // Abrir el panel del perfil
    public void OpenProfilePanel()
    {
        loginPanel.SetActive(false);
        signupPanel.SetActive(false);
        profilePanel.SetActive(true);
        forgetPasswordPanel.SetActive(false);
    }

    // Abrir el panel de olvidó contraseña
    public void OpenForgetPass()
    {
        loginPanel.SetActive(false);
        signupPanel.SetActive(false);
        profilePanel.SetActive(false);
        forgetPasswordPanel.SetActive(true);
    }

    // Lógica de inicio de sesión
    public void LoginUser()
    {
        if (string.IsNullOrEmpty(loginEmail.text) || string.IsNullOrEmpty(loginPassword.text))
        {
            notificationPanel.SetActive(false);
            return;
        }

        // Aquí va la lógica para iniciar sesión en Firebase
    }

    // Lógica de registro de usuario
    public void SignUpUser()
    {
        if (string.IsNullOrEmpty(signupEmail.text) || string.IsNullOrEmpty(signupPassword.text) || string.IsNullOrEmpty(signupCPassword.text) || string.IsNullOrEmpty(signupUserName.text))
        {
            ShowNotificationMessage("Error", "Please fill in all the fields.");
            return;
        }

        // Aquí va la lógica de registro en Firebase
    }

    // Lógica para recuperar la contraseña
    public void ForgetPass()
    {
        if (string.IsNullOrEmpty(forgetPassEmail.text))
        {
            ShowNotificationMessage("Error", "Please enter your email address.");
            return;
        }

        // Aquí va la lógica para restablecer la contraseña
    }

    // Mostrar mensaje de notificación
    private void ShowNotificationMessage(string title, string message)
    {
        notif_Title_Text.text = "" + title;  // Mostrar el título
        notif_Message_Text.text = "" + message;  // Mostrar el mensaje

        notificationPanel.SetActive(true);  // Mostrar panel de notificación
    }

    // Cerrar el panel de notificación
    public void CloseNotifPanel()
    {
        notif_Title_Text.text = "";  // Limpiar título
        notif_Message_Text.text = "";  // Limpiar mensaje

        notificationPanel.SetActive(false);  // Ocultar panel de notificación
    }

    // Cerrar sesión del usuario
    public void LogOut()
    {
        profileUserName_Text.text = "";
        profileEmail_Text.text = "";
        OpenLoginPanel();

        // Aquí puedes agregar la lógica para cerrar la sesión en Firebase
    }
}
