using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServerApp
{
    public class MeetingDialogBase: ComponentBase
    {
        [CascadingParameter] MudDialogInstance MudDialog { get; set; }
        [Parameter] public DateTime? SelectedDate { get; set; }

        protected string MeetingTitle { get; set; }
        protected string MeetingDescription { get; set; }
        protected TimeSpan StartTime { get; set; } = new TimeSpan(9, 0, 0);
        protected TimeSpan EndTime { get; set; } = new TimeSpan(10, 0, 0);

        protected void Cancel()
        {
            MudDialog.Cancel();
        }

        protected void SaveMeeting()
        {
            if (string.IsNullOrWhiteSpace(MeetingTitle) || string.IsNullOrWhiteSpace(MeetingDescription))
            {
                MudDialog.Close(DialogResult.Ok(new { MeetingTitle, MeetingDescription, StartTime, EndTime }));
            }
            else
            {
                MudDialog.Cancel();
            }
        }

        protected void OnStartTimeChanged(TimeSpan newTime)
        {
            StartTime = newTime;
        }

        protected void OnEndTimeChanged(TimeSpan newTime)
        {
            EndTime = newTime;
        }

    }
}