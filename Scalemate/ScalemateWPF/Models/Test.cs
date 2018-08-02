using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateWPF.Models
{
    public class Test
    {
        private Queue<Question> _questions;
        private string _name;

        public Test()
        {
            this.questions = new Queue<Question>();
        }

        public Test(Queue<Question> questions)
        {
            this.questions = questions;
        }

        public Test(List<Question> questions) {
            this.questions = new Queue<Question>();
            foreach(Question question in questions)
            {
                this.questions.Enqueue(question);
            }
        }

        public void addOneQuestion(Question question)
        {
            this.questions.Enqueue(question);
        }

        public Question getNextQuestion()
        {
            return this.questions.Dequeue();
        }

        public Queue<Question> questions
        {
            get
            {
                return _questions;
            }
            set
            {
                this._questions = value;
            }
        }

        public string Name { get => _name; set => _name = value; }

        public static Test createTestFromJson(String json)
        {
            Test test = JsonConvert.DeserializeObject<Test>(json);

            return test;
        }
    }
}
