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
            this.Alternatives = new Queue<string>();
        }

        public Question(String question, Queue<String> alternatives)
        {
            this.Name = question;
            this.Alternatives = alternatives;
        }

        public Question(String question, List<String> alternatives)
        {
            this.Name = question;
            this.Alternatives = new Queue<String>();
            foreach (String alternative in alternatives)
            {
                this.Alternatives.Enqueue(alternative);
            }
        }

        public void addOneAlternative(string alternative)
        {
            this.Alternatives.Enqueue(alternative);
        }

        public string getNextAlternative()
        {
            return this.Alternatives.Dequeue();
        }

        public String Name {
            get
            {
                return _question;
            }
            set
            {
                _question = value;
            }
        }

        public Queue<String> Alternatives
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

        public static Question createQuestionFromJson(String json)
        {
            Question question = JsonConvert.DeserializeObject<Question>(json);

            return question;
        }
    }
}
