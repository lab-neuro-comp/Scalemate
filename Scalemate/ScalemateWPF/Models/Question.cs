using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateWPF.Models
{
    public class Question
    {
        private String _question;
        private Queue<String> _alternatives;

        public Question()
        {
            this.alternatives = new Queue<string>();
        }

        public Question(String question, Queue<String> alternatives)
        {
            this.question = question;
            this.alternatives = alternatives;
        }

        public Question(String question, List<String> alternatives)
        {
            this.question = question;
            this.alternatives = new Queue<String>();
            foreach (String alternative in alternatives)
            {
                this.alternatives.Enqueue(alternative);
            }
        }

        public void addOneAlternative(string alternative)
        {
            this.alternatives.Enqueue(alternative);
        }

        public string getNextAlternative()
        {
            return this.alternatives.Dequeue();
        }

        public String question {
            get
            {
                return _question;
            }
            set
            {
                _question = value;
            }
        }

        public Queue<String> alternatives
        {
            get
            {
                return _alternatives;
            }
            set
            {
                this._alternatives = value;
            }
        }

        public string Name { get => _question; set => _question = value; }
        public Queue<string> Alternatives { get => _alternatives; set => _alternatives = value; }

        public static Question createQuestionFromJson(String json)
        {
            Question question = JsonConvert.DeserializeObject<Question>(json);

            return question;
        }
    }
}
