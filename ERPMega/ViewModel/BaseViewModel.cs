﻿using System;

namespace ERPMega.ViewModel
{
    public abstract class BaseViewModel
    {
        public int? Id { get; set; }
        public bool IsDelete { get; set; }
        public DateTime Inserted { get; set; }
    }
}
