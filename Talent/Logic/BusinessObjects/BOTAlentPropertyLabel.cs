﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentLogic.Logic.BusinessObjects
{
    public class BOTalentPropertyLabel
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; } = null;        

    }

}
