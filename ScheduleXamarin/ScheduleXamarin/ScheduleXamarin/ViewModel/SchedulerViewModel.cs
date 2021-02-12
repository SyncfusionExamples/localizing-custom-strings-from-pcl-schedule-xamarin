using Syncfusion.SfSchedule.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ScheduleXamarin
{

    public class SchedulerViewModel
    {
        public ScheduleAppointmentCollection scheduleAppointmentCollection { get; set; } = new ScheduleAppointmentCollection();

        public SchedulerViewModel()
        {
            ScheduleAppointment scheduleAppointment = new ScheduleAppointment();
            scheduleAppointment.StartTime = new DateTime(2018, 02, 14, 12, 0, 0);
            scheduleAppointment.EndTime = new DateTime(2018, 02, 14, 02, 0, 0);
            scheduleAppointment.Subject = "Meeting";
            scheduleAppointment.Location = "Chennai";
            scheduleAppointment.IsAllDay = true;

            scheduleAppointmentCollection.Add(scheduleAppointment);
        }
    }
}
