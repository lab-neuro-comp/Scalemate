using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateWPF.Models
{
    public class Scale
    {
        private Queue<Question> _questions;
        private string _name;
        private string _description;
        private List<Group> _groups;

        public Scale()
        {
            this.questions = new Queue<Question>();
        }

        public Scale(Queue<Question> questions)
        {
            this.questions = questions;
        }

        public Scale(List<Question> questions) {
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

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public List<Group> groups
        {
            get
            {
                return _groups;
            }
            set
            {
                _groups = value;
            }
        }

        public static Scale createTestFromJson(String json)
        {
            Scale test = JsonConvert.DeserializeObject<Scale>(json);

            return test;
        }
    }
}
