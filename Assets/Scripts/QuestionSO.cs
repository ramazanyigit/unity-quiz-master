using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "QuizQuestion")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question";
    [SerializeField] string[] answers = new string[4];

    [Range(0, 3)]
    [SerializeField] int correctAnswerIndex = 0;


    public string GetQuestion()
    {
        return question;
    }
    public string GetAnswer(int index)
    {
        return answers[index];
    }
    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }
}
