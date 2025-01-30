using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServerApp
{
    public class TravelBase : ComponentBase
    {
        protected MudForm form;
        protected TravelDetails newTravel = new();
        protected List<TravelDetails> travelList = new();

        protected void AddTravel()
        {
            if (form.IsValid)
            {
                travelList.Add(new TravelDetails
                {
                    Destination = newTravel.Destination,
                    DepartureDate = newTravel.DepartureDate,
                    ReturnDate = newTravel.ReturnDate,
                    TravelType = newTravel.TravelType,
                    PreferredAirline = newTravel.PreferredAirline,
                    Motivation = newTravel.Motivation
                });

                // Clear the form
                newTravel = new();
            }
        }

        public class TravelDetails
        {
            [Required]
            public string Destination { get; set; }
            [Required]
            public DateTime? DepartureDate { get; set; }
            [Required]
            public DateTime? ReturnDate { get; set; }
            [Required]
            public string TravelType { get; set; }
            [Required]
            public string PreferredAirline { get; set; }
            [Required]
            public string Motivation { get; set; }
        }
    }
}
