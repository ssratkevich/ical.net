﻿using Ical.Net.Interfaces.Components;
using Ical.Net.Interfaces.Serialization.Factory;

namespace Ical.Net.Serialization.Factory
{
    public class ComponentFactory : ICalendarComponentFactory
    {
        public virtual ICalendarComponent Build(string objectName)
        {
            ICalendarComponent c;
            var name = objectName.ToUpper();

            switch (name)
            {
                case Components.Alarm:
                    c = new Alarm();
                    break;
                case EventStatus.Name:
                    c = new CalendarEvent();
                    break;
                case Components.Freebusy:
                    c = new FreeBusy();
                    break;
                case Components.Journal:
                    c = new Journal();
                    break;
                case Components.Timezone:
                    c = new VTimeZone();
                    break;
                case TodoStatus.Name:
                    c = new Todo();
                    break;
                case Components.Calendar:
                    c = new Calendar();
                    break;
                default:
                    c = new CalendarComponent();
                    break;
            }
            c.Name = name;
            return c;
        }
    }
}