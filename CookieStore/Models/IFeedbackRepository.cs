﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieStore.Models
{
    public interface IFeedbackRepository
    {
        void AddFeedBack(Feedback feedback);
    }
}
