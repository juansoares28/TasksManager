using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Tasks.Domain;

namespace Tasks.Communication.Requests
{
     public class RequestTaskJson
    {
        [Required (ErrorMessage = "Titulo e necessario.")]
        public  string Title { get; set; } = string.Empty;
         
        public required string Description { get; set; } = string.Empty;
        public TaskPriority Priority { get; set; } = TaskPriority.Low;
    }
}
