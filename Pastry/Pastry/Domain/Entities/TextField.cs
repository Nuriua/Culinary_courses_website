﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pastry.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Название (заголовок)")]
        public override string Title { get; set; } = "Информационная страница";

        [Display(Name = "Название (заголовок)")]
        public override string Text { get; set; } = "Содержание заполняется администратором";

    }
}
