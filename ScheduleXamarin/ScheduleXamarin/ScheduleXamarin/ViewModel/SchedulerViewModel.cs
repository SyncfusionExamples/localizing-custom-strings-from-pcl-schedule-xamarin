using Syncfusion.SfSchedule.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ScheduleXamarin
{
    public class SchedulerViewModel
    {
        public ScheduleAppointmentCollection Collection { get; set; } = new ScheduleAppointmentCollection();

        DateTime now = DateTime.Now;
        public SchedulerViewModel()
        {
            ScheduleAppointment scheduleAppointment = new ScheduleAppointment();
            scheduleAppointment.StartTime = new DateTime(now.Year, now.Month, now.Day, 10, 0, 0);
            scheduleAppointment.EndTime = new DateTime(now.Year, now.Month, now.Day, 11, 0, 0);
            scheduleAppointment.Subject = "Client Meeting";
            scheduleAppointment.Color = Color.Red;
            scheduleAppointment.IsAllDay = true;

            Collection.Add(scheduleAppointment);
        }
    }
}

