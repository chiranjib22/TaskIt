using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TaskIt.Console.Enums;

namespace TaskIt.Console.Models
{
    public class Task
    {
        public Guid Id { get;} = Guid.NewGuid();

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value is null || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title can not be empty or null");
                }
                else _title = value;
            }
        }
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
        public Priority Priority{ get; set; }
        public Status Status { get; set; } = Status.Pending;
    }
}