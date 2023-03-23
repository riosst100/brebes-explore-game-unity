using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginManagement : MonoBehaviour
{
    [SerializeField] private GameObject privacyPolicyPopup;
    [SerializeField] private GameObject userAgreementPopup;

    public void openPrivacyPolicyPopup() 
    {
        privacyPolicyPopup.SetActive(true);
    }

    public void closePrivacyPolicyPopup() 
    {
        privacyPolicyPopup.SetActive(false);
    }

    public void openUserAgreementPopup() 
    {
        userAgreementPopup.SetActive(true);
    }

    public void closeUserAgreementPopup() 
    {
        userAgreementPopup.SetActive(false);
    }
}
