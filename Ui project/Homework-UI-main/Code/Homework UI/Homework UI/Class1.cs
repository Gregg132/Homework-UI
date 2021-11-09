using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_UI
{
    public class Homework
    {
        private string Subject;
        private string Name;
        private DateTime DueDate;
        private string Despcription;
        private bool Completed;

        public string Subject1 { get => Subject; set => Subject = value; }
        public string Name1 { get => Name; set => Name = value; }
        public DateTime DueDate1 { get => DueDate; set => DueDate = value; }
        public string Despcription1 { get => Despcription; set => Despcription = value; }
        public bool Completed1 { get => Completed; set => Completed = value; }

        public Homework(string Su, string N, bool CL, DateTime Du, string De)
        {
            Subject1 = Su;
            Name1 = N;
            DueDate1 = Du;
            Despcription1 = De;
            Completed1 = CL;
        }
    }
}
