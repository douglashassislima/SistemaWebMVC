using SistemaWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebMVC.Models
{
    public class TraineesRecords
    {
        public int Id{ get; set; }
        public DateTime Data { get; set; }
        public TraineeStatus Status { get; set; }
        public Trainee Trainee { get; set; }

        public TraineesRecords()
        {
        }

        public TraineesRecords(int id, DateTime data, TraineeStatus status, Trainee trainee)
        {
            Id = id;
            Data = data;
            Status = status;
            Trainee = trainee;
        }
    }
}
