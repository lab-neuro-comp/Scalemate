using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateProject.Model
{
    public class Question
    {
        private String _question;
        private Queue<Alternative> _alternatives;

        public Question()
        {
            this.Alternatives = new Queue<Alternative>();
        }

        public Question(String question, Queue<Alternative> alternatives)
        {
            this.Name = question;
            this.Alternatives = alternatives;
        }

        public Question(String question, List<Alternative> alternatives)
        {
            this.Name = question;
            this.Alternatives = new Queue<Alternative>();
            foreach (Alternative alternative in alternatives)
            {
                this.Alternatives.Enqueue(alternative);
            }
        }

        public void addOneAlternative(Alternative alternative)
        {
            this.Alternatives.Enqueue(alternative);
        }

        public Alternative getNextAlternative()
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

        public Queue<Alternative> Alternatives
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
