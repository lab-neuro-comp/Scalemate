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
            this.Questions = new Queue<Question>();
        }

        public Scale(Queue<Question> questions)
        {
            this.Questions = questions;
        }

        public Scale(List<Question> questions) {
            this.Questions = new Queue<Question>();
            foreach(Question question in questions)
            {
                this.Questions.Enqueue(question);
            }
        }

        public void AddOneQuestion(Question question)
        {
            this.Questions.Enqueue(question);
        }

        public Question GetNextQuestion()
        {
            return this.Questions.Dequeue();
        }

        public Queue<Question> Questions
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

        public string Name
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

        public string Description
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

        public List<Group> Groups
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

        public static Scale CreateTestFromJson(String json)
        {
            Scale test = JsonConvert.DeserializeObject<Scale>(json);

            return test;
        }
    }
}
