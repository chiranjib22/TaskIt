using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TaskIt.Console.Models
{
    public class Task
    {
        public Guid Id { get;} = Guid.NewGuid();

        private string _title;
        public string Title { get; private set; }
        public DateTime CreatedAt { get; } = DateTime.Now;
        private DateTime? _dueDate;
        public DateTime? DueDate
        {
            get{ return _dueDate;}
            set
            {
                if (value > CreatedAt || value == null)
                    _dueDate = value;
                else
                    throw new ArgumentException("Due date must be greater than creation Date");
            }
        }

        public DateTime? UpdateAt { get; private set; }
    }
}