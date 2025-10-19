using Unity.Mathematics;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] PaperPuzzle papPuzz;
    [SerializeField] PuzzleScript[] puzzles = null;
    int currPhase = 0;

    void OnEnable()
    {
        CubbyManager.taskComplete += NextPhase;
        papPuzz.finishedStage2.AddListener(NextPhase);
    }

    void OnDisable()
    {
        CubbyManager.taskComplete -= NextPhase;
        papPuzz.finishedStage2.RemoveListener(NextPhase);
    }

    void Start()
    {
        puzzles = GetComponentsInChildren<PuzzleScript>();
        puzzles[1].gameObject.SetActive(false);
        puzzles[2].gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("l"))
            ChangeStage(1);
        else if (Input.GetKeyDown("j"))
            ChangeStage(-1);

        if (Input.GetMouseButton(0))
            papPuzz.finishedStage2?.Invoke();
    }

    void ChangeStage(int change)
    {
        puzzles[currPhase].gameObject.SetActive(false);

        currPhase += change;
        math.abs(currPhase);
        currPhase %= 3;

        puzzles[currPhase].gameObject.SetActive(true);
    }

    void NextPhase()
    {
        puzzles[currPhase++].gameObject.SetActive(false);
        currPhase = math.abs(currPhase) % 3;
        puzzles[currPhase].gameObject.SetActive(true);
    }
}
