using Syncfusion.SfSchedule.XForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ScheduleXamarin
{
    public class SchedulePageBehavior : Behavior<ContentPage>
    {
        SfSchedule schedule;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.schedule = bindable.FindByName<SfSchedule>("schedule");

            schedule.Locale = "fr";
            if (schedule.Locale == "fr")
            {
                if (Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.Android)
                {
                    DependencyService.Get<ILocalize>().SetLocale(new CultureInfo("fr"));
                }
                else
                {
                    CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("fr");
                }
            }
            else if (schedule.Locale == "ja")
            {
                if (Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.Android)
                {
                    DependencyService.Get<ILocalize>().SetLocale(new CultureInfo("ja"));
                }
                else
                {
                    CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("ja");
                }
            }
        }
    }
}

       