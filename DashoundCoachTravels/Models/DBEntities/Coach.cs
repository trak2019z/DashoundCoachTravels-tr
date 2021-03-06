﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DashoundCoachTravels.Models.DBEntities
{
    [Table("Coaches")]
    public class Coach
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter vehicle brand")]
        [StringLength(100)]
        [Display(Name = "Vehicle brand")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Enter vehicle model")]
        [StringLength(100)]
        [Display(Name = "Vehicle model")]
        public string VehModel { get; set; }

        [Required(ErrorMessage = "Enter number of seats")]
        [Range(1, 999, ErrorMessage = "Must be greater than 0")]
        [Display(Name = "Max number of seats")]
        public int Seats { get; set; }

        [Required(ErrorMessage = "Enter the date of acquiring the vehicle")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(NullDisplayText = "-")]
        [Display(Name = "Date Acquired")]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Enter vehicle number")]
        [Range(1, 999, ErrorMessage = "Must be greater than 0")]
        [Display(Name = "Vehicle Number")]
        public int VehicleNumber { get; set; }

        [Display(Name = "Vehicle Photo (optional)")]
        public string VehScreenshot { get; set; }

        /*[ForeignKey("TripsId")]
        public int Id_Trip { get; set; }

        public Trip TripsId { get; set; }
        */
    }
}