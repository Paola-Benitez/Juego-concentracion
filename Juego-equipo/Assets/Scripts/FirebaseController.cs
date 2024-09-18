using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Importa TextMeshPro
using UnityEngine.UI;  // Aseg�rate de importar UnityEngine.UI para Toggle

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

    // Abrir el panel de inicio de sesi�n
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

    // Abrir el panel de olvid� contrase�a
    public void OpenForgetPass()
    {
        loginPanel.SetActive(false);
        signupPanel.SetActive(false);
        profilePanel.SetActive(false);
        forgetPasswordPanel.SetActive(true);
    }

    // L�gica de inicio de sesi�n
    public void LoginUser()
    {
        if (string.IsNullOrEmpty(loginEmail.text) || string.IsNullOrEmpty(loginPassword.text))
        {
            notificationPanel.SetActive(false);
            return;
        }

        // Aqu� va la l�gica para iniciar sesi�n en Firebase
    }

    // L�gica de registro de usuario
    public void SignUpUser()
    {
        if (string.IsNullOrEmpty(signupEmail.text) || string.IsNullOrEmpty(signupPassword.text) || string.IsNullOrEmpty(signupCPassword.text) || string.IsNullOrEmpty(signupUserName.text))
        {
            ShowNotificationMessage("Error", "Please fill in all the fields.");
            return;
        }

        // Aqu� va la l�gica de registro en Firebase
    }

    // L�gica para recuperar la contrase�a
    public void ForgetPass()
    {
        if (string.IsNullOrEmpty(forgetPassEmail.text))
        {
            ShowNotificationMessage("Error", "Please enter your email address.");
            return;
        }

        // Aqu� va la l�gica para restablecer la contrase�a
    }

    // Mostrar mensaje de notificaci�n
    private void ShowNotificationMessage(string title, string message)
    {
        notif_Title_Text.text = "" + title;  // Mostrar el t�tulo
        notif_Message_Text.text = "" + message;  // Mostrar el mensaje

        notificationPanel.SetActive(true);  // Mostrar panel de notificaci�n
    }

    // Cerrar el panel de notificaci�n
    public void CloseNotifPanel()
    {
        notif_Title_Text.text = "";  // Limpiar t�tulo
        notif_Message_Text.text = "";  // Limpiar mensaje

        notificationPanel.SetActive(false);  // Ocultar panel de notificaci�n
    }

    // Cerrar sesi�n del usuario
    public void LogOut()
    {
        profileUserName_Text.text = "";
        profileEmail_Text.text = "";
        OpenLoginPanel();

        // Aqu� puedes agregar la l�gica para cerrar la sesi�n en Firebase
    }
}
