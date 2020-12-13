using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Day4
{
    class Question
    {
        public int id { get; set; }
        public string header { get; set; }
        public string body { get; set; }
        public int mark { get; set; }
        public Question(int id, string header, string body, int mark)
        {
            this.id = id;
            this.header = header;
            this.body = body;
            this.mark = mark;
        }
        public override string ToString()
        {
            return $"Question ID= {id} ,Question Header= {header} ,Question Body= {body} ,Question Mark= {mark}";
        }
    }
    class Answer
    {
        public int id { get; set; }
        public string txt { get; set; }
        public Answer(int id, string txt)
        {
            this.id = id;
            this.txt = txt;
        }
        public override string ToString()
        {
            return $"Answer ID= {id} ,Answer Text= {txt}";
        }
    }
    class Answerlist : List<Answer>
    {
        public string correctanswer { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Question, Answerlist> dic = new Dictionary<Question, Answerlist>();
            Answerlist ans1 = new Answerlist();
            ans1.Add(new Answer(1, "true"));
            ans1.Add(new Answer(2, "false"));
            ans1.correctanswer = "true";

            Answerlist ans2 = new Answerlist();
            ans2.Add(new Answer(1, "false"));
            ans2.Add(new Answer(2, "true"));
            ans2.correctanswer = "false";

            Answerlist ans3 = new Answerlist();
            ans3.Add(new Answer(1, "Design architure"));
            ans3.Add(new Answer(2, "Design Pattern"));
            ans3.Add(new Answer(3, "Interface Design"));
            ans3.Add(new Answer(4, "Designer tool"));
            ans3.correctanswer = "Design Pattern";


            Answerlist ans4 = new Answerlist();
            ans4.Add(new Answer(1, "Mathmatical Spasific languge"));
            ans4.Add(new Answer(2, "None oop languge"));
            ans4.Add(new Answer(3, "Low level languge"));
            ans4.Add(new Answer(4, "oop and multipurpose languge"));
            ans4.correctanswer = "oop and multipurpose languge";


            dic.Add(new Question(1, "true or false", "Is to prevent create object do static class?", 5), ans1);
            dic.Add(new Question(2, "true or false", "Is to prevent create object dont static class?", 5), ans2);
            dic.Add(new Question(3, "MCQ", "Singleton is?", 3), ans3);
            dic.Add(new Question(4, "MCQ", "C# is?", 3), ans4);




            foreach (var item in dic)
            {
                Console.WriteLine(item.Key.ToString());
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine(item2.ToString());
                }
            }
            Console.WriteLine("================================");
            string aswer = "";
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key.ToString());
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine(item2.ToString());
                    
                }
                Console.WriteLine($"correct answer is :{item.Value.correctanswer}");
            }

        }
    }
}
