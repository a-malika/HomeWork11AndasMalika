﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public interface INotificationService
    {
        void SendNotification(User user, string message);
    }
}
