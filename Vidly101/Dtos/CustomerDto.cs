﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly101.Models;


namespace Vidly101.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        //Need a diffrent Dto for MembershipTyp
        public MembershipTypeDto MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }

//        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}