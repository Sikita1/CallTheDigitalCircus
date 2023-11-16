using UnityEngine;
using UnityEngine.UI;
using YG;

public class Controller : MonoBehaviour
{
    [SerializeField] private CallPanel _panel;
    [SerializeField] private Image _imagePanel;

    [SerializeField] private AllPersons _allPersons;

    [SerializeField] private AudioClip[] _audioCaine;
    [SerializeField] private AudioClip[] _audioGangle;
    [SerializeField] private AudioClip[] _audioJax;
    [SerializeField] private AudioClip[] _audioKinger;
    [SerializeField] private AudioClip[] _audioPomni;
    [SerializeField] private AudioClip[] _audioRagatha;
    [SerializeField] private AudioClip[] _audioZooble;
    [SerializeField] private AudioClip[] _audioHorror;

    [SerializeField] private Image _caineHorror;
    [SerializeField] private Image _gangleHorror;
    [SerializeField] private Image _jaxHorror;
    [SerializeField] private Image _kingerHorror;
    [SerializeField] private Image _pomniHorror;
    [SerializeField] private Image _ragathaHorror;
    [SerializeField] private Image _zoobleHorror;

    private AudioSource _audioSource;
    private int _countADS;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        _panel.gameObject.SetActive(false);
        _countADS = 0;
    }

    public void ButtonClickCaine(Image image)
    {
        if (IsChanceHorror())
        {
            ShowHorrorScene(_caineHorror);
        }
        else
        {
            ShowCharacterImage(image);
            PlayAudioCharacter(_audioCaine);
        }

        _counterADS();
    }

    public void ButtonClickGangle(Image image)
    {
        if (IsChanceHorror())
        {
            ShowHorrorScene(_gangleHorror);
        }
        else
        {
            ShowCharacterImage(image);
            PlayAudioCharacter(_audioGangle);
        }

        _counterADS();
    }

    public void ButtonClickJax(Image image)
    {
        if (IsChanceHorror())
        {
            ShowHorrorScene(_jaxHorror);
        }
        else
        {
            ShowCharacterImage(image);
            PlayAudioCharacter(_audioJax);
        }

        _counterADS();
    }

    public void ButtonClickKinger(Image image)
    {
        if (IsChanceHorror())
        {
            ShowHorrorScene(_kingerHorror);
        }
        else
        {
            ShowCharacterImage(image);
            PlayAudioCharacter(_audioKinger);
        }

        _counterADS();
    }

    public void ButtonClickPomni(Image image)
    {
        if (IsChanceHorror())
        {
            ShowHorrorScene(_pomniHorror);
        }
        else
        {
            ShowCharacterImage(image);
            PlayAudioCharacter(_audioPomni);
        }

        _counterADS();
    }

    public void ButtonClickRagatha(Image image)
    {
        if (IsChanceHorror())
        {
            ShowHorrorScene(_ragathaHorror);
        }
        else
        {
            ShowCharacterImage(image);
            PlayAudioCharacter(_audioRagatha);
        }

        _counterADS();
    }

    public void ButtonClickZooble(Image image)
    {
        if (IsChanceHorror())
        {
            ShowHorrorScene(_zoobleHorror);
        }
        else
        {
            ShowCharacterImage(image);
            PlayAudioCharacter(_audioZooble);
        }

        _counterADS();
    }

    public void ButtonExit()
    {
        int triggerADS = 5;

        _allPersons.gameObject.SetActive(true);
        _panel.gameObject.SetActive(false);
        _audioSource.Stop();

        if (_countADS == triggerADS)
        {
            YandexGame.FullscreenShow();
            _countADS = 0;
        }
    }

    private void ShowHorrorScene(Image image)
    {
        ShowCharacterImage(image);
        PlayAudioCharacter(_audioHorror);
    }

    private bool IsChanceHorror()
    {
        bool isChance = false;
        int maxPercent = 4;
        int minPercent = 1;

        int currrentPercent = Random.Range(minPercent, maxPercent);

        if (currrentPercent == minPercent)
            isChance = true;

        return isChance;
    }

    private void PlayAudioCharacter(AudioClip[] audioClips)
    {
        _audioSource.clip = GetRundomAudio(audioClips);
        _audioSource.Play();
    }

    private void ShowCharacterImage(Image image)
    {
        _imagePanel.sprite = image.sprite;
        _allPersons.gameObject.SetActive(false);
        _panel.gameObject.SetActive(true);
    }

    private AudioClip GetRundomAudio(AudioClip[] audioClips)
    {
        int randomNumber = Random.Range(0, audioClips.Length);
        return audioClips[randomNumber];
    }

    private int _counterADS() => _countADS++;
}
