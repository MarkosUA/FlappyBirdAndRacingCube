using UnityEngine;
using TMPro;
using Zenject;

public class Scores : MonoBehaviour
{
    private TMP_Text _text;

    [Inject]
    public void Construct()
    {
        _text = GetComponent<TMP_Text>();
    }

    public void UpdateScores(int scores)
    {
        _text.text = scores.ToString();
    }
}
