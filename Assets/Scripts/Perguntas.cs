using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Perguntas : MonoBehaviour
{
    public Text Question;
    public Text AnswerA;
    public Text AnswerB;
    public Text AnswerC;
    public Text AnswerD;
    public Text TotaPerguntas; 

    public static int pontos = 0;
    public string[] Questions;
    public static List<string> UnAnsweredQuestions;
    public string[] AlternativeA;
    public string[] AlternativeB;
    public string[] AlternativeC;
    public string[] AlternativeD;
    public string[] RightAnswer;

    public static List<string> UnAnswerA;
    public static List<string> UnAnswerB;
    public static List<string> UnAnswerC;
    public static List<string> UnAnswerD;
    public static List<string> UnAnswerRight;

    public int idQuestion;
    public int allQuestions;
    public int totalPerguntas = 1;

    private SomManagement SomManagement; 
    
    
    // Start is called before the first frame update
    void Start()
    {
       
        SomManagement = FindObjectOfType(typeof(SomManagement)) as SomManagement;

        SetQuestion();
      
        TotaPerguntas.text = "1 de 6 perguntas";


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetQuestion()
    {

        TotaPerguntas.text = ((totalPerguntas += 1).ToString()) + " de 6 perguntas";
        if (totalPerguntas == 7) //PQ to adicionando +1 cada clique anterior 
        {
            SceneManager.LoadScene("Transicao");
        }

        
        if (UnAnsweredQuestions == null || UnAnsweredQuestions.Count == 0)
        {
            print("Preencheu a lista");
            UnAnsweredQuestions = Questions.ToList<string>();
            UnAnswerA = AlternativeA.ToList<string>();
            UnAnswerB = AlternativeB.ToList<string>();
            UnAnswerC = AlternativeC.ToList<string>();
            UnAnswerD = AlternativeD.ToList<string>();
            UnAnswerRight = RightAnswer.ToList<string>();
            
        } 

        allQuestions = UnAnsweredQuestions.Count;
        idQuestion = Random.Range(0, UnAnsweredQuestions.Count);
        Question.text = UnAnsweredQuestions[idQuestion];
        AnswerA.text = UnAnswerA[idQuestion];
        AnswerB.text = UnAnswerB[idQuestion];
        AnswerC.text = UnAnswerC[idQuestion];
        AnswerD.text = UnAnswerD[idQuestion];

    }

    /* public void OnMouseDown()
     {
        string AlternativeX = GetComponent<string>();
         if (AlternativeX == RightAnswer[idQuestion])
         {
             print("Acertou Mizeravi");
         }
     } */

    public void Resposta(string Alternativa)
    {
        UnAnsweredQuestions.RemoveAt(idQuestion);
  
        if (Alternativa == "A")
        {
           
            if (UnAnswerA[idQuestion] == UnAnswerRight[idQuestion])
            {
                SomManagement.TocarSom(SomManagement.respostaCerta);
                UnAnswerA.RemoveAt(idQuestion);
                UnAnswerB.RemoveAt(idQuestion);
                UnAnswerC.RemoveAt(idQuestion);
                UnAnswerD.RemoveAt(idQuestion);
                UnAnswerRight.RemoveAt(idQuestion);
                SetQuestion();
                pontos++;
            }
            else
            {
                SomManagement.TocarSom(SomManagement.respostaErrada);
                RemoveAll();
                SetQuestion();
            }
        }

        else if (Alternativa == "B")
        {
            if (UnAnswerB[idQuestion] == UnAnswerRight[idQuestion])
            {
                SomManagement.TocarSom(SomManagement.respostaCerta);
                RemoveAll();
                SetQuestion();
                pontos++;

            }
            else
            {
                SomManagement.TocarSom(SomManagement.respostaErrada);
                RemoveAll();
                SetQuestion();
            }

        }
        else if (Alternativa == "C")
        {
            if (UnAnswerC[idQuestion] == UnAnswerRight[idQuestion])
            {
                SomManagement.TocarSom(SomManagement.respostaCerta);
                RemoveAll();
                SetQuestion();
                pontos++;

            }
            else
            {
                SomManagement.TocarSom(SomManagement.respostaErrada);
                RemoveAll();
                SetQuestion();
            }
        }
        else if (Alternativa == "D")
        {
            if (UnAnswerD[idQuestion] == UnAnswerRight[idQuestion])
            {
                SomManagement.TocarSom(SomManagement.respostaCerta);
                RemoveAll();
                SetQuestion();
                pontos++;

            }
            else
            {
                SomManagement.TocarSom(SomManagement.respostaErrada);
                RemoveAll();
                SetQuestion();
            }
        }

       

    }

    private void RemoveAll()
    {
        UnAnswerA.RemoveAt(idQuestion);
        UnAnswerB.RemoveAt(idQuestion);
        UnAnswerC.RemoveAt(idQuestion);
        UnAnswerD.RemoveAt(idQuestion);
        UnAnswerRight.RemoveAt(idQuestion);
    }
}

