using System.Collections;
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
        _imagePanel.sprite = image.sprite;
        _allPersons.gameObject.SetActive(false);
        _panel.gameObject.SetActive(true);
        _audioSource.clip = GetRundomAudio(_audioCaine);
        _audioSource.Play();
        _countADS++;
    }

    public void ButtonClickGangle(Image image)
    {
        _imagePanel.sprite = image.sprite;
        _allPersons.gameObject.SetActive(false);
        _panel.gameObject.SetActive(true);
        _audioSource.clip = GetRundomAudio(_audioGangle);
        _audioSource.Play();
        _countADS++;
    }

    public void ButtonClickJax(Image image)
    {
        _imagePanel.sprite = image.sprite;
        _allPersons.gameObject.SetActive(false);
        _panel.gameObject.SetActive(true);
        _audioSource.clip = GetRundomAudio(_audioJax);
        _audioSource.Play();
        _countADS++;
    }

    public void ButtonClickKinger(Image image)
    {
        _imagePanel.sprite = image.sprite;
        _allPersons.gameObject.SetActive(false);
        _panel.gameObject.SetActive(true);
        _audioSource.clip = GetRundomAudio(_audioKinger);
        _audioSource.Play();
        _countADS++;
    }

    public void ButtonClickPomni(Image image)
    {
        _imagePanel.sprite = image.sprite;
        _allPersons.gameObject.SetActive(false);
        _panel.gameObject.SetActive(true);
        _audioSource.clip = GetRundomAudio(_audioPomni);
        _audioSource.Play();
        _countADS++;
    }

    public void ButtonClickRagatha(Image image)
    {
        _imagePanel.sprite = image.sprite;
        _allPersons.gameObject.SetActive(false);
        _panel.gameObject.SetActive(true);
        _audioSource.clip = GetRundomAudio(_audioRagatha);
        _audioSource.Play();
        _countADS++;
    }

    public void ButtonClickZooble(Image image)
    {
        _imagePanel.sprite = image.sprite;
        _allPersons.gameObject.SetActive(false);
        _panel.gameObject.SetActive(true);
        _audioSource.clip = GetRundomAudio(_audioZooble);
        _audioSource.Play();
        _countADS++;
    }

    public void ButonExit()
    {
        _allPersons.gameObject.SetActive(true);
        _panel.gameObject.SetActive(false);
        _audioSource.Stop();

        if (_countADS == 5)
        {
            YandexGame.FullscreenShow();
            _countADS = 0;
        }
    }

    private AudioClip GetRundomAudio(AudioClip[] audioClips)
    {
        int randomNumber = Random.Range(0, audioClips.Length);
        return audioClips[randomNumber];
    }
}
