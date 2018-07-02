using UnityEngine;
public class YamadenSystem : MonoBehaviour
{
    [SerializeField] private GameObject _yamaUniversityFirstGradeObj;
    [SerializeField] private GameObject _yamaUniversityFourthGradeObj;
    [SerializeField] private GameObject _yamaMister;

    
    public void FirstGradeClick()
    {
        SetActive(true, false, false);
        AudioManager.Instance.PlayBgm(0);
    }

    public void FourthGradeClick()
    {
        SetActive(false, true, false);
        AudioManager.Instance.PlayBgm(1);
    }

    public void MisterClick()
    {
        SetActive(false, false, true);
        AudioManager.Instance.PlayBgm(2);
    }

    private void SetActive(bool firstGradeObjEnabled, bool fourthGradeObjEnabled, bool misterEnabled)
    {
        _yamaUniversityFirstGradeObj.SetActive(firstGradeObjEnabled);
        _yamaUniversityFourthGradeObj.SetActive(fourthGradeObjEnabled);
        _yamaMister.SetActive(misterEnabled);
    }
}