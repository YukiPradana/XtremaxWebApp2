using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XtremaxWebApp2.Data.DataModel
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Descrition { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public IdentityUser Asignee { get; set; }
        public IdentityUser Creator { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public Status Status { get; set; }
    }
}
