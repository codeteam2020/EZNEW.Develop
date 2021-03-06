﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EZNEW.Develop.CQuery.CriteriaConvert
{
    public interface ICriteriaConvert
    {
        /// <summary>
        /// convert name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// data
        /// </summary>
        object Data { get; set; }
    }
}
