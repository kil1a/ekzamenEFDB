﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DataBaseSTO.TablesBd
{
    [PrimaryKey(nameof(ID))]
    internal class BillSTO
    {
        [Key]
        public int ID { get; set; }
        public int Price { get; set; }
    }
}
